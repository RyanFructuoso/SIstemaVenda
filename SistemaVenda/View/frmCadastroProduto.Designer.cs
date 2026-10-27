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
            txtnome = new TextBox();
            txtmarca = new TextBox();
            txtpreco = new TextBox();
            txtquantidade = new NumericUpDown();
            btnCadProduto = new Button();
            quantidade = new Label();
            preco = new Label();
            nome = new Label();
            marca = new Label();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            tabela = new Label();
            btnAnterior = new Button();
            lblPaginas = new Label();
            btnProximo = new Button();
            ((System.ComponentModel.ISupportInitialize)txtquantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(12, 25);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "ex: Ruffles";
            txtnome.Size = new Size(232, 23);
            txtnome.TabIndex = 0;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(260, 27);
            txtmarca.Name = "txtmarca";
            txtmarca.PlaceholderText = "ex: Lays";
            txtmarca.Size = new Size(232, 23);
            txtmarca.TabIndex = 1;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(12, 75);
            txtpreco.Name = "txtpreco";
            txtpreco.PlaceholderText = "R$ 00,00";
            txtpreco.Size = new Size(232, 23);
            txtpreco.TabIndex = 2;
            // 
            // txtquantidade
            // 
            txtquantidade.Location = new Point(260, 76);
            txtquantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtquantidade.Name = "txtquantidade";
            txtquantidade.Size = new Size(120, 23);
            txtquantidade.TabIndex = 3;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(508, 28);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(102, 73);
            btnCadProduto.TabIndex = 4;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // quantidade
            // 
            quantidade.AutoSize = true;
            quantidade.Location = new Point(260, 57);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(69, 15);
            quantidade.TabIndex = 5;
            quantidade.Text = "Quantidade";
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.Location = new Point(15, 57);
            preco.Name = "preco";
            preco.Size = new Size(37, 15);
            preco.TabIndex = 6;
            preco.Text = "Preco";
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(12, 9);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 7;
            nome.Text = "Nome";
            // 
            // marca
            // 
            marca.AutoSize = true;
            marca.Location = new Point(260, 9);
            marca.Name = "marca";
            marca.Size = new Size(40, 15);
            marca.TabIndex = 8;
            marca.Text = "Marca";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 135);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(752, 478);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(641, 13);
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
            btnExcluir.Location = new Point(641, 75);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 50);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // tabela
            // 
            tabela.AutoSize = true;
            tabela.Location = new Point(12, 117);
            tabela.Name = "tabela";
            tabela.Size = new Size(108, 15);
            tabela.TabIndex = 12;
            tabela.Text = "Tabela de produtos";
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
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(783, 661);
            Controls.Add(btnProximo);
            Controls.Add(lblPaginas);
            Controls.Add(btnAnterior);
            Controls.Add(tabela);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(marca);
            Controls.Add(nome);
            Controls.Add(preco);
            Controls.Add(quantidade);
            Controls.Add(btnCadProduto);
            Controls.Add(txtquantidade);
            Controls.Add(txtpreco);
            Controls.Add(txtmarca);
            Controls.Add(txtnome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastroProduto";
            Text = "frmCadastroProduto";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtquantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtmarca;
        private TextBox txtpreco;
        private NumericUpDown txtquantidade;
        private Button btnCadProduto;
        private Label quantidade;
        private Label preco;
        private Label nome;
        private Label marca;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Label tabela;
        private Button btnAnterior;
        private Label lblPaginas;
        private Button btnProximo;
    }
}