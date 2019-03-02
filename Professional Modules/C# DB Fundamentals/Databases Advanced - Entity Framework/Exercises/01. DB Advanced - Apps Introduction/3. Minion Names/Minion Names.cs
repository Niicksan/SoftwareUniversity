﻿using System;
using System.Data.SqlClient;

namespace MinionDB
{
    class Program
    {
        static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());
            string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Name FROM Villains WHERE Id = {villainId} ", connection);
                string villainName = (string)command.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId}");
                    return;
                }

                Console.WriteLine($"Villain: {villainName}");

                command = new SqlCommand(
                    $"SELECT m.Name, m.Age, " +
                    $"ROW_NUMBER() OVER(ORDER BY m.Name) as RowNum " +
                    $"FROM MinionsVillains AS mv " +
                    $"JOIN Minions As m ON mv.MinionId = m.Id " +
                    $"WHERE mv.VillainId = {villainId} " +
                    $"ORDER BY m.Name; ", connection);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("(no minions)");
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        string minionName = (string)reader["Name"];
                        long rowNum = (long)reader["RowNum"];
                        int minionAge = (int)reader["Age"];

                        Console.WriteLine($"{rowNum}. {minionName} {minionAge}");
                    }
                }
            }
        }
    }
}