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

        private ProdutoControle controller;

        private Produto? produtoSelecionado;

        private int totalDePaginas = 5;

        private int paginaAtual = 1;

        private int totalPorPagina = 5;

        public frmCadastroProduto()
        {
            InitializeComponent();
            controller = new ProdutoControle();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            //Encapsulando os dados
            Produto product = new Produto
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            // Enviar os dados para a controller
            try
            {
                bool resp = controller.criarProduto(product);

                if (resp)
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
            }catch (Exception ex)
            {
                // mostrar o porque deu erro
                MessageBox.Show(ex.Message,
                    "Erro no Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarProdutos()
        {
            totalDePaginas = controller.quantidadePaginas(totalPorPagina);
            if (paginaAtual > totalDePaginas)
            {
                paginaAtual = totalDePaginas;
            }

            atualizarLblPagina();

            List<Produto> list = controller.listarPorPagina(totalPorPagina, paginaAtual);
            this.dgvProdutos.DataSource = list;
            this.dgvProdutos.Columns["cod_funcionario"].Visible = false;

        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.cbxQuantidadeItens.SelectedIndex = 0;
            // finalizar listar os produtos
            carregarProdutos();
            //int paginas = controller.quantidadePaginas(5);
            //lblPaginas.Text = $"1 de {paginas}";


        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtMarca.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Value = 0;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // evento de atualizar
            produtoSelecionado.nome = this.txtNome.Text;
            produtoSelecionado.marca = this.txtMarca.Text;
            produtoSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            produtoSelecionado.quantidade = (int)this.txtQuantidade.Value;
            bool resp = controller.atualizar(produtoSelecionado);

            if (resp)
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
            Produto? produto = linha.DataBoundItem as Produto;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
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

        private void cbxQuantidadeItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            // capturar o número e recalcular as páginas
            this.totalPorPagina = int.Parse(this.cbxQuantidadeItens.Text);
            carregarProdutos();
        }
    }
}
