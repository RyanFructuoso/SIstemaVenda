using System;
using System.Collections.Generic;
using System.Text;
using SistemaVenda.model;
using SistemaVenda.repository;

namespace SistemaVenda.Controller
{
    internal class EmployeeController
    {
        private EmployeeRepository repository;

        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }

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

        public bool createEmployee(Employee funcionario)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao repository se o usuario existe

            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(funcionario.usuario);
            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = hash;
            
            repository.createEmployee(funcionario);

            return true;
        }
        
        public void deslogar()
        {
            Session.userAuth = null;
        }

        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }

        public List<Employee> getAllFuncionario()
        {
            return repository.getAllFuncionario();
        }

        public bool usuarioAdministrador()
        {
            if ( Session.userAuth == null )
            {
                return false;
            }
            return Session.userAuth.adm;
        }
    }
}