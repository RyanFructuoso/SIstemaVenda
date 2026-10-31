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
    public partial class frmUsuário : Form
    {
        private EmployeeController controller;
        public frmUsuário()
        {
            InitializeComponent();
            controller = new EmployeeController();
        }

        private void frmUsuário_Load(object sender, EventArgs e)
        {
            Employee? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            string usuario = (funcionario != null) ? funcionario.usuario : "";
            string telefone = (funcionario != null) ? funcionario.telefone : "";
            string rua = (funcionario != null) ? funcionario.rua : "";
            string numero = (funcionario != null) ? funcionario.numero : "";
            string cep = (funcionario != null) ? funcionario.cep : "";
            string complemento = (funcionario != null) ? funcionario.complemento : "";

            this.txtboxNome.Text = nome;
            this.txtboxUsuario.Text = usuario;
            this.txtboxTelefone.Text = telefone;
            this.txtboxRua.Text = rua;
            this.txtboxNumero.Text = numero;
            this.txtboxCep.Text = cep;
            this.txtboxComplemento.Text = complemento;
        }

        private void txtboxNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
