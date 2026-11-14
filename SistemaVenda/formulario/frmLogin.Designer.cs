namespace SistemaVenda.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnAutenticar = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(67, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(227, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(67, 115);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(227, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAutenticar
            // 
            btnAutenticar.Location = new Point(126, 155);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(103, 29);
            btnAutenticar.TabIndex = 2;
            btnAutenticar.Text = "Acessar";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += btnLogin_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(126, 218);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 3;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(365, 262);
            Controls.Add(lblInfo);
            Controls.Add(btnAutenticar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnAutenticar;
        private Label lblInfo;
    }
}