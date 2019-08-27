using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine("Load Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}
