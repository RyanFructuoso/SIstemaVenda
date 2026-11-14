using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.model
{
    internal class Venda
    {
        public int cod_vendas { get; set; }
        public int cod_funcionario { get; set; }
        public DateTime data {  get; set; }

        public List<Item> itens { get; set; }

        public string nomeFuncionario { get; set; }

    }
}
