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
            lbltextnome = new Label();
            lbltextusuario = new Label();
            lbltexttelefone = new Label();
            label1 = new Label();
            lbltextrua = new Label();
            lbltextnumero = new Label();
            lbltextcep = new Label();
            lbltextcomplemento = new Label();
            txtboxRua = new TextBox();
            txtboxNumero = new TextBox();
            txtboxCep = new TextBox();
            txtboxComplemento = new TextBox();
            txtboxNome = new TextBox();
            txtboxUsuario = new TextBox();
            txtboxTelefone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbltextnome
            // 
            lbltextnome.AutoSize = true;
            lbltextnome.Location = new Point(12, 36);
            lbltextnome.Name = "lbltextnome";
            lbltextnome.Size = new Size(43, 15);
            lbltextnome.TabIndex = 0;
            lbltextnome.Text = "Nome:";
            // 
            // lbltextusuario
            // 
            lbltextusuario.AutoSize = true;
            lbltextusuario.Location = new Point(12, 101);
            lbltextusuario.Name = "lbltextusuario";
            lbltextusuario.Size = new Size(50, 15);
            lbltextusuario.TabIndex = 2;
            lbltextusuario.Text = "Usuário:";
            // 
            // lbltexttelefone
            // 
            lbltexttelefone.AutoSize = true;
            lbltexttelefone.Location = new Point(229, 37);
            lbltexttelefone.Name = "lbltexttelefone";
            lbltexttelefone.Size = new Size(55, 15);
            lbltexttelefone.TabIndex = 4;
            lbltexttelefone.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 6;
            label1.Text = "Dados do usuário";
            // 
            // lbltextrua
            // 
            lbltextrua.AutoSize = true;
            lbltextrua.Location = new Point(12, 212);
            lbltextrua.Name = "lbltextrua";
            lbltextrua.Size = new Size(30, 15);
            lbltextrua.TabIndex = 7;
            lbltextrua.Text = "Rua:";
            // 
            // lbltextnumero
            // 
            lbltextnumero.AutoSize = true;
            lbltextnumero.Location = new Point(229, 213);
            lbltextnumero.Name = "lbltextnumero";
            lbltextnumero.Size = new Size(54, 15);
            lbltextnumero.TabIndex = 9;
            lbltextnumero.Text = "Número:";
            // 
            // lbltextcep
            // 
            lbltextcep.AutoSize = true;
            lbltextcep.Location = new Point(12, 277);
            lbltextcep.Name = "lbltextcep";
            lbltextcep.Size = new Size(31, 15);
            lbltextcep.TabIndex = 11;
            lbltextcep.Text = "Cep:";
            // 
            // lbltextcomplemento
            // 
            lbltextcomplemento.AutoSize = true;
            lbltextcomplemento.Location = new Point(229, 277);
            lbltextcomplemento.Name = "lbltextcomplemento";
            lbltextcomplemento.Size = new Size(87, 15);
            lbltextcomplemento.TabIndex = 13;
            lbltextcomplemento.Text = "Complemento:";
            // 
            // txtboxRua
            // 
            txtboxRua.Location = new Point(12, 230);
            txtboxRua.Name = "txtboxRua";
            txtboxRua.PlaceholderText = "Rua";
            txtboxRua.Size = new Size(211, 23);
            txtboxRua.TabIndex = 15;
            // 
            // txtboxNumero
            // 
            txtboxNumero.Location = new Point(229, 231);
            txtboxNumero.Name = "txtboxNumero";
            txtboxNumero.PlaceholderText = "Numero";
            txtboxNumero.Size = new Size(206, 23);
            txtboxNumero.TabIndex = 16;
            txtboxNumero.TextChanged += txtboxNumero_TextChanged;
            // 
            // txtboxCep
            // 
            txtboxCep.Location = new Point(12, 295);
            txtboxCep.Name = "txtboxCep";
            txtboxCep.PlaceholderText = "Cep";
            txtboxCep.Size = new Size(211, 23);
            txtboxCep.TabIndex = 17;
            // 
            // txtboxComplemento
            // 
            txtboxComplemento.Location = new Point(229, 295);
            txtboxComplemento.Name = "txtboxComplemento";
            txtboxComplemento.PlaceholderText = "Complemento";
            txtboxComplemento.Size = new Size(206, 23);
            txtboxComplemento.TabIndex = 18;
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(12, 55);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.PlaceholderText = "Nome";
            txtboxNome.Size = new Size(211, 23);
            txtboxNome.TabIndex = 19;
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Location = new Point(12, 119);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.PlaceholderText = "Usuário";
            txtboxUsuario.Size = new Size(211, 23);
            txtboxUsuario.TabIndex = 20;
            // 
            // txtboxTelefone
            // 
            txtboxTelefone.Location = new Point(229, 55);
            txtboxTelefone.Name = "txtboxTelefone";
            txtboxTelefone.PlaceholderText = "Telefone";
            txtboxTelefone.Size = new Size(211, 23);
            txtboxTelefone.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 22;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 23;
            label3.Text = "Funcionário";
            // 
            // frmUsuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtboxTelefone);
            Controls.Add(txtboxUsuario);
            Controls.Add(txtboxNome);
            Controls.Add(txtboxComplemento);
            Controls.Add(txtboxCep);
            Controls.Add(txtboxNumero);
            Controls.Add(txtboxRua);
            Controls.Add(lbltextcomplemento);
            Controls.Add(lbltextcep);
            Controls.Add(lbltextnumero);
            Controls.Add(lbltextrua);
            Controls.Add(label1);
            Controls.Add(lbltexttelefone);
            Controls.Add(lbltextusuario);
            Controls.Add(lbltextnome);
            Name = "frmUsuário";
            Text = "frmUsuário";
            Load += frmUsuário_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltextnome;
        private Label lblnome;
        private Label lbltextusuario;
        private Label lbltexttelefone;
        private Label label1;
        private Label lbltextrua;
        private Label lbltextnumero;
        private Label lblNumero;
        private Label lbltextcep;
        private Label lblCep;
        private Label lbltextcomplemento;
        private Label lblComplemento;
        private TextBox txtboxRua;
        private TextBox txtboxNumero;
        private TextBox txtboxCep;
        private TextBox txtboxComplemento;
        private TextBox txtboxNome;
        private TextBox txtboxUsuario;
        private TextBox txtboxTelefone;
        private Label label2;
        private Label label3;
    }
}