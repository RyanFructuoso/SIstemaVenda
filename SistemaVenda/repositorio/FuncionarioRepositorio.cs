using MySqlConnector;
using SistemaVenda.database;
using SistemaVenda.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaVenda.repository
{
    internal class FuncionarioRepositorio
    {

        private Funcionario map(MySqlDataReader cursor)
        {
            return new Funcionario
            {
                cod_funcionario = cursor.GetInt32("cod_funcionario"),
                usuario = cursor.GetString("usuario"),
                telefone = cursor.GetString("telefone"),
                nome = cursor.GetString("nome"),
                senha = cursor.GetString("senha"),
                rua = ( cursor.IsDBNull(cursor.GetOrdinal("rua"))) ? null : cursor.GetString("rua"),
                numero = cursor.GetString("numero"),
                complemento = (cursor.IsDBNull(cursor.GetOrdinal("complemento"))) ? null : cursor.GetString("complemento"),
                cep = cursor.GetString("cep"),
                adm = cursor.GetBoolean("adm")
            };
        }

        public Funcionario? pegarPorNomeDeUsuario(string nomeDeUsuario)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@username", nomeDeUsuario);
            using var cursor = cmd.ExecuteReader();
            if (cursor.Read())
            {
                return map(cursor);
            }
            return null;
        }

        public int criarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = @"INSERT INTO funcionario
            (usuario, telefone, nome, senha, rua, numero, complemento, cep, adm) 
            VALUES 
            (@usuario, @telefone, @nome, @senha, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public List<Funcionario> listarFuncionarios()
        {
            using MySqlConnection conector = BancoDeDados.conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var cursor = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();
            while (cursor.Read())
            {
                lista.Add(map(cursor));
            }
            return lista;
        }
    }
}
