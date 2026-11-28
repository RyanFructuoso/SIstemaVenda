using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.model
{
    internal class Venda
    {
        public int cod_venda { get; set; }
        public int cod_funcionario { get; set; }
        public DateTime data {  get; set; }

        public List<Item> itens { get; set; } = new List<Item>();

        public decimal total => itens.Sum(itens => itens.subTotal);

        public string nomeFuncionario { get; set; }

    }
}
