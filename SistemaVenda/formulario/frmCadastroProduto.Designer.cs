namespace SistemaVenda.View
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new NumericUpDown();
            btnCadProduto = new Button();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblNome = new Label();
            lblMarca = new Label();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            lblTabela = new Label();
            btnAnterior = new Button();
            lblPaginas = new Label();
            btnProximo = new Button();
            cbxQuantidadeItens = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 25);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "ex: Ruffles";
            txtNome.Size = new Size(232, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(260, 27);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "ex: Lays";
            txtMarca.Size = new Size(232, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 75);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 00,00";
            txtPreco.Size = new Size(232, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(260, 76);
            txtQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(518, 28);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(102, 73);
            btnCadProduto.TabIndex = 4;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(260, 57);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 5;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 57);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preco";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(260, 9);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 154);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(752, 459);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(626, 13);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(102, 48);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(626, 67);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 50);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblTabela
            // 
            lblTabela.AutoSize = true;
            lblTabela.Location = new Point(12, 136);
            lblTabela.Name = "lblTabela";
            lblTabela.Size = new Size(108, 15);
            lblTabela.TabIndex = 12;
            lblTabela.Text = "Tabela de produtos";
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(12, 622);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(81, 30);
            btnAnterior.TabIndex = 13;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Location = new Point(155, 616);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(426, 40);
            lblPaginas.TabIndex = 14;
            lblPaginas.Text = "Página 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(683, 619);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(81, 33);
            btnProximo.TabIndex = 15;
            btnProximo.Text = "Próximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "10", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(643, 128);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(121, 23);
            cbxQuantidadeItens.TabIndex = 16;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(783, 661);
            Controls.Add(cbxQuantidadeItens);
            Controls.Add(btnProximo);
            Controls.Add(lblPaginas);
            Controls.Add(btnAnterior);
            Controls.Add(lblTabela);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(lblMarca);
            Controls.Add(lblNome);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(btnCadProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastroProduto";
            Text = "Cadastro Produto";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button btnCadProduto;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblNome;
        private Label lblMarca;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Label lblTabela;
        private Button btnAnterior;
        private Label lblPaginas;
        private Button btnProximo;
        private ComboBox cbxQuantidadeItens;
    }
}