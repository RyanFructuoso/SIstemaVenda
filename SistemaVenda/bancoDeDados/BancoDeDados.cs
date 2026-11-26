using DotNetEnv;
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
            string caminho = Path.Combine(AppContext.BaseDirectory, ".env");
            Env.Load(caminho);

            MySqlConnectionStringBuilder construtor = new MySqlConnectionStringBuilder
            {
                Server = Env.GetString("DB_HOSTNAME"),
                Port = uint.Parse(Env.GetString("DB_PORT")),
                Database = Env.GetString("DB_NAME"),
                UserID = Env.GetString("DB_USER"),
                Password = Env.GetString("DB_PASSWORD")
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
