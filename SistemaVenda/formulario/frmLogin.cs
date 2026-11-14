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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = this.txtUsuario.Text;
            string password = this.txtSenha.Text;

            if (FuncionarioControle.autenticar(user, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("User or password incorrect", "Error in login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}