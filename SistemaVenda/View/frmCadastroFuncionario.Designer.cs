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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(62, 42);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "ex: João";
            txtnome.Size = new Size(180, 23);
            txtnome.TabIndex = 0;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(448, 59);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "ex: João123";
            txtusuario.Size = new Size(225, 23);
            txtusuario.TabIndex = 6;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(62, 92);
            txttelefone.Name = "txttelefone";
            txttelefone.PlaceholderText = "ex: 15-99123-4567";
            txttelefone.Size = new Size(180, 23);
            txttelefone.TabIndex = 1;
            txttelefone.TextChanged += txttelefone_TextChanged;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(62, 261);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.PlaceholderText = "ex: Próximo ao mercado";
            txtcomplemento.Size = new Size(206, 23);
            txtcomplemento.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(448, 103);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "ex: 123456";
            txtsenha.Size = new Size(225, 23);
            txtsenha.TabIndex = 7;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(62, 210);
            txtrua.Name = "txtrua";
            txtrua.PlaceholderText = "ex: Rua das flores";
            txtrua.Size = new Size(206, 23);
            txtrua.TabIndex = 2;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(64, 313);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "ex: 123";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 4;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(170, 313);
            txtcep.Name = "txtcep";
            txtcep.PlaceholderText = "ex: 12345-678";
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
            txtconfirmarsenha.PlaceholderText = "ex: 123456";
            txtconfirmarsenha.Size = new Size(225, 23);
            txtconfirmarsenha.TabIndex = 8;
            txtconfirmarsenha.TextChanged += txtconfirmarsenha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 192);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "Rua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 243);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 13;
            label4.Text = "Complemento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 295);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 14;
            label5.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 295);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 15;
            label6.Text = "Cep";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 41);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 16;
            label7.Text = "Usuário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(448, 85);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 17;
            label8.Text = "Senha";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(449, 136);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 18;
            label9.Text = "Confirmar senha";
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}