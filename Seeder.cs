using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Specialuppgift_1
{
  class Seeder
  {
    public static string database { get; set; } = @"C:\Users\karlu\OneDrive\Skrivbord\Skola\Specialuppgift 1.db";
    public static void Createnamn()
    {
       var sql = @"INSERT INTO Namn(Namn, Telefon, Pengar) VALUES('{0}','{1}', '{2}', COMMIT);";
      // Skapa en koppling till databasen
      using var sqlite2 = new SQLiteConnection("data source=" + Database.database);
      // Öppna kommunikationen
      sqlite2.Open();
      // Skapa ett SQL-kommando
      SQLiteCommand cmd = new SQLiteCommand(sql, sqlite2);
      // Kör SQL-koden
      cmd.ExecuteNonQuery();
      // Lägg till standarddata i databasen
    }
    public static void Removenamn()
    {
      var sql = @"SELECT * FROM Namn;
      DELETE FROM Namn WHERE Namn='{0}' COMMIT; ";
      // Skapa en koppling till databasen
      using var sqlite2 = new SQLiteConnection("data source=" + Database.database);
      // Öppna kommunikationen
      sqlite2.Open();
      // Skapa ett SQL-kommando
      SQLiteCommand cmd = new SQLiteCommand(sql, sqlite2);
      // Kör SQL-koden
      cmd.ExecuteNonQuery();
      // Lägg till standarddata i databasen
    }
    public static void Updatenamn()
    {
      var sql = @"SET namn = '{0}','{1}', '{2}', WHERE Namn = 'Namn' AND 'Telefon' AND 'Pengar', COMMIT";
      // Skapa en koppling till databasen
      using var sqlite2 = new SQLiteConnection("data source=" + Database.database);
      // Öppna kommunikationen
      sqlite2.Open();
      // Skapa ett SQL-kommando
      SQLiteCommand cmd = new SQLiteCommand(sql, sqlite2);
      // Kör SQL-koden
      cmd.ExecuteNonQuery();
      // Lägg till standarddata i databasen
    }
  }
}
