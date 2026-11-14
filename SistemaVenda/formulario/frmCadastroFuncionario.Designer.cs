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
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtComplemento = new TextBox();
            txtSenha = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            btncadastrar = new Button();
            txtConfirmarSenha = new TextBox();
            lblNome = new Label();
            lblTelefone = new Label();
            lblRua = new Label();
            lblComplemento = new Label();
            lblNumero = new Label();
            lblCep = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            dgvFuncionarios = new DataGridView();
            cbxAdm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 42);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "ex: João";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(448, 42);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "ex: João123";
            txtUsuario.Size = new Size(225, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(62, 92);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "ex: 15-99123-4567";
            txtTelefone.Size = new Size(180, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(62, 198);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "ex: Próximo ao mercado";
            txtComplemento.Size = new Size(206, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(448, 92);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "ex: 123456";
            txtSenha.Size = new Size(225, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(62, 154);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "ex: Rua das flores";
            txtRua.Size = new Size(206, 23);
            txtRua.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(62, 242);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "ex: 123";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(168, 242);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "ex: 12345-678";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 5;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = SystemColors.ActiveCaption;
            btncadastrar.Location = new Point(589, 171);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(224, 75);
            btncadastrar.TabIndex = 10;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(448, 136);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "ex: 123456";
            txtConfirmarSenha.Size = new Size(225, 23);
            txtConfirmarSenha.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(62, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(62, 74);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(62, 136);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(27, 15);
            lblRua.TabIndex = 12;
            lblRua.Text = "Rua";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(62, 180);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 13;
            lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(62, 224);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 14;
            lblNumero.Text = "Número";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(168, 224);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 15;
            lblCep.Text = "Cep";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(449, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(448, 74);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 17;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(448, 118);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(95, 15);
            lblConfirmarSenha.TabIndex = 18;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AllowUserToOrderColumns = true;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(3, 271);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(820, 354);
            dgvFuncionarios.TabIndex = 19;
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionário", "Administrador\t" });
            cbxAdm.Location = new Point(448, 180);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(135, 23);
            cbxAdm.TabIndex = 9;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(835, 625);
            Controls.Add(cbxAdm);
            Controls.Add(dgvFuncionarios);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblCep);
            Controls.Add(lblNumero);
            Controls.Add(lblComplemento);
            Controls.Add(lblRua);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btncadastrar);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtSenha);
            Controls.Add(txtComplemento);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastroFuncionario";
            Text = "Cadastro Funcionário";
            Load += frmCadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private TextBox txtComplemento;
        private TextBox txtSenha;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtCep;
        private Button btncadastrar;
        private TextBox txtConfirmarSenha;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblRua;
        private Label lblComplemento;
        private Label lblNumero;
        private Label lblCep;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private DataGridView dgvFuncionarios;
        private ComboBox cbxAdm;
    }
}