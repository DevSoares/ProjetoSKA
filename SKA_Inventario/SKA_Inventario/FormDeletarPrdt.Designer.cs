namespace SKA_Inventario
{
    partial class FormDeletarPrdt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodPrdt = new System.Windows.Forms.TextBox();
            this.txbNomePrdt = new System.Windows.Forms.TextBox();
            this.txbDataPrdt = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbDisp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Cadastro:";
            // 
            // txbCodPrdt
            // 
            this.txbCodPrdt.Enabled = false;
            this.txbCodPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbCodPrdt.Location = new System.Drawing.Point(197, 26);
            this.txbCodPrdt.Name = "txbCodPrdt";
            this.txbCodPrdt.Size = new System.Drawing.Size(333, 24);
            this.txbCodPrdt.TabIndex = 3;
            // 
            // txbNomePrdt
            // 
            this.txbNomePrdt.Enabled = false;
            this.txbNomePrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbNomePrdt.Location = new System.Drawing.Point(197, 56);
            this.txbNomePrdt.MaxLength = 50;
            this.txbNomePrdt.Name = "txbNomePrdt";
            this.txbNomePrdt.Size = new System.Drawing.Size(333, 24);
            this.txbNomePrdt.TabIndex = 4;
            // 
            // txbDataPrdt
            // 
            this.txbDataPrdt.Enabled = false;
            this.txbDataPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDataPrdt.Location = new System.Drawing.Point(197, 86);
            this.txbDataPrdt.Name = "txbDataPrdt";
            this.txbDataPrdt.Size = new System.Drawing.Size(333, 24);
            this.txbDataPrdt.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(141, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "ALTERAR STATUS";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbDisp
            // 
            this.ckbDisp.AutoSize = true;
            this.ckbDisp.Location = new System.Drawing.Point(210, 123);
            this.ckbDisp.Name = "ckbDisp";
            this.ckbDisp.Size = new System.Drawing.Size(15, 14);
            this.ckbDisp.TabIndex = 8;
            this.ckbDisp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(44, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Disponível:";
            // 
            // FormDeletarPrdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbDisp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbDataPrdt);
            this.Controls.Add(this.txbNomePrdt);
            this.Controls.Add(this.txbCodPrdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDeletarPrdt";
            this.Text = "Excluir Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodPrdt;
        private System.Windows.Forms.TextBox txbNomePrdt;
        private System.Windows.Forms.TextBox txbDataPrdt;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbDisp;
        private System.Windows.Forms.Label label4;
    }
}