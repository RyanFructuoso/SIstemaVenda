using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.model
{
    internal class Product
    {
        public int id_produto { get; set; }
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }
        public DateTime data_registro { get; set; }

        public void validar()
        {
            if (preco <= 0)
            {
                throw new ArgumentException("O preço não pode ser zerado!!");

            }
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade não pode ser menor que zero!!");
            }
        }
    }
}
