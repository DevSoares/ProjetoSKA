namespace SKA_Inventario
{
    partial class FormDeletarFilial
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
            this.btnConfirmarExclusao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNomeFilial = new System.Windows.Forms.Label();
            this.lblIDFilial = new System.Windows.Forms.Label();
            this.lblCidadeFilial = new System.Windows.Forms.Label();
            this.lblLogradouroFilial = new System.Windows.Forms.Label();
            this.lblTelefoneFilial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmarExclusao
            // 
            this.btnConfirmarExclusao.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirmarExclusao.Location = new System.Drawing.Point(99, 170);
            this.btnConfirmarExclusao.Name = "btnConfirmarExclusao";
            this.btnConfirmarExclusao.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmarExclusao.TabIndex = 0;
            this.btnConfirmarExclusao.Text = "CONFIRMAR EXCLUSÃO";
            this.btnConfirmarExclusao.UseVisualStyleBackColor = false;
            this.btnConfirmarExclusao.Click += new System.EventHandler(this.btnConfirmarExclusao_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(331, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNomeFilial
            // 
            this.lblNomeFilial.AutoSize = true;
            this.lblNomeFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFilial.Location = new System.Drawing.Point(45, 20);
            this.lblNomeFilial.Name = "lblNomeFilial";
            this.lblNomeFilial.Size = new System.Drawing.Size(46, 18);
            this.lblNomeFilial.TabIndex = 2;
            this.lblNomeFilial.Text = "label1";
            // 
            // lblIDFilial
            // 
            this.lblIDFilial.AutoSize = true;
            this.lblIDFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFilial.Location = new System.Drawing.Point(45, 50);
            this.lblIDFilial.Name = "lblIDFilial";
            this.lblIDFilial.Size = new System.Drawing.Size(46, 18);
            this.lblIDFilial.TabIndex = 3;
            this.lblIDFilial.Text = "label2";
            // 
            // lblCidadeFilial
            // 
            this.lblCidadeFilial.AutoSize = true;
            this.lblCidadeFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeFilial.Location = new System.Drawing.Point(45, 80);
            this.lblCidadeFilial.Name = "lblCidadeFilial";
            this.lblCidadeFilial.Size = new System.Drawing.Size(46, 18);
            this.lblCidadeFilial.TabIndex = 4;
            this.lblCidadeFilial.Text = "label3";
            // 
            // lblLogradouroFilial
            // 
            this.lblLogradouroFilial.AutoSize = true;
            this.lblLogradouroFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouroFilial.Location = new System.Drawing.Point(45, 110);
            this.lblLogradouroFilial.Name = "lblLogradouroFilial";
            this.lblLogradouroFilial.Size = new System.Drawing.Size(46, 18);
            this.lblLogradouroFilial.TabIndex = 5;
            this.lblLogradouroFilial.Text = "label4";
            // 
            // lblTelefoneFilial
            // 
            this.lblTelefoneFilial.AutoSize = true;
            this.lblTelefoneFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFilial.Location = new System.Drawing.Point(45, 140);
            this.lblTelefoneFilial.Name = "lblTelefoneFilial";
            this.lblTelefoneFilial.Size = new System.Drawing.Size(46, 18);
            this.lblTelefoneFilial.TabIndex = 6;
            this.lblTelefoneFilial.Text = "label5";
            // 
            // FormDeletarFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 216);
            this.Controls.Add(this.lblTelefoneFilial);
            this.Controls.Add(this.lblLogradouroFilial);
            this.Controls.Add(this.lblCidadeFilial);
            this.Controls.Add(this.lblIDFilial);
            this.Controls.Add(this.lblNomeFilial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarExclusao);
            this.Name = "FormDeletarFilial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarExclusao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNomeFilial;
        private System.Windows.Forms.Label lblIDFilial;
        private System.Windows.Forms.Label lblCidadeFilial;
        private System.Windows.Forms.Label lblLogradouroFilial;
        private System.Windows.Forms.Label lblTelefoneFilial;
    }
}