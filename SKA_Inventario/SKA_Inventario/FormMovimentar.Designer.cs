namespace SKA_Inventario
{
    partial class FormMovimentar
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
            this.label4 = new System.Windows.Forms.Label();
            this.txbCdPrdt = new System.Windows.Forms.TextBox();
            this.txbNomePrdt = new System.Windows.Forms.TextBox();
            this.cbDestinataria = new System.Windows.Forms.ComboBox();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbRemetente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(125, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(125, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(125, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filial Remetente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(413, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filial Destinatária";
            // 
            // txbCdPrdt
            // 
            this.txbCdPrdt.Enabled = false;
            this.txbCdPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbCdPrdt.Location = new System.Drawing.Point(315, 40);
            this.txbCdPrdt.Name = "txbCdPrdt";
            this.txbCdPrdt.Size = new System.Drawing.Size(228, 26);
            this.txbCdPrdt.TabIndex = 4;
            // 
            // txbNomePrdt
            // 
            this.txbNomePrdt.Enabled = false;
            this.txbNomePrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbNomePrdt.Location = new System.Drawing.Point(315, 85);
            this.txbNomePrdt.Name = "txbNomePrdt";
            this.txbNomePrdt.Size = new System.Drawing.Size(228, 26);
            this.txbNomePrdt.TabIndex = 5;
            // 
            // cbDestinataria
            // 
            this.cbDestinataria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDestinataria.FormattingEnabled = true;
            this.cbDestinataria.Location = new System.Drawing.Point(417, 175);
            this.cbDestinataria.Name = "cbDestinataria";
            this.cbDestinataria.Size = new System.Drawing.Size(204, 28);
            this.cbDestinataria.TabIndex = 7;
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMovimentar.Location = new System.Drawing.Point(204, 244);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(118, 40);
            this.btnMovimentar.TabIndex = 8;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(436, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbRemetente
            // 
            this.txbRemetente.Enabled = false;
            this.txbRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbRemetente.Location = new System.Drawing.Point(129, 177);
            this.txbRemetente.Name = "txbRemetente";
            this.txbRemetente.Size = new System.Drawing.Size(217, 26);
            this.txbRemetente.TabIndex = 10;
            // 
            // FormMovimentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbRemetente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.cbDestinataria);
            this.Controls.Add(this.txbNomePrdt);
            this.Controls.Add(this.txbCdPrdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMovimentar";
            this.Text = "FormMovimentar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCdPrdt;
        private System.Windows.Forms.TextBox txbNomePrdt;
        private System.Windows.Forms.ComboBox cbDestinataria;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbRemetente;
    }
}