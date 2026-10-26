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
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(279, 132);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Cadastros";
            lblUsername.Click += lblUsername_Click;
            // 
            // cadProduto
            // 
            cadProduto.Location = new Point(98, 113);
            cadProduto.Name = "cadProduto";
            cadProduto.Size = new Size(158, 53);
            cadProduto.TabIndex = 2;
            cadProduto.Text = "Cadastrar Produto";
            cadProduto.UseVisualStyleBackColor = true;
            cadProduto.Click += cadProduto_Click;
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Location = new Point(360, 113);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(158, 53);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Cadastrar Funcionário";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // frmPrimary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(646, 281);
            Controls.Add(cadProduto);
            Controls.Add(btnCadFuncionario);
            Controls.Add(lblUsername);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrimary";
            Text = "Tela inicial";
            Load += frmPrimary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button cadProduto;
        private Button btnCadFuncionario;
    }
}