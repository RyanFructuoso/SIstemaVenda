using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.database
{
    internal static class Database
    {
        private static string stringConnection;



        static Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };

            stringConnection = builder.ConnectionString;        
        }


        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
            try
            {
                // try this
                connection.Open();
                return connection;

            }catch(MySqlException ex)
            {
                // if don't work. Do this
                connection.Dispose();
                throw;
            }
        }


    }
}
