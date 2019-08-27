using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassTraining
{
    class Program
    {
        static void Main()
        {
            //DataAccess dataAccessLite = new SqliteDataAccess();
            //DataAccess dataAccess = new SqlDataAccess();

            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
