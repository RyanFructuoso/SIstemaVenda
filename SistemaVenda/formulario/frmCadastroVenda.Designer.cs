namespace SistemaVenda.View
{
    partial class frmCadastroVenda
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
            cbxProdutos = new ComboBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblPreco = new Label();
            lblQuantidade = new Label();
            numQuantidade = new NumericUpDown();
            btnAdicionar = new Button();
            dgvCarrinho = new DataGridView();
            btnCadastrar = new Button();
            lblTotalVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(119, 28);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(561, 23);
            cbxProdutos.TabIndex = 0;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(119, 63);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(135, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitário: R$ XX,XX";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(119, 92);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(147, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade Disponivel: XX";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(560, 63);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(605, 92);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 39);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(12, 137);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(776, 253);
            dgvCarrinho.TabIndex = 5;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(328, 442);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(154, 78);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVenda.Location = new Point(36, 393);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(752, 46);
            lblTotalVenda.TabIndex = 7;
            lblTotalVenda.Text = "Total da Venda: R$XX,XX";
            lblTotalVenda.TextAlign = ContentAlignment.TopRight;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(lblTotalVenda);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvCarrinho);
            Controls.Add(btnAdicionar);
            Controls.Add(numQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProdutos);
            Name = "frmCadastroVenda";
            Text = "Cadastro Venda";
            Load += frmCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxProdutos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblPreco;
        private Label lblQuantidade;
        private NumericUpDown numQuantidade;
        private Button btnAdicionar;
        private DataGridView dgvCarrinho;
        private Button btnCadastrar;
        private Label lblTotalVenda;
    }
}