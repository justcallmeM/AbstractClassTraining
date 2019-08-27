using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Overriden Connection String");
            Console.WriteLine("testConnectionString from overriden method");

            string output = base.LoadConnectionString(name);
            output += " (from SQLite)";

            return output;
        }
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
