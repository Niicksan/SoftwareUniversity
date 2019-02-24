using System;
using System.Data.SqlClient;

namespace _6._Remove_Villain
{
    class Program
    {
        static void Main(string[] args)
        {
            int recivedVillainId = int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Id FROM Villains WHERE Id = '{recivedVillainId}'", connection);

                int? result = (int)command.ExecuteScalar();

                if (result == null)
                {
                    Console.WriteLine("No such villain was found.");
                    connection.Close();
                    return;
                }

                command = new SqlCommand($"SELECT COUNT(*) FROM MinionsVillains WHERE VillainId = '{recivedVillainId}'", connection);
                int minionsCount = (int)command.ExecuteScalar();

                command = new SqlCommand($"DELETE FROM MinionsVillains WHERE VillainId = '{recivedVillainId}'", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"SELECT Name FROM Villains WHERE Id = '{recivedVillainId}'", connection);
                string villainName = (string)command.ExecuteScalar();

                command = new SqlCommand($"DELETE FROM Villains WHERE Id = '{recivedVillainId}'", connection);
                command.ExecuteNonQuery();

                Console.WriteLine($"{villainName} was deleted.");
                Console.WriteLine($"{minionsCount} minions were released.");
            }
        }
    }
}