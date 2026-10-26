using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SistemaVenda.Controller;

namespace SistemaVenda.View
{
    public partial class frmPrimary : Form
    {
        public frmPrimary()
        {
            InitializeComponent();
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

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.ShowDialog();
        }

        private void cadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.ShowDialog();
        }
    }
}
