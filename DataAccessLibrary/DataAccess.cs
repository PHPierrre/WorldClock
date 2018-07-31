using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace DataAccessLibrary
{
    public static class DataAccess
    {
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=database.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Country (Id INTEGER PRIMARY KEY, " +
                    "Area NVARCHAR(100) NULL," +
                    "Timezone NVARCHAR(100) NULL)"; 

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        public static void AddData(string area, string timezone)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=database.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Country VALUES (NULL, @EntryOne, @EntryTwo);";
                insertCommand.Parameters.AddWithValue("@EntryOne", area);
                insertCommand.Parameters.AddWithValue("@EntryTwo", timezone);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public static List<Object> GetData()
        {

            List<Object> entries = new List<Object>();

            using (SqliteConnection db = new SqliteConnection("Filename=database.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT Id, Area, Timezone from Country", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(
                        new Country()
                        {
                            Id = query.GetInt16(0),
                            Area = query.GetString(1),
                            Timezone = query.GetString(2)
                        });
                }

                db.Close();
            }
            return entries;
        }

    }
}
