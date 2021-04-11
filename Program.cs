using System;
using System.Data;
using System.Data.SQLite;
using System.Threading;

namespace Specialuppgift_1
{
  class Program
  {
    public static string database { get; set; } = @"C:\Users\karlu\OneDrive\Skrivbord\Skola\Specialuppgift 1.db";

    static void Main(string[] args)
    {


      Console.WriteLine("[1] Lista");
      Console.WriteLine("[2] Lägg Till");
      Console.WriteLine("[3] Ta Bort");
      Console.WriteLine("[4] Exit");

      string input = Console.ReadLine();

      if (input == "1")
      {
        Console.Clear();
        Lista();
       
       }
      else if (input == "2")
      {
        Console.WriteLine("skriv namn ");
        string input1 = Console.ReadLine();
        if (input1 == "{0}")
        {
          Seeder.Createnamn();
        }
        
      }
      else if (input == "3")
      {
        Console.Clear();
        Console.WriteLine("vilken person vill du ta bort?");
        input = Console.ReadLine();
        if (input == $"{0}")
        {
          Seeder.Removenamn();
         
        }
       
      }

      else if (input == "4")
      {
        Console.WriteLine("Ha en bra dag!");
        Thread.Sleep(1000);
        Environment.Exit(0);
      }
    }
    public static DataTable Lista()
    {
      var sql = @"SELECT * FROM Namn
                  ORDER BY Namn;";
      DataTable dt = new DataTable();
      using (SQLiteConnection conn = new SQLiteConnection("data source=" + database))
      {
        conn.Open();
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);

        cmd.Parameters.AddWithValue("@minParamerer", "säkerinformation");

        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
        da.Fill(dt);
      }
      return dt;
    }

    

  }
}
