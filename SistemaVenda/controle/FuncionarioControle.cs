using System;
using System.Collections.Generic;
using System.Text;
using SistemaVenda.model;
using SistemaVenda.repository;

namespace SistemaVenda.Controller
{
    internal class FuncionarioControle
    {
        private FuncionarioRepositorio repositorio;

        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }

        public static bool autenticar(string usuario, string senha)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resposta = repositorio.pegarPorNomeDeUsuario(usuario);
            if (resposta == null)
            {
                return false;
            }

            // respo.senha = "$2a$11$9hoOx6nu7tT8rTJLP2ndRudARkpRhnpJ9YPL4IpL605OKZo9T2Rge"
            // password = "123"

            bool validarSenha;
            try
            {
                 validarSenha = BCrypt.Net.BCrypt.Verify(senha, resposta.senha);
            }catch (Exception ex)
            {
                validarSenha = false;
            }

            if ( !validarSenha )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!!!
            Sessao.usuarioAutenticado = resposta;
            return true;

        }   

        public bool criarFuncionario(Funcionario funcionario)
        {
            // fazer verificação se o usuario não existe
            // solicitar ao repository se o usuario existe

            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resposta = repositorio.pegarPorNomeDeUsuario(funcionario.usuario);
            if (resposta != null)
            {
                return false;
            }

            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhaCriptografada;
            
            repositorio.criarFuncionario(funcionario);

            return true;
        }
        
        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }

        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }

        public List<Funcionario> listarFuncionarios()
        {
            return repositorio.listarFuncionarios();
        }

        public bool usuarioAdministrador()
        {
            if ( Sessao.usuarioAutenticado == null )
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }
    }
}