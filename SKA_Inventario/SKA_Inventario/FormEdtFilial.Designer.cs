namespace SKA_Inventario
{
    partial class FormEdtFilial
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbNomeFilial = new System.Windows.Forms.TextBox();
            this.txbIDFilial = new System.Windows.Forms.TextBox();
            this.txbCidadeFilial = new System.Windows.Forms.TextBox();
            this.txbLogradouroFilial = new System.Windows.Forms.TextBox();
            this.txbTelefoneFilial = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(20, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(20, 80);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 18);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(20, 110);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(89, 18);
            this.lblLogradouro.TabIndex = 3;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(20, 140);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 18);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txbNomeFilial
            // 
            this.txbNomeFilial.Location = new System.Drawing.Point(140, 48);
            this.txbNomeFilial.MaxLength = 50;
            this.txbNomeFilial.Name = "txbNomeFilial";
            this.txbNomeFilial.Size = new System.Drawing.Size(550, 20);
            this.txbNomeFilial.TabIndex = 5;
            // 
            // txbIDFilial
            // 
            this.txbIDFilial.Enabled = false;
            this.txbIDFilial.Location = new System.Drawing.Point(140, 18);
            this.txbIDFilial.Name = "txbIDFilial";
            this.txbIDFilial.ReadOnly = true;
            this.txbIDFilial.Size = new System.Drawing.Size(550, 20);
            this.txbIDFilial.TabIndex = 6;
            // 
            // txbCidadeFilial
            // 
            this.txbCidadeFilial.Location = new System.Drawing.Point(140, 78);
            this.txbCidadeFilial.MaxLength = 50;
            this.txbCidadeFilial.Name = "txbCidadeFilial";
            this.txbCidadeFilial.Size = new System.Drawing.Size(550, 20);
            this.txbCidadeFilial.TabIndex = 7;
            // 
            // txbLogradouroFilial
            // 
            this.txbLogradouroFilial.Location = new System.Drawing.Point(140, 108);
            this.txbLogradouroFilial.MaxLength = 50;
            this.txbLogradouroFilial.Name = "txbLogradouroFilial";
            this.txbLogradouroFilial.Size = new System.Drawing.Size(550, 20);
            this.txbLogradouroFilial.TabIndex = 8;
            // 
            // txbTelefoneFilial
            // 
            this.txbTelefoneFilial.Location = new System.Drawing.Point(140, 138);
            this.txbTelefoneFilial.MaxLength = 50;
            this.txbTelefoneFilial.Name = "txbTelefoneFilial";
            this.txbTelefoneFilial.Size = new System.Drawing.Size(550, 20);
            this.txbTelefoneFilial.TabIndex = 9;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(170, 190);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(126, 23);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.Text = "Aplicar Mudanças";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(436, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormEdtFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 242);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txbTelefoneFilial);
            this.Controls.Add(this.txbLogradouroFilial);
            this.Controls.Add(this.txbCidadeFilial);
            this.Controls.Add(this.txbIDFilial);
            this.Controls.Add(this.txbNomeFilial);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNome);
            this.Name = "FormEdtFilial";
            this.Text = "Editar Filial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbNomeFilial;
        private System.Windows.Forms.TextBox txbIDFilial;
        private System.Windows.Forms.TextBox txbCidadeFilial;
        private System.Windows.Forms.TextBox txbLogradouroFilial;
        private System.Windows.Forms.TextBox txbTelefoneFilial;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
    }
}