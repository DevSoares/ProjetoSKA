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
            this.txbNomePrdt = new System.Windows.Forms.TextBox();
            this.lblNomePrdt = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxFiliaisPrdt = new System.Windows.Forms.ComboBox();
            this.lblFilialCadPrdt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNomePrdt
            // 
            this.txbNomePrdt.Location = new System.Drawing.Point(134, 30);
            this.txbNomePrdt.Name = "txbNomePrdt";
            this.txbNomePrdt.Size = new System.Drawing.Size(394, 20);
            this.txbNomePrdt.TabIndex = 0;
            // 
            // lblNomePrdt
            // 
            this.lblNomePrdt.AutoSize = true;
            this.lblNomePrdt.Location = new System.Drawing.Point(23, 33);
            this.lblNomePrdt.Name = "lblNomePrdt";
            this.lblNomePrdt.Size = new System.Drawing.Size(92, 13);
            this.lblNomePrdt.TabIndex = 1;
            this.lblNomePrdt.Text = "Nome do produto:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(122, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(340, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbxFiliaisPrdt
            // 
            this.cbxFiliaisPrdt.FormattingEnabled = true;
            this.cbxFiliaisPrdt.Location = new System.Drawing.Point(134, 72);
            this.cbxFiliaisPrdt.Name = "cbxFiliaisPrdt";
            this.cbxFiliaisPrdt.Size = new System.Drawing.Size(394, 21);
            this.cbxFiliaisPrdt.TabIndex = 4;
            // 
            // lblFilialCadPrdt
            // 
            this.lblFilialCadPrdt.AutoSize = true;
            this.lblFilialCadPrdt.Location = new System.Drawing.Point(48, 75);
            this.lblFilialCadPrdt.Name = "lblFilialCadPrdt";
            this.lblFilialCadPrdt.Size = new System.Drawing.Size(27, 13);
            this.lblFilialCadPrdt.TabIndex = 5;
            this.lblFilialCadPrdt.Text = "Filial";
            // 
            // FormCadPrdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 241);
            this.Controls.Add(this.lblFilialCadPrdt);
            this.Controls.Add(this.cbxFiliaisPrdt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNomePrdt);
            this.Controls.Add(this.txbNomePrdt);
            this.Name = "FormCadPrdt";
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomePrdt;
        private System.Windows.Forms.Label lblNomePrdt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxFiliaisPrdt;
        private System.Windows.Forms.Label lblFilialCadPrdt;
    }
}