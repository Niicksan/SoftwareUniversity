using System;
using System.Data.SqlClient;

namespace MinionDB
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MinionsDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);
            

            using (connection)
            {
                try
                {
                    connection.Open();

                    string selectVilians =
                        "SELECT v.Name, COUNT(MinionId) AS [MinionCount] " +
                        "FROM Villains v " +
                        "JOIN MinionsVillains AS mv ON v.Id = mv.VillainId " +
                        "JOIN Minions AS m ON m.Id = mv.MinionId " +
                        "GROUP BY VillainId, v.Name " +
                        "HAVING COUNT(MinionId) > 3 " +
                        "ORDER BY [MinionCount] DESC;";

                    SqlCommand command = new SqlCommand(selectVilians, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
