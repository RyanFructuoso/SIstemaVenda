namespace SistemaVenda.View
{
    partial class frmPrimary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimary));
            lblUsername = new Label();
            cadProduto = new Button();
            btnCadFuncionario = new Button();
            panel2 = new Panel();
            btnSair = new Button();
            panel1 = new Panel();
            painelPrincipal = new Panel();
            btnDadosUsuario = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(77, 85);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Cadastros";
            lblUsername.Click += lblUsername_Click;
            // 
            // cadProduto
            // 
            cadProduto.Location = new Point(23, 142);
            cadProduto.Name = "cadProduto";
            cadProduto.Size = new Size(158, 53);
            cadProduto.TabIndex = 2;
            cadProduto.Text = "Cadastrar Produto";
            cadProduto.UseVisualStyleBackColor = true;
            cadProduto.Click += cadProduto_Click;
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Location = new Point(23, 264);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(158, 53);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDadosUsuario);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(cadProduto);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 685);
            panel2.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(23, 609);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(158, 53);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(237, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 39);
            panel1.TabIndex = 5;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(237, 39);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(799, 646);
            painelPrincipal.TabIndex = 6;
            // 
            // btnDadosUsuario
            // 
            btnDadosUsuario.Location = new Point(23, 12);
            btnDadosUsuario.Name = "btnDadosUsuario";
            btnDadosUsuario.Size = new Size(158, 53);
            btnDadosUsuario.TabIndex = 4;
            btnDadosUsuario.Text = "Usuário";
            btnDadosUsuario.UseVisualStyleBackColor = true;
            btnDadosUsuario.Click += btnDadosUsuario_Click;
            // 
            // frmPrimary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1036, 685);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrimary";
            Text = "Tela inicial";
            Load += frmPrimary_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Button cadProduto;
        private Button btnCadFuncionario;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnDadosUsuario;
    }
}