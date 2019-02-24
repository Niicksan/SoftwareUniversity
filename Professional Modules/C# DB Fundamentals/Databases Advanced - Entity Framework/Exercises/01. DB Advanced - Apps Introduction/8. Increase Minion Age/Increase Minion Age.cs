using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace _8._Increase_Minion_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputIds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            String connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            List<int> minionIds = new List<int>();
            List<string> minionaNames = new List<string>();
            List<int> minionAges = new List<int>();

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM Minions WHERE Id IN ({String.Join(", ", inputIds)})", connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        minionIds.Add((int)reader["Id"]);
                        minionaNames.Add((string)reader["Name"]);
                        minionAges.Add((int)reader["Age"]);
                    }
                }

                for (int i = 0; i < minionIds.Count; i++)
                {
                    int id = minionIds[i];
                    string name = minionaNames[i];
                    int age = minionAges[i] + 1;

                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    name = textInfo.ToTitleCase(name);

                    command = new SqlCommand($"UPDATE Minions SET Name = '{name}', Age = '{age}' WHERE Id = '{id}'", connection);
                    command.ExecuteNonQuery();
                }

                command = new SqlCommand($"SELECT * FROM Minions", connection);
                reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"{(int)reader["Id"]} {(string)reader["Name"]} {(int)reader["Age"]}");
                    }
                }
            }
        }
    }
}
