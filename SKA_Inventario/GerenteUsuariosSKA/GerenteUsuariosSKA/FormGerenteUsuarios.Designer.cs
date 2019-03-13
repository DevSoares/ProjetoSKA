namespace GerenteUsuariosSKA
{
    partial class FormGerenteUsuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btn_cad_usuario = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_list_users = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "senha:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txbNome.Location = new System.Drawing.Point(171, 22);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(322, 29);
            this.txbNome.TabIndex = 3;
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txbSenha.Location = new System.Drawing.Point(171, 67);
            this.txbSenha.MaxLength = 50;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(322, 29);
            this.txbSenha.TabIndex = 4;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // btn_cad_usuario
            // 
            this.btn_cad_usuario.Location = new System.Drawing.Point(53, 123);
            this.btn_cad_usuario.Name = "btn_cad_usuario";
            this.btn_cad_usuario.Size = new System.Drawing.Size(121, 23);
            this.btn_cad_usuario.TabIndex = 5;
            this.btn_cad_usuario.Text = "cadastrar usuario";
            this.btn_cad_usuario.UseVisualStyleBackColor = true;
            this.btn_cad_usuario.Click += new System.EventHandler(this.btn_cad_usuario_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(233, 123);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 6;
            this.btn_logar.Text = "logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_list_users
            // 
            this.btn_list_users.Location = new System.Drawing.Point(53, 163);
            this.btn_list_users.Name = "btn_list_users";
            this.btn_list_users.Size = new System.Drawing.Size(75, 23);
            this.btn_list_users.TabIndex = 7;
            this.btn_list_users.Text = "Listar";
            this.btn_list_users.UseVisualStyleBackColor = true;
            this.btn_list_users.Click += new System.EventHandler(this.btn_list_users_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(365, 122);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkDisponivel.Location = new System.Drawing.Point(574, 46);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(100, 24);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponivel";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // FormGerenteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_list_users);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.btn_cad_usuario);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGerenteUsuarios";
            this.Text = "Gerente de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btn_cad_usuario;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_list_users;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.CheckBox chkDisponivel;
    }
}

