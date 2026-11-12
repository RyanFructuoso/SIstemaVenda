using SistemaVenda.model;
using SistemaVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Controller
{
    internal class VendaController
    {
        EmployeeController employeeController;
        VendaRepository vendaRepository;

        public VendaController()
        {
            employeeController = new EmployeeController();
            vendaRepository = new VendaRepository();
        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Employee? funcionario = employeeController.usuarioAutenticado();

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
            vendaRepository.cadastrarVenda(venda);

            return true;
        }

    }
}