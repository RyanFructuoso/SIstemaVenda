namespace SistemaVenda.View
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            txtnome = new TextBox();
            txtusuario = new TextBox();
            txttelefone = new TextBox();
            txtcomplemento = new TextBox();
            txtsenha = new TextBox();
            txtrua = new TextBox();
            txtnumero = new TextBox();
            txtcep = new TextBox();
            btncadastrar = new Button();
            txtconfirmarsenha = new TextBox();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(62, 42);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "Nome";
            txtnome.Size = new Size(180, 23);
            txtnome.TabIndex = 0;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(448, 59);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "Usuario";
            txtusuario.Size = new Size(225, 23);
            txtusuario.TabIndex = 6;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(62, 75);
            txttelefone.Name = "txttelefone";
            txttelefone.PlaceholderText = "Telefone";
            txttelefone.Size = new Size(180, 23);
            txttelefone.TabIndex = 1;
            txttelefone.TextChanged += txttelefone_TextChanged;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(62, 250);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.PlaceholderText = "Complemento";
            txtcomplemento.Size = new Size(206, 23);
            txtcomplemento.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(448, 103);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "Senha";
            txtsenha.Size = new Size(225, 23);
            txtsenha.TabIndex = 7;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(62, 221);
            txtrua.Name = "txtrua";
            txtrua.PlaceholderText = "Rua";
            txtrua.Size = new Size(206, 23);
            txtrua.TabIndex = 2;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(62, 279);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "Numero";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 4;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(168, 279);
            txtcep.Name = "txtcep";
            txtcep.PlaceholderText = "Cep";
            txtcep.Size = new Size(100, 23);
            txtcep.TabIndex = 5;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = SystemColors.ActiveCaption;
            btncadastrar.Location = new Point(491, 261);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(182, 124);
            btncadastrar.TabIndex = 9;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtconfirmarsenha
            // 
            txtconfirmarsenha.Location = new Point(448, 154);
            txtconfirmarsenha.Name = "txtconfirmarsenha";
            txtconfirmarsenha.PasswordChar = '*';
            txtconfirmarsenha.PlaceholderText = "Confirmar senha";
            txtconfirmarsenha.Size = new Size(225, 23);
            txtconfirmarsenha.TabIndex = 8;
            txtconfirmarsenha.TextChanged += txtconfirmarsenha_TextChanged;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(txtconfirmarsenha);
            Controls.Add(btncadastrar);
            Controls.Add(txtcep);
            Controls.Add(txtnumero);
            Controls.Add(txtrua);
            Controls.Add(txtsenha);
            Controls.Add(txtcomplemento);
            Controls.Add(txttelefone);
            Controls.Add(txtusuario);
            Controls.Add(txtnome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastroFuncionario";
            Text = "Cadastro Funcionário";
            Load += frmCadastroFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtusuario;
        private TextBox txttelefone;
        private TextBox txtcomplemento;
        private TextBox txtsenha;
        private TextBox txtrua;
        private TextBox txtnumero;
        private TextBox txtcep;
        private Button btncadastrar;
        private TextBox txtconfirmarsenha;
    }
}