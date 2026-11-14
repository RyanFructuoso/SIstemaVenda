using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.database
{
    internal static class BancoDeDados
    {
        private static string textoDeConexao;



        static BancoDeDados()
        {
            MySqlConnectionStringBuilder construtor = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "ryan_dbvendas",
                UserID = "root",
                Password = ""
            };

            textoDeConexao = construtor.ConnectionString;        
        }


        public static MySqlConnection conexao()
        {
            MySqlConnection conexao = new MySqlConnection(textoDeConexao);
            try
            {
                // tente isto
                conexao.Open();
                return conexao;

            }catch(MySqlException ex)
            {
                // se não funcionar, faça isto
                conexao.Dispose();
                throw;
            }
        }


    }
}
