using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _7._Print_All_Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            List<string> names = new List<string>();

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Name FROM Minions", connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];

                        names.Add(name);
                        
                    }

                    reader.Close();
                    connection.Close();
                }
                
            }

            int count = 0;

            while (true)
            {
                if (Math.Ceiling(names.Count / 2.0) <= count)
                {
                    return;
                }

                Console.WriteLine(names[count]);

                if (names.Count % 2 == 1 && (names.Count / 2) == count)
                {
                    return;
                }

                Console.WriteLine(names[names.Count - count - 1]);

                count++;
            }
        }
    }
}
