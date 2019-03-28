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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.dataGVFilial = new System.Windows.Forms.DataGridView();
            this.btnDelFilial = new System.Windows.Forms.Button();
            this.btnEditFilial = new System.Windows.Forms.Button();
            this.btnCadFilial = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_pesq_prdt_cd = new System.Windows.Forms.Button();
            this.txb_CD_prdt = new System.Windows.Forms.TextBox();
            this.btn_pesq_prdt_filial = new System.Windows.Forms.Button();
            this.cb_prdt_filial = new System.Windows.Forms.ComboBox();
            this.btn_pesq_prdt = new System.Windows.Forms.Button();
            this.txbPesq = new System.Windows.Forms.TextBox();
            this.btn_ordem = new System.Windows.Forms.Button();
            this.dataGVProdutos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ordem_mov = new System.Windows.Forms.Button();
            this.btnPesqData = new System.Windows.Forms.Button();
            this.btnPesqFil = new System.Windows.Forms.Button();
            this.btnPesCodPrdt = new System.Windows.Forms.Button();
            this.btnListarMovimentacoes = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.gridViewMovimentacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovimentacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(168, 11);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(98, 23);
            this.btnExcluirProduto.TabIndex = 2;
            this.btnExcluirProduto.Text = "Alterar Status";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(87, 11);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 1;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(6, 11);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProduto.TabIndex = 0;
            this.btnCadastrarProduto.Text = "Cadastrar";
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
            this.dataGVFilial.ReadOnly = true;
            this.dataGVFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVFilial.Size = new System.Drawing.Size(830, 564);
            this.dataGVFilial.TabIndex = 3;
            this.dataGVFilial.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVFilial_CellMouseClick);
            // 
            // btnDelFilial
            // 
            this.btnDelFilial.Location = new System.Drawing.Point(168, 8);
            this.btnDelFilial.Name = "btnDelFilial";
            this.btnDelFilial.Size = new System.Drawing.Size(91, 23);
            this.btnDelFilial.TabIndex = 2;
            this.btnDelFilial.Text = "Alterar Status";
            this.btnDelFilial.UseVisualStyleBackColor = true;
            this.btnDelFilial.Click += new System.EventHandler(this.btnDelFilial_Click);
            // 
            // btnEditFilial
            // 
            this.btnEditFilial.Location = new System.Drawing.Point(87, 8);
            this.btnEditFilial.Name = "btnEditFilial";
            this.btnEditFilial.Size = new System.Drawing.Size(75, 23);
            this.btnEditFilial.TabIndex = 1;
            this.btnEditFilial.Text = "Editar";
            this.btnEditFilial.UseVisualStyleBackColor = true;
            this.btnEditFilial.Click += new System.EventHandler(this.btnEditFilial_Click);
            // 
            // btnCadFilial
            // 
            this.btnCadFilial.Location = new System.Drawing.Point(6, 7);
            this.btnCadFilial.Name = "btnCadFilial";
            this.btnCadFilial.Size = new System.Drawing.Size(75, 23);
            this.btnCadFilial.TabIndex = 0;
            this.btnCadFilial.Text = "Cadastrar";
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
            this.tabPage1.Controls.Add(this.btn_pesq_prdt_cd);
            this.tabPage1.Controls.Add(this.txb_CD_prdt);
            this.tabPage1.Controls.Add(this.btn_pesq_prdt_filial);
            this.tabPage1.Controls.Add(this.cb_prdt_filial);
            this.tabPage1.Controls.Add(this.btn_pesq_prdt);
            this.tabPage1.Controls.Add(this.txbPesq);
            this.tabPage1.Controls.Add(this.btn_ordem);
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
            // btn_pesq_prdt_cd
            // 
            this.btn_pesq_prdt_cd.Location = new System.Drawing.Point(482, 11);
            this.btn_pesq_prdt_cd.Name = "btn_pesq_prdt_cd";
            this.btn_pesq_prdt_cd.Size = new System.Drawing.Size(45, 23);
            this.btn_pesq_prdt_cd.TabIndex = 10;
            this.btn_pesq_prdt_cd.Text = "Pesq";
            this.btn_pesq_prdt_cd.UseVisualStyleBackColor = true;
            this.btn_pesq_prdt_cd.Click += new System.EventHandler(this.btn_pesq_prdt_cd_Click);
            // 
            // txb_CD_prdt
            // 
            this.txb_CD_prdt.Location = new System.Drawing.Point(432, 12);
            this.txb_CD_prdt.MaxLength = 50;
            this.txb_CD_prdt.Name = "txb_CD_prdt";
            this.txb_CD_prdt.Size = new System.Drawing.Size(44, 20);
            this.txb_CD_prdt.TabIndex = 9;
            this.txb_CD_prdt.Text = "código";
            this.txb_CD_prdt.Click += new System.EventHandler(this.txb_CD_prdt_Click);
            this.txb_CD_prdt.TextChanged += new System.EventHandler(this.txb_CD_prdt_TextChanged);
            // 
            // btn_pesq_prdt_filial
            // 
            this.btn_pesq_prdt_filial.Location = new System.Drawing.Point(670, 11);
            this.btn_pesq_prdt_filial.Name = "btn_pesq_prdt_filial";
            this.btn_pesq_prdt_filial.Size = new System.Drawing.Size(58, 23);
            this.btn_pesq_prdt_filial.TabIndex = 8;
            this.btn_pesq_prdt_filial.Text = "Pesq";
            this.btn_pesq_prdt_filial.UseVisualStyleBackColor = true;
            this.btn_pesq_prdt_filial.Click += new System.EventHandler(this.btn_pesq_prdt_filial_Click);
            // 
            // cb_prdt_filial
            // 
            this.cb_prdt_filial.FormattingEnabled = true;
            this.cb_prdt_filial.Location = new System.Drawing.Point(543, 12);
            this.cb_prdt_filial.Name = "cb_prdt_filial";
            this.cb_prdt_filial.Size = new System.Drawing.Size(121, 21);
            this.cb_prdt_filial.TabIndex = 7;
            // 
            // btn_pesq_prdt
            // 
            this.btn_pesq_prdt.Location = new System.Drawing.Point(386, 11);
            this.btn_pesq_prdt.Name = "btn_pesq_prdt";
            this.btn_pesq_prdt.Size = new System.Drawing.Size(40, 23);
            this.btn_pesq_prdt.TabIndex = 6;
            this.btn_pesq_prdt.Text = "Pesq";
            this.btn_pesq_prdt.UseVisualStyleBackColor = true;
            this.btn_pesq_prdt.Click += new System.EventHandler(this.btn_pesq_prdt_Click);
            // 
            // txbPesq
            // 
            this.txbPesq.Location = new System.Drawing.Point(272, 12);
            this.txbPesq.MaxLength = 50;
            this.txbPesq.Name = "txbPesq";
            this.txbPesq.Size = new System.Drawing.Size(108, 20);
            this.txbPesq.TabIndex = 5;
            this.txbPesq.Text = "nome";
            this.txbPesq.Click += new System.EventHandler(this.txbPesq_Click);
            // 
            // btn_ordem
            // 
            this.btn_ordem.Location = new System.Drawing.Point(744, 11);
            this.btn_ordem.Name = "btn_ordem";
            this.btn_ordem.Size = new System.Drawing.Size(58, 23);
            this.btn_ordem.TabIndex = 4;
            this.btn_ordem.Text = "Data +";
            this.btn_ordem.UseVisualStyleBackColor = true;
            this.btn_ordem.Click += new System.EventHandler(this.btn_ordem_Click);
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
            this.dataGVProdutos.Size = new System.Drawing.Size(797, 555);
            this.dataGVProdutos.TabIndex = 3;
            this.dataGVProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVProdutos_CellMouseClick);
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
            this.tabPage3.Controls.Add(this.btn_ordem_mov);
            this.tabPage3.Controls.Add(this.btnPesqData);
            this.tabPage3.Controls.Add(this.btnPesqFil);
            this.tabPage3.Controls.Add(this.btnPesCodPrdt);
            this.tabPage3.Controls.Add(this.btnListarMovimentacoes);
            this.tabPage3.Controls.Add(this.btnHistorico);
            this.tabPage3.Controls.Add(this.btnMovimentar);
            this.tabPage3.Controls.Add(this.gridViewMovimentacoes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movimentações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ordem_mov
            // 
            this.btn_ordem_mov.Location = new System.Drawing.Point(583, 17);
            this.btn_ordem_mov.Name = "btn_ordem_mov";
            this.btn_ordem_mov.Size = new System.Drawing.Size(75, 23);
            this.btn_ordem_mov.TabIndex = 7;
            this.btn_ordem_mov.Text = "Data +";
            this.btn_ordem_mov.UseVisualStyleBackColor = true;
            this.btn_ordem_mov.Click += new System.EventHandler(this.btn_ordem_mov_Click);
            // 
            // btnPesqData
            // 
            this.btnPesqData.Location = new System.Drawing.Point(502, 17);
            this.btnPesqData.Name = "btnPesqData";
            this.btnPesqData.Size = new System.Drawing.Size(75, 23);
            this.btnPesqData.TabIndex = 6;
            this.btnPesqData.Text = "Pesq / Data";
            this.btnPesqData.UseVisualStyleBackColor = true;
            this.btnPesqData.Click += new System.EventHandler(this.btnPesqData_Click);
            // 
            // btnPesqFil
            // 
            this.btnPesqFil.Location = new System.Drawing.Point(421, 17);
            this.btnPesqFil.Name = "btnPesqFil";
            this.btnPesqFil.Size = new System.Drawing.Size(75, 23);
            this.btnPesqFil.TabIndex = 5;
            this.btnPesqFil.Text = "Pesq / Fil";
            this.btnPesqFil.UseVisualStyleBackColor = true;
            this.btnPesqFil.Click += new System.EventHandler(this.btnPesqFil_Click);
            // 
            // btnPesCodPrdt
            // 
            this.btnPesCodPrdt.Location = new System.Drawing.Point(340, 17);
            this.btnPesCodPrdt.Name = "btnPesCodPrdt";
            this.btnPesCodPrdt.Size = new System.Drawing.Size(75, 23);
            this.btnPesCodPrdt.TabIndex = 4;
            this.btnPesCodPrdt.Text = "Pesq / Cod";
            this.btnPesCodPrdt.UseVisualStyleBackColor = true;
            this.btnPesCodPrdt.Click += new System.EventHandler(this.btnPesCodPrdt_Click);
            // 
            // btnListarMovimentacoes
            // 
            this.btnListarMovimentacoes.Location = new System.Drawing.Point(207, 17);
            this.btnListarMovimentacoes.Name = "btnListarMovimentacoes";
            this.btnListarMovimentacoes.Size = new System.Drawing.Size(127, 23);
            this.btnListarMovimentacoes.TabIndex = 3;
            this.btnListarMovimentacoes.Text = "Listar Movimentações";
            this.btnListarMovimentacoes.UseVisualStyleBackColor = true;
            this.btnListarMovimentacoes.Click += new System.EventHandler(this.btnListarMovimentacoes_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(100, 17);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(101, 23);
            this.btnHistorico.TabIndex = 2;
            this.btnHistorico.Text = "Verificar Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.Location = new System.Drawing.Point(19, 17);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(75, 23);
            this.btnMovimentar.TabIndex = 1;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // gridViewMovimentacoes
            // 
            this.gridViewMovimentacoes.AllowUserToAddRows = false;
            this.gridViewMovimentacoes.AllowUserToDeleteRows = false;
            this.gridViewMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMovimentacoes.Location = new System.Drawing.Point(19, 58);
            this.gridViewMovimentacoes.Name = "gridViewMovimentacoes";
            this.gridViewMovimentacoes.ReadOnly = true;
            this.gridViewMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewMovimentacoes.Size = new System.Drawing.Size(804, 546);
            this.gridViewMovimentacoes.TabIndex = 0;
            this.gridViewMovimentacoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewMovimentacoes_CellMouseClick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "SKA Inventário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFilial)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProdutos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovimentacoes)).EndInit();
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
        private System.Windows.Forms.DataGridView gridViewMovimentacoes;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnListarMovimentacoes;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPesCodPrdt;
        private System.Windows.Forms.Button btnPesqFil;
        private System.Windows.Forms.Button btnPesqData;
        private System.Windows.Forms.Button btn_ordem;
        private System.Windows.Forms.Button btn_ordem_mov;
        private System.Windows.Forms.TextBox txbPesq;
        private System.Windows.Forms.Button btn_pesq_prdt_filial;
        private System.Windows.Forms.ComboBox cb_prdt_filial;
        private System.Windows.Forms.Button btn_pesq_prdt;
        private System.Windows.Forms.Button btn_pesq_prdt_cd;
        private System.Windows.Forms.TextBox txb_CD_prdt;
    }
}

