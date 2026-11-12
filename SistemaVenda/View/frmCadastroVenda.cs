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
        private VendaController vendaController;
        private List<Item> carrinho = new List<Item>();
        public frmCadastroVenda()
        {
            InitializeComponent();
            produtocontrole = new ProductController();
            vendaController = new VendaController();
        }

        private void carregarProdutos()
        {
            List<Product> lista = produtocontrole.listarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "cod_produto";
        }

        private void configurarCarrinho()
        {
            this.dgvCarrinho.AutoGenerateColumns = false;
            this.dgvCarrinho.Columns.Clear();
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Produto",
                Name = "colunaProduto",
                DataPropertyName = "nomeProduto",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2"
                }
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantidade",
                Name = "colunaQuantidade",
                DataPropertyName = "quantidade",
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço unitário",
                Name = "colunaPreco",
                DataPropertyName = "precoReal",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2"
                }
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sub total",
                Name = "colunaSubTotal",
                DataPropertyName = "subTotal",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2"
                }
            });
        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = null;
            this.dgvCarrinho.DataSource = this.carrinho;
            this.btnCadastrar.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.subTotal);
            this.lblTotalVenda.Text = $"Total da Venda: {total:c2}";
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarProdutos();
            configurarCarrinho();
            atualizarCarrinho();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product produto = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitário: R$ {produto.precoReal:C2}";
            this.lblQuantidade.Text = $"Quantidade Disponivel: {produto.quantidade}";
            this.numQuantidade.Maximum = produto.quantidade;
            this.numQuantidade.Value = (this.numQuantidade.Maximum > 0) ? 1 : 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Product produto = this.cbxProdutos.SelectedItem as Product;
            int quantidade = (int)this.numQuantidade.Value;

            Item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_produto == produto.cod_produto);
            if (itemExistente == null)
            {
                Item novoItem = new Item
                {
                    cod_produto = produto.cod_produto,
                    quantidade = quantidade,
                    preco = produto.preco,
                    nomeProduto = produto.nome,
                    marcaProduto = produto.marca
                };
                this.carrinho.Add(novoItem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }
            produto.quantidade -= quantidade;
            this.cbxProdutos.SelectedItem = produto;
            cbxProdutos_SelectedIndexChanged(this, EventArgs.Empty);

            atualizarCarrinho();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.subTotal);
            DialogResult confirmar = MessageBox.Show(
                $"Deseja efetuar a venda no valor de: {total:C2}?",
                "Confirmar Venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if ( confirmar == DialogResult.No)
            {
                return;
            }
            // enviar os dados para o controle
            try
            {
                bool resposta = vendaController.cadastrarVenda(this.carrinho);
                if (resposta)
                {
                carrinho.Clear();
                frmCadastroVenda_Load(this, EventArgs.Empty);
                MessageBox.Show("Venda Cadastrada com Sucesso!!");
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar Venda!!", "Erro no cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro no cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
