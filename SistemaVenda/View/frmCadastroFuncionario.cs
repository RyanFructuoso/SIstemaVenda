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
        private EmployeeController controller;

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new EmployeeController();
        }

        private void limparCampos()
        {
            this.txtnome.Clear();
            this.txtnumero.Clear();
            this.txtrua.Clear();
            this.txtnumero.Clear();
            this.txtcomplemento.Clear();
            this.txtcep.Clear();

            this.txtusuario.Clear();
            this.txtsenha.Clear();
            this.txtconfirmarsenha.Clear();
        }


        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionarios();
            this.cbxAdm.SelectedIndex = 0;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtnome.Text;
            string telefone = this.txtnumero.Text;
            string rua = this.txtrua.Text;
            string numero = this.txtnumero.Text;
            string complemento = this.txtcomplemento.Text;
            string cep = this.txtcep.Text;

            string usuario = this.txtusuario.Text;
            string senha = this.txtsenha.Text;
            string confirmarSenha = this.txtconfirmarsenha.Text;

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

            Employee funcionario = new Employee
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


            EmployeeController controller = new EmployeeController();
            bool resp = controller.createEmployee(funcionario);

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
            List<Employee> list = controller.getAllFuncionario();
            this.dgvFuncionarios.DataSource = list;
            this.dgvFuncionarios.Columns["senha"].Visible = false;
        }
    }
}
