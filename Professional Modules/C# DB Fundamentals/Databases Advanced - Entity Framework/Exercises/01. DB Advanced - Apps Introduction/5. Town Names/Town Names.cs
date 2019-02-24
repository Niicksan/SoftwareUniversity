using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _5._Change_Town_Names_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Id FROM Countries WHERE Name = '{countryName}'", connection);
                int? countryId = (int)command.ExecuteScalar();

                if (countryId == null)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    command = new SqlCommand($"SELECT COUNT(*) FROM Towns WHERE CountryId = '{countryId}'", connection);
                    int townsCount = (int)command.ExecuteScalar();

                    command = new SqlCommand($"SELECT * FROM Towns WHERE CountryId = {countryId}", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<String> townNamesAffected = new List<String>();
                    List<int> townIdsAffected = new List<int>();

                    using (reader)
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("No town names were affected.");
                            reader.Close();
                            connection.Close();
                            return;
                        }

                        while (reader.Read())
                        {
                            string townName = (string)reader["Name"];
                            int townId = (int)reader["Id"];

                            townNamesAffected.Add(townName.ToUpper());
                            townIdsAffected.Add(townId);
                        }
                    }

                    for (int i = 0; i < townIdsAffected.Count; i++)
                    {
                        command = new SqlCommand($"UPDATE Towns SET Name = '{townNamesAffected[i]}' WHERE Id = {townIdsAffected[i]}", connection);
                        command.ExecuteScalar();
                    }

                    Console.WriteLine($"{townsCount} town names were affected.");
                    Console.WriteLine($"[{String.Join(", ", townNamesAffected)}]");
                }
            }
        }
    }
}