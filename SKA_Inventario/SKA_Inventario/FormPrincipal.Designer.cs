namespace SKA_Inventario
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnFiliais = new System.Windows.Forms.Button();
            this.pnlBtnProdutos = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlBtnFilial = new System.Windows.Forms.Panel();
            this.dataGVFilial = new System.Windows.Forms.DataGridView();
            this.btnDelFilial = new System.Windows.Forms.Button();
            this.btnEditFilial = new System.Windows.Forms.Button();
            this.btnCadFilial = new System.Windows.Forms.Button();
            this.pnlBtnProdutos.SuspendLayout();
            this.pnlBtnFilial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(12, 12);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnFiliais
            // 
            this.btnFiliais.Location = new System.Drawing.Point(113, 12);
            this.btnFiliais.Name = "btnFiliais";
            this.btnFiliais.Size = new System.Drawing.Size(75, 23);
            this.btnFiliais.TabIndex = 1;
            this.btnFiliais.Text = "Filiais";
            this.btnFiliais.UseVisualStyleBackColor = true;
            this.btnFiliais.Click += new System.EventHandler(this.btnFiliais_Click);
            // 
            // pnlBtnProdutos
            // 
            this.pnlBtnProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtnProdutos.Controls.Add(this.btnExcluir);
            this.pnlBtnProdutos.Controls.Add(this.btnEditar);
            this.pnlBtnProdutos.Controls.Add(this.btnCadastrar);
            this.pnlBtnProdutos.Location = new System.Drawing.Point(12, 41);
            this.pnlBtnProdutos.Name = "pnlBtnProdutos";
            this.pnlBtnProdutos.Size = new System.Drawing.Size(776, 397);
            this.pnlBtnProdutos.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(183, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(100, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(17, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlBtnFilial
            // 
            this.pnlBtnFilial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtnFilial.Controls.Add(this.dataGVFilial);
            this.pnlBtnFilial.Controls.Add(this.btnDelFilial);
            this.pnlBtnFilial.Controls.Add(this.btnEditFilial);
            this.pnlBtnFilial.Controls.Add(this.btnCadFilial);
            this.pnlBtnFilial.Location = new System.Drawing.Point(12, 41);
            this.pnlBtnFilial.Name = "pnlBtnFilial";
            this.pnlBtnFilial.Size = new System.Drawing.Size(776, 397);
            this.pnlBtnFilial.TabIndex = 3;
            // 
            // dataGVFilial
            // 
            this.dataGVFilial.AllowUserToAddRows = false;
            this.dataGVFilial.AllowUserToDeleteRows = false;
            this.dataGVFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFilial.Location = new System.Drawing.Point(17, 71);
            this.dataGVFilial.MultiSelect = false;
            this.dataGVFilial.Name = "dataGVFilial";
            this.dataGVFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVFilial.Size = new System.Drawing.Size(706, 150);
            this.dataGVFilial.TabIndex = 3;
            // 
            // btnDelFilial
            // 
            this.btnDelFilial.Location = new System.Drawing.Point(183, 0);
            this.btnDelFilial.Name = "btnDelFilial";
            this.btnDelFilial.Size = new System.Drawing.Size(75, 23);
            this.btnDelFilial.TabIndex = 2;
            this.btnDelFilial.Text = "excluir";
            this.btnDelFilial.UseVisualStyleBackColor = true;
            this.btnDelFilial.Click += new System.EventHandler(this.btnDelFilial_Click);
            // 
            // btnEditFilial
            // 
            this.btnEditFilial.Location = new System.Drawing.Point(100, 0);
            this.btnEditFilial.Name = "btnEditFilial";
            this.btnEditFilial.Size = new System.Drawing.Size(75, 23);
            this.btnEditFilial.TabIndex = 1;
            this.btnEditFilial.Text = "editar";
            this.btnEditFilial.UseVisualStyleBackColor = true;
            this.btnEditFilial.Click += new System.EventHandler(this.btnEditFilial_Click);
            // 
            // btnCadFilial
            // 
            this.btnCadFilial.Location = new System.Drawing.Point(17, 0);
            this.btnCadFilial.Name = "btnCadFilial";
            this.btnCadFilial.Size = new System.Drawing.Size(75, 23);
            this.btnCadFilial.TabIndex = 0;
            this.btnCadFilial.Text = "cadastrar";
            this.btnCadFilial.UseVisualStyleBackColor = true;
            this.btnCadFilial.Click += new System.EventHandler(this.btnCadFilial_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBtnFilial);
            this.Controls.Add(this.pnlBtnProdutos);
            this.Controls.Add(this.btnFiliais);
            this.Controls.Add(this.btnProdutos);
            this.Name = "FormPrincipal";
            this.Text = "SKA Inventário";
            this.pnlBtnProdutos.ResumeLayout(false);
            this.pnlBtnFilial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnFiliais;
        private System.Windows.Forms.Panel pnlBtnProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlBtnFilial;
        private System.Windows.Forms.Button btnDelFilial;
        private System.Windows.Forms.Button btnEditFilial;
        private System.Windows.Forms.Button btnCadFilial;
        private System.Windows.Forms.DataGridView dataGVFilial;
    }
}

