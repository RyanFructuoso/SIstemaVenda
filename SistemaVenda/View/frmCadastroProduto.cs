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
    public partial class frmCadastroProduto : Form
    {

        private ProductController controller;

        private Product? produtoSelecionado;

        private int totalDePaginas = 5;

        private int paginaAtual = 1;

        private int totalPorPagina = 5;

        public frmCadastroProduto()
        {
            InitializeComponent();
            controller = new ProductController();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtnome.Text;
            string marca = this.txtmarca.Text;
            float preco = float.Parse(this.txtpreco.Text);
            int quantidade = Convert.ToInt32(this.txtquantidade.Text);

            //Encapsulando os dados
            Product product = new Product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            // Enviar os dados para a controller
            bool resp = controller.createProduct(product);
            if (preco < 1)
            {
                MessageBox.Show("Erro ao cadastrar o produto, preço inválido",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (quantidade < 0)
            {
                MessageBox.Show("Erro ao cadastrar o produto, quantidade inválida",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (resp)
            {
                MessageBox.Show("Produto cadastrado com sucesso",
                    "Cadastro Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                carregarProdutos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Produto",
                    "Cadastro Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarProdutos()
        {
            List<Product> list = controller.listarPorPagina(totalPorPagina, paginaAtual);
            this.dgvProdutos.DataSource = list;
            this.dgvProdutos.Columns["id_funcionario"].Visible = false;

            totalDePaginas = controller.quantidadePaginas(totalPorPagina);
            if (paginaAtual > totalDePaginas)
            {
                paginaAtual = totalDePaginas;
            }
            atualizarLblPagina();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            // finalizar listar os produtos
            carregarProdutos();
            //int paginas = controller.quantidadePaginas(5);
            //lblPaginas.Text = $"1 de {paginas}";
        }

        private void limparCampos()
        {
            this.txtnome.Clear();
            this.txtmarca.Clear();
            this.txtpreco.Clear();
            this.txtquantidade.Value = 0;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // evento de atualizar
            produtoSelecionado.nome = this.txtnome.Text;
            produtoSelecionado.marca = this.txtmarca.Text;
            produtoSelecionado.preco = float.Parse(this.txtpreco.Text);
            produtoSelecionado.quantidade = (int)this.txtquantidade.Value;
            bool resp = controller.atualizar(produtoSelecionado);

            if (produtoSelecionado.preco < 1)
            {
                MessageBox.Show("Erro ao atualizar o produto, preço inválido",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (produtoSelecionado.quantidade < 0)
            {
                MessageBox.Show("Erro ao atualizar o produto, quantidade inválida",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (resp)
            {
                MessageBox.Show("Produto Atualizado com sucesso",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                carregarProdutos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }

            else
            {
                MessageBox.Show("Erro ao atualizar o produto",
                                "Atualização do produto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow linha = this.dgvProdutos.Rows[e.RowIndex];
            Product? produto = linha.DataBoundItem as Product;

            this.txtnome.Text = produto.nome;
            this.txtmarca.Text = produto.marca;
            this.txtpreco.Text = produto.preco.ToString();
            this.txtquantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnAtualizar.Enabled = true;
            this.btnExcluir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resp = controller.excluir(produtoSelecionado);

            if (resp)
            {
                MessageBox.Show("Produto excluído com sucesso",
                "Excluír",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                carregarProdutos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }

            else
            {
                MessageBox.Show("Erro ao excluír o produto",
                "Excluír",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Manipular as páginas
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                atualizarLblPagina();
                carregarProdutos();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalDePaginas)
            {
                paginaAtual++;
                atualizarLblPagina();
                carregarProdutos();
            }
        }

        private void atualizarLblPagina()
        {
            this.lblPaginas.Text = $"Página {paginaAtual} de {totalDePaginas}";
        }
    }
}
