using SistemaVenda.model;
using SistemaVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Controller
{
    internal class VendaControle
    {
        FuncionarioControle FuncionarioControle;
        VendaRepositorio vendaRepositorio;

        public VendaControle()
        {
            FuncionarioControle = new FuncionarioControle();
            vendaRepositorio = new VendaRepositorio();
        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Funcionario? funcionario = FuncionarioControle.usuarioAutenticado();

            if (funcionario == null)
            {
                throw new Exception("Usuário não autenticado!!");
            }

            int cod_funcionario = funcionario.cod_funcionario;
            Venda venda = new Venda
            {
                cod_funcionario = cod_funcionario,
                itens = itens
            };

            // Repository
            vendaRepositorio.cadastrarVenda(venda);

            return true;
        }

    }
}