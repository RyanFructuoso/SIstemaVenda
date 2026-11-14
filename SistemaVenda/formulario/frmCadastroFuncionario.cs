using SistemaVenda.Controller;
using SistemaVenda.model;
using SistemaVenda.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioControle controller;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtNumero.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtComplemento.Clear();
            this.txtCep.Clear();

            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtConfirmarSenha.Clear();
        }


        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionarios();
            this.cbxAdm.SelectedIndex = 0;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtNumero.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string complemento = this.txtComplemento.Text;
            string cep = this.txtCep.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string confirmarSenha = this.txtConfirmarSenha.Text;

            bool adm = this.cbxAdm.SelectedIndex == 1;

            if (senha != confirmarSenha)
            {
                MessageBox.Show("Senhas não conferem",
                    "Senhas Incorretas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Chamar o controlador do usuario para criar cadastro

            Funcionario funcionario = new Funcionario
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm
            };


            FuncionarioControle controller = new FuncionarioControle();
            bool resp = controller.criarFuncionario(funcionario);

            if (resp)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso",
                    "Cadastro funcionário",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                carregarFuncionarios();
                this.cbxAdm.SelectedIndex = 0;
            } else
            {
                MessageBox.Show("Erro ao cadastrar funcionário",
                    "Cadastro Funcionário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregarFuncionarios()
        {
            List<Funcionario> list = controller.listarFuncionarios();
            this.dgvFuncionarios.DataSource = list;
            this.dgvFuncionarios.Columns["senha"].Visible = false;
        }
    }
}
