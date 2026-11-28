using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.model
{
    internal class Item
    {
        public int cod_itens {  get; set; }
        public int cod_produto { get; set; }
        public int cod_venda { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }

        public string nomeProduto { get; set; }
        public string marcaProduto { get; set; }

        public decimal precoReal => preco / 100m;
        public decimal subTotal => precoReal * quantidade;
    }
}
