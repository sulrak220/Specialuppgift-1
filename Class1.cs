using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace Specialuppgift_1
{
  class Database
  {
    public static string database { get; set; } = @"C:\Users\karlu\OneDrive\Skrivbord\Skola\Specialuppgift 1.db";

    public void Createnamn(string namn)
    {
      //SQLiteConnection.CreateFile(database);
      {
        var sql = "insert into namn(namn) values(@namn)";
        // Skapa en koppling till databasen
        using (var sqlite2 = new SQLiteConnection("data source=" + database))
        {
          // Öppna kommunikationen
          sqlite2.Open();
          // Skapa ett SQL-kommando
          SQLiteCommand cmd = new SQLiteCommand(sql, sqlite2);
          // Kör SQL-koden
          cmd.Parameters.AddWithValue("@namn", namn);
          cmd.ExecuteNonQuery();
          // Lägg till standarddata i databasen
        }
      }
    }
    public void Removenamn(string namn)
    {
      //SQLiteConnection.CreateFile(database);
      {
        var sql = "delete into namn(namn) values(@namn)";
        // Skapa en koppling till databasen
        using (var sqlite2 = new SQLiteConnection("data source=" + database))
        {
          // Öppna kommunikationen
          sqlite2.Open();
          // Skapa ett SQL-kommando
          SQLiteCommand cmd = new SQLiteCommand(sql, sqlite2);
          // Kör SQL-koden
          cmd.Parameters.AddWithValue("@namn", namn);
          cmd.ExecuteNonQuery();
          // Lägg till standarddata i databasen
        }
      }
    }
  
  }
}
