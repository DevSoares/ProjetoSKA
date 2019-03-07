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
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.dataGVFilial = new System.Windows.Forms.DataGridView();
            this.btnDelFilial = new System.Windows.Forms.Button();
            this.btnEditFilial = new System.Windows.Forms.Button();
            this.btnCadFilial = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGVProdutos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(168, 11);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 2;
            this.btnExcluirProduto.Text = "excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(87, 11);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 1;
            this.btnEditarProduto.Text = "editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(6, 11);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProduto.TabIndex = 0;
            this.btnCadastrarProduto.Text = "cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGVFilial
            // 
            this.dataGVFilial.AllowUserToAddRows = false;
            this.dataGVFilial.AllowUserToDeleteRows = false;
            this.dataGVFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFilial.Location = new System.Drawing.Point(6, 40);
            this.dataGVFilial.MultiSelect = false;
            this.dataGVFilial.Name = "dataGVFilial";
            this.dataGVFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVFilial.Size = new System.Drawing.Size(706, 150);
            this.dataGVFilial.TabIndex = 3;
            // 
            // btnDelFilial
            // 
            this.btnDelFilial.Location = new System.Drawing.Point(168, 8);
            this.btnDelFilial.Name = "btnDelFilial";
            this.btnDelFilial.Size = new System.Drawing.Size(75, 23);
            this.btnDelFilial.TabIndex = 2;
            this.btnDelFilial.Text = "excluir";
            this.btnDelFilial.UseVisualStyleBackColor = true;
            this.btnDelFilial.Click += new System.EventHandler(this.btnDelFilial_Click);
            // 
            // btnEditFilial
            // 
            this.btnEditFilial.Location = new System.Drawing.Point(87, 8);
            this.btnEditFilial.Name = "btnEditFilial";
            this.btnEditFilial.Size = new System.Drawing.Size(75, 23);
            this.btnEditFilial.TabIndex = 1;
            this.btnEditFilial.Text = "editar";
            this.btnEditFilial.UseVisualStyleBackColor = true;
            this.btnEditFilial.Click += new System.EventHandler(this.btnEditFilial_Click);
            // 
            // btnCadFilial
            // 
            this.btnCadFilial.Location = new System.Drawing.Point(6, 7);
            this.btnCadFilial.Name = "btnCadFilial";
            this.btnCadFilial.Size = new System.Drawing.Size(75, 23);
            this.btnCadFilial.TabIndex = 0;
            this.btnCadFilial.Text = "cadastrar";
            this.btnCadFilial.UseVisualStyleBackColor = true;
            this.btnCadFilial.Click += new System.EventHandler(this.btnCadFilial_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 640);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGVProdutos);
            this.tabPage1.Controls.Add(this.btnExcluirProduto);
            this.tabPage1.Controls.Add(this.btnCadastrarProduto);
            this.tabPage1.Controls.Add(this.btnEditarProduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGVProdutos
            // 
            this.dataGVProdutos.AllowUserToAddRows = false;
            this.dataGVProdutos.AllowUserToDeleteRows = false;
            this.dataGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProdutos.Location = new System.Drawing.Point(6, 49);
            this.dataGVProdutos.MultiSelect = false;
            this.dataGVProdutos.Name = "dataGVProdutos";
            this.dataGVProdutos.ReadOnly = true;
            this.dataGVProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVProdutos.Size = new System.Drawing.Size(729, 150);
            this.dataGVProdutos.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelFilial);
            this.tabPage2.Controls.Add(this.dataGVFilial);
            this.tabPage2.Controls.Add(this.btnEditFilial);
            this.tabPage2.Controls.Add(this.btnCadFilial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filiais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movimentações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "SKA Inventário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnDelFilial;
        private System.Windows.Forms.Button btnEditFilial;
        private System.Windows.Forms.Button btnCadFilial;
        private System.Windows.Forms.DataGridView dataGVFilial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGVProdutos;
    }
}

