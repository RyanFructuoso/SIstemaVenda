using SistemaVenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
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

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmarsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

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

            if (senha != confirmarSenha)
            {
                MessageBox.Show("Senhas não conferem",
                    "Senhas Incorretas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Chamar o controlador do usuario para criar cadastro
            EmployeeController controller = new EmployeeController();
            bool resp = controller.createEmployee(nome, telefone, rua, numero,
                complemento, cep, usuario, senha);

            if (resp)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso",
                    "Cadastro funcionário",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            } else
            {
                MessageBox.Show("Erro ao cadastrar funcionário",
                    "Cadastro Funcionário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
