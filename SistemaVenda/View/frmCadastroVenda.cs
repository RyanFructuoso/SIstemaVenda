using SistemaVenda.Controller;
using SistemaVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmCadastroVenda : Form
    {
        private ProductController produtocontrole;
        public frmCadastroVenda()
        {
            InitializeComponent();
            produtocontrole = new ProductController();
        }

        private void carregarProdutos()
        {
            List<Product> lista = produtocontrole.listarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "id_produto";
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitário: R$ {produto.preco}";
            this.lblQuantidade.Text = $"Quantidade Disponivel: {produto.quantidade}";
            this.numQuantidade.Maximum = produto.quantidade;
            this.numQuantidade.Value = (this.numQuantidade.Maximum > 0)? 1 : 0;
        }
    }
}
