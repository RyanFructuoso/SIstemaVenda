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
            lblCadastros = new Label();
            btnCadProduto = new Button();
            btnCadFuncionario = new Button();
            panel2 = new Panel();
            btnCadVenda = new Button();
            btnDadosUsuario = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            lblTitulo = new Label();
            painelPrincipal = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastros
            // 
            lblCadastros.AutoSize = true;
            lblCadastros.Location = new Point(77, 85);
            lblCadastros.Name = "lblCadastros";
            lblCadastros.Size = new Size(59, 15);
            lblCadastros.TabIndex = 0;
            lblCadastros.Text = "Cadastros";
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(23, 142);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(158, 53);
            btnCadProduto.TabIndex = 2;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += cadProduto_Click;
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Location = new Point(23, 264);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(158, 53);
            btnCadFuncionario.TabIndex = 3;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(btnCadVenda);
            panel2.Controls.Add(btnDadosUsuario);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(lblCadastros);
            panel2.Controls.Add(btnCadProduto);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 685);
            panel2.TabIndex = 4;
            // 
            // btnCadVenda
            // 
            btnCadVenda.Location = new Point(23, 349);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(158, 53);
            btnCadVenda.TabIndex = 4;
            btnCadVenda.Text = "Cadastrar Venda";
            btnCadVenda.UseVisualStyleBackColor = true;
            btnCadVenda.Click += button1_Click;
            // 
            // btnDadosUsuario
            // 
            btnDadosUsuario.Location = new Point(23, 12);
            btnDadosUsuario.Name = "btnDadosUsuario";
            btnDadosUsuario.Size = new Size(158, 53);
            btnDadosUsuario.TabIndex = 1;
            btnDadosUsuario.Text = "Usuário";
            btnDadosUsuario.UseVisualStyleBackColor = true;
            btnDadosUsuario.Click += btnDadosUsuario_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(23, 609);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(158, 53);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(237, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 39);
            panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.HotTrack;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(799, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "";
            lblTitulo.Text = "Titulo da Tela";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            painelPrincipal.BackColor = SystemColors.HotTrack;
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(237, 39);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(799, 646);
            painelPrincipal.TabIndex = 6;
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCadastros;
        private Button btnCadProduto;
        private Button btnCadFuncionario;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnDadosUsuario;
        private Button btnCadVenda;
        private Label lblTitulo;
    }
}