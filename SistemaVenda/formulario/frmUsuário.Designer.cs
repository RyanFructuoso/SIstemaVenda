namespace SistemaVenda.View
{
    partial class frmUsuário
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
            lblNome = new Label();
            lblUsuario = new Label();
            lblTelefone = new Label();
            lblDadosFuncionario = new Label();
            lblRua = new Label();
            lblNumero = new Label();
            lblCep = new Label();
            lblComplemento = new Label();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(357, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(357, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(577, 52);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDadosFuncionario
            // 
            lblDadosFuncionario.AutoSize = true;
            lblDadosFuncionario.Location = new Point(375, 9);
            lblDadosFuncionario.Name = "lblDadosFuncionario";
            lblDadosFuncionario.Size = new Size(99, 15);
            lblDadosFuncionario.TabIndex = 6;
            lblDadosFuncionario.Text = "Dados do usuário";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(357, 327);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(30, 15);
            lblRua.TabIndex = 7;
            lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(577, 142);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 9;
            lblNumero.Text = "Número:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(357, 247);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 11;
            lblCep.Text = "Cep:";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(577, 258);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 13;
            lblComplemento.Text = "Complemento:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(357, 345);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(211, 23);
            txtRua.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(577, 160);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(206, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(357, 276);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "Cep";
            txtCep.Size = new Size(211, 23);
            txtCep.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(577, 276);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(206, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(357, 70);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(211, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(357, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(211, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(577, 70);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(211, 23);
            txtTelefone.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197__1_;
            pictureBox1.Location = new Point(38, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 243);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // frmUsuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 387);
            Controls.Add(pictureBox1);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Controls.Add(txtComplemento);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(lblComplemento);
            Controls.Add(lblCep);
            Controls.Add(lblNumero);
            Controls.Add(lblRua);
            Controls.Add(lblDadosFuncionario);
            Controls.Add(lblTelefone);
            Controls.Add(lblUsuario);
            Controls.Add(lblNome);
            Name = "frmUsuário";
            Text = "Usuário";
            Load += frmUsuário_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblnome;
        private Label lblUsuario;
        private Label lblTelefone;
        private Label lblDadosFuncionario;
        private Label lblRua;
        private Label lblNumero;
        private Label lblCep;
        private Label lblComplemento;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private PictureBox pictureBox1;
    }
}