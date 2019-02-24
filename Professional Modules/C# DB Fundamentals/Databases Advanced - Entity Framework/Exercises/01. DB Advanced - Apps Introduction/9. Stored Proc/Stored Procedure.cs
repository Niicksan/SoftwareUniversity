using System;
using System.Data.SqlClient;

namespace _9._Increase_Age_Stored_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Increase Age Stored Procedure
            // USE MinionsDB;
            // GO
            // CREATE PROCEDURE usp_GetOlder @Id INT
            // AS
            //     Update Minions
            //         Set Age += 1
            //     WHERE Id = @Id;
            // GO

            int id = int.Parse(Console.ReadLine());

            String connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"EXEC usp_GetOlder '{id}'", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"SELECT * FROM Minions WHERE Id = '{id}'", connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    reader.Read();

                    Console.WriteLine($"{(string)reader["Name"]} - {(int)reader["Age"]} years old");
                }
            }
        }
    }
}