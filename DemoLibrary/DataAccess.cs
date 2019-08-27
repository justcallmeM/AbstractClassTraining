using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public abstract class DataAccess
    {
        //which one is better? implement or override?
        //you have to write "virtual" if you want to override the method
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String from base");
            return "testConnectionString from base";
        }

        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
