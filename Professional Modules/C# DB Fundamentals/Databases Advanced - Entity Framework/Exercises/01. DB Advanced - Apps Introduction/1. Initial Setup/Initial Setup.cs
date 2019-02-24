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

                    SqlCommand createDatabase = new SqlCommand("CREATE DATABASE MinionsDB", connection);
                    createDatabase.ExecuteNonQuery();

                    SqlCommand createCountriesSQL = new SqlCommand("CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))", connection);
                    SqlCommand createTownsSQL = new SqlCommand("CREATE TABLE Towns (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), CountryId INT, CONSTRAINT FK_TownCountry FOREIGN KEY (CountryId) REFERENCES Countries(Id))", connection);
                    SqlCommand createMinionsSQL = new SqlCommand("CREATE TABLE Minions (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), Age INT, TownId INT, CONSTRAINT FK_Towns FOREIGN KEY (TownId) REFERENCES Towns(Id))", connection);
                    SqlCommand createEvilnessFactorsSQL = new SqlCommand("CREATE TABLE EvilnessFactors (Id INT PRIMARY KEY, Name VARCHAR(10) UNIQUE NOT NULL)", connection);
                    SqlCommand createVillainsSQL = new SqlCommand("CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT, CONSTRAINT FK_VillainEvilnessFactor FOREIGN KEY (EvilnessFactorId) REFERENCES EvilnessFactors(Id))", connection);
                    SqlCommand createMinionsVillainsSQL = new SqlCommand("CREATE TABLE MinionsVillains(MinionId INT, VillainId INT, CONSTRAINT FK_Minions FOREIGN KEY (MinionId) REFERENCES Minions(Id), CONSTRAINT  FK_Villains FOREIGN KEY (VillainId) REFERENCES Villains(Id), CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId))", connection);

                    createCountriesSQL.ExecuteNonQuery();
                    createTownsSQL.ExecuteNonQuery();
                    createMinionsSQL.ExecuteNonQuery();
                    createEvilnessFactorsSQL.ExecuteNonQuery();
                    createVillainsSQL.ExecuteNonQuery();
                    createMinionsVillainsSQL.ExecuteNonQuery();

                    SqlCommand insertCountriesSQL = new SqlCommand("INSERT INTO Countries VALUES ('Bulgaria'), ('United Kingdom'), ('United States of America'), ('France')", connection);
                    SqlCommand insertTownsSQL = new SqlCommand("INSERT INTO Towns (Name, CountryId) VALUES ('Sofia',1), ('Burgas',1), ('Varna', 1), ('London', 2),('Liverpool', 2),('Ocean City', 3),('Paris', 4)", connection);
                    SqlCommand insertMinionsSQL = new SqlCommand("INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),('kevin',12,2),('stuart',9,3), ('rob',22,3), ('michael',5,2),('pep',3,2)", connection);
                    SqlCommand insertEvilnessFactorsSQL = new SqlCommand("INSERT INTO EvilnessFactors VALUES (1, 'Super Good'), (2, 'Good'), (3, 'Bad'), (4, 'Evil'), (5, 'Super Evil')", connection);
                    SqlCommand insertVillainsSQL = new SqlCommand("INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru', 2),('Victor', 4),('Simon Cat', 3),('Pusheen', 1),('Mammal', 5)", connection);
                    SqlCommand insertMinionsVillainsSQL = new SqlCommand("INSERT INTO MinionsVillains VALUES (1, 2), (3, 1), (1, 3), (3, 3), (4, 1), (2, 2), (1, 1), (3, 4), (1, 4), (1, 5), (5, 1)", connection);

                    insertCountriesSQL.ExecuteNonQuery();
                    insertTownsSQL.ExecuteNonQuery();
                    insertMinionsSQL.ExecuteNonQuery();
                    insertEvilnessFactorsSQL.ExecuteNonQuery();
                    insertVillainsSQL.ExecuteNonQuery();
                    insertMinionsVillainsSQL.ExecuteNonQuery();

                }

                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}