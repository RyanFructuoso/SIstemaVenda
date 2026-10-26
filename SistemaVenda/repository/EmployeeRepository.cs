using MySqlConnector;
using SistemaVenda.database;
using SistemaVenda.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaVenda.repository
{
    internal class EmployeeRepository
    {

        private Employee map(MySqlDataReader reader)
        {
            return new Employee
            {
                id_funcionario = reader.GetInt32("id_funcionario"),
                usuario = reader.GetString("usuario"),
                telefone = reader.GetString("telefone"),
                nome = reader.GetString("nome"),
                senha = reader.GetString("senha"),
                rua = ( reader.IsDBNull(reader.GetOrdinal("rua"))) ? null : reader.GetString("rua"),
                numero = reader.GetString("numero"),
                complemento = (reader.IsDBNull(reader.GetOrdinal("complemento"))) ? null : reader.GetString("complemento"),
                cep = reader.GetString("cep")
            };
        }

        public Employee? getByUsername(string username)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@username", username);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return map(reader);
            }
            return null;
        }

        public int createEmployee(Employee employee)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO funcionario
            (usuario, telefone, nome, senha, rua, numero, complemento, cep) 
            VALUES 
            (@usuario, @telefone, @nome, @senha, @rua, @numero, @complemento, @cep)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@usuario", employee.usuario);
            cmd.Parameters.AddWithValue("@telefone", employee.telefone);
            cmd.Parameters.AddWithValue("@nome", employee.nome);
            cmd.Parameters.AddWithValue("@senha", employee.senha);
            cmd.Parameters.AddWithValue("@rua", employee.rua);
            cmd.Parameters.AddWithValue("@numero", employee.numero);
            cmd.Parameters.AddWithValue("@complemento", employee.complemento);
            cmd.Parameters.AddWithValue("@cep", employee.cep);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
    }
}
