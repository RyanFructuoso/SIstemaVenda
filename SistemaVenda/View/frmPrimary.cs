using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SistemaVenda.Controller;
using SistemaVenda.model;

namespace SistemaVenda.View
{
    public partial class frmPrimary : Form
    {

        private EmployeeController controller;
        public frmPrimary()
        {
            InitializeComponent();
            controller = new EmployeeController();
            Employee? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $"- {nome}";
        }

        private void frmPrimary_Load(object sender, EventArgs e)
        {
            //string username = Session.username;
            //bool isAdmin = Session.isAdmin;
            //this.lblUsername.Text = username;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void exibirFormulario(Form formulario)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            painelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            exibirFormulario(frm);
        }

        private void cadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // evento para sair
            controller.deslogar();
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void btnDadosUsuario_Click(object sender, EventArgs e)
        {
            frmUsuário frm = new frmUsuário();
            exibirFormulario(frm);
        }


    }
}
