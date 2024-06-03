using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Model;


namespace ConsoleAppSQLiteTest
{
    internal class Program
    {


        public static SQLiteDb dbs;
        
        static void Main(string[] args)
        {

            
            Create();
            // wait for key press
            Console.ReadKey();

        }

        private static void Create()
        {
            
            dbs = new SQLiteDb("mydb.db");
            // create a new instance of the SQLiteDb class
            List<Model.task> tasks = dbs.readTasks("task");
            dbs.exportTableJSON(tasks);
        }

        private void test()
        {
            // niets
        }
    }
}
