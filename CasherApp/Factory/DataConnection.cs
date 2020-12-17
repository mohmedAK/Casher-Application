using CasherApp.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace CasherApp.Factory
{
    class DataConnection
    {
        public static IDbConnection ConVal()
        {
            if (Settings.Default.ServerMode == "SQL")
            {
                string[] connectionString1 = new string[]
                {
                    "Server="+ Settings.Default.ServerName +" ; ",
                    "Database="+ Settings.Default.DBName+" ; ",
                    "Integrated Security = false ;",
                    "UserID="+Settings.Default.UserName+" ; ",
                    "Password="+Settings.Default.UserPassword+";"
                };
                IDbConnection connection = new SqlConnection(string.Concat(connectionString1));

                return connection;
            }
            else
            {
                string[] connectionString2 = new string[]
               {
                    "Server="+ Settings.Default.ServerName +" ; ",
                    "Database="+ Settings.Default.DBName+" ; ",
                    "Integrated Security = true ;",

               };
                IDbConnection connection = new SqlConnection(string.Concat(connectionString2));
                return connection;
            }
        }
    }
}
