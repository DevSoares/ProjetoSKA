namespace SKA_Inventario
{
    partial class FormCadPrdt
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
            this.components = new System.ComponentModel.Container();
            this.txbNomePrdt = new System.Windows.Forms.TextBox();
            this.lblNomePrdt = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFilial = new System.Windows.Forms.Label();
            this.filiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewFilial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.filiaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilial)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomePrdt
            // 
            this.txbNomePrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNomePrdt.Location = new System.Drawing.Point(148, 22);
            this.txbNomePrdt.MaxLength = 50;
            this.txbNomePrdt.Name = "txbNomePrdt";
            this.txbNomePrdt.Size = new System.Drawing.Size(380, 23);
            this.txbNomePrdt.TabIndex = 0;
            // 
            // lblNomePrdt
            // 
            this.lblNomePrdt.AutoSize = true;
            this.lblNomePrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomePrdt.Location = new System.Drawing.Point(23, 25);
            this.lblNomePrdt.Name = "lblNomePrdt";
            this.lblNomePrdt.Size = new System.Drawing.Size(122, 17);
            this.lblNomePrdt.TabIndex = 1;
            this.lblNomePrdt.Text = "Nome do produto:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(185, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(360, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilial.Location = new System.Drawing.Point(53, 81);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(44, 17);
            this.lblFilial.TabIndex = 4;
            this.lblFilial.Text = "Filial :";
            // 
            // filiaisBindingSource
            // 
            this.filiaisBindingSource.DataMember = "Filiais";
            // 
            // 
            // dataGridViewFilial
            // 
            this.dataGridViewFilial.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilial.Location = new System.Drawing.Point(148, 69);
            this.dataGridViewFilial.Name = "dataGridViewFilial";
            this.dataGridViewFilial.Size = new System.Drawing.Size(380, 73);
            this.dataGridViewFilial.TabIndex = 5;
            // 
            // FormCadPrdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 201);
            this.Controls.Add(this.dataGridViewFilial);
            this.Controls.Add(this.lblFilial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNomePrdt);
            this.Controls.Add(this.txbNomePrdt);
            this.Name = "FormCadPrdt";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.filiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomePrdt;
        private System.Windows.Forms.Label lblNomePrdt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.BindingSource filiaisBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewFilial;
    }
}