﻿namespace SKA_Inventario
{
    partial class FormEdtPrdt
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodPrdt = new System.Windows.Forms.TextBox();
            this.txbNomePrdt = new System.Windows.Forms.TextBox();
            this.txbDataPrdt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(185, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(360, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de cadastro:";
            // 
            // txbCodPrdt
            // 
            this.txbCodPrdt.Enabled = false;
            this.txbCodPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbCodPrdt.Location = new System.Drawing.Point(197, 26);
            this.txbCodPrdt.Name = "txbCodPrdt";
            this.txbCodPrdt.Size = new System.Drawing.Size(333, 24);
            this.txbCodPrdt.TabIndex = 6;
            // 
            // txbNomePrdt
            // 
            this.txbNomePrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbNomePrdt.Location = new System.Drawing.Point(197, 56);
            this.txbNomePrdt.MaxLength = 50;
            this.txbNomePrdt.Name = "txbNomePrdt";
            this.txbNomePrdt.Size = new System.Drawing.Size(333, 24);
            this.txbNomePrdt.TabIndex = 7;
            // 
            // txbDataPrdt
            // 
            this.txbDataPrdt.Enabled = false;
            this.txbDataPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDataPrdt.Location = new System.Drawing.Point(197, 86);
            this.txbDataPrdt.Name = "txbDataPrdt";
            this.txbDataPrdt.Size = new System.Drawing.Size(333, 24);
            this.txbDataPrdt.TabIndex = 8;
            // 
            // FormEdtPrdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 184);
            this.Controls.Add(this.txbDataPrdt);
            this.Controls.Add(this.txbNomePrdt);
            this.Controls.Add(this.txbCodPrdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Name = "FormEdtPrdt";
            this.Text = "Editar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodPrdt;
        private System.Windows.Forms.TextBox txbNomePrdt;
        private System.Windows.Forms.TextBox txbDataPrdt;
    }
}