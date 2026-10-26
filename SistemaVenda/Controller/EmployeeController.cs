using System;
using System.Collections.Generic;
using System.Text;
using SistemaVenda.model;
using SistemaVenda.repository;

namespace SistemaVenda.Controller
{
    internal class EmployeeController
    {
        public static bool login(string username, string password)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }

            // respo.senha = "$2a$11$9hoOx6nu7tT8rTJLP2ndRudARkpRhnpJ9YPL4IpL605OKZo9T2Rge"
            // password = "123"

            bool validatePassword;
            try
            {
                 validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }catch (Exception ex)
            {
                validatePassword = false;
            }

            if ( !validatePassword )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!!!
            Session.userAuth = resp;
            return true;

        }   

        public bool createEmployee(string nome, string telefone, 
            string cep, string numero, string rua,
            string complemento, string usuario, string senha)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao repository se o usuario existe

            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(usuario);
            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(senha);
            Employee funcionario = new Employee
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = hash
            };
            repository.createEmployee(funcionario);

            return true;
        }
    }
}
