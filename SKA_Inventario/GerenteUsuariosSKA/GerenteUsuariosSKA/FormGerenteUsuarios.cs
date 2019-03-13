using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenteUsuariosSKA
{
    public partial class FormGerenteUsuarios : Form
    {
        public FormGerenteUsuarios()
        {
            InitializeComponent();
        }

        private void btn_cad_usuario_Click(object sender, EventArgs e)
        {
            string usuario = txbNome.Text;
            string senha = txbSenha.Text;

            bool result = UserDataBase.AddUser(usuario, senha);
            UserDataBase.GetUsuarios(dataGridView1);
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
           // var username = txbNome.Text;
           // var password = txbSenha.Text;

            int userId = UserDataBase.GetUserIdByUsernameAndPassword(txbNome.Text, txbSenha.Text);            
            if (userId > 0)
            {
                // Now you can put users id in a session-variable or what you prefer
                // and redirect the user to the protected area of your website.
               MessageBox.Show(string.Format("You are userId : {0}", userId));
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void btn_list_users_Click(object sender, EventArgs e)
        {
            UserDataBase.GetUsuarios(dataGridView1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int disp;
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            if (chkDisponivel.CheckState == CheckState.Checked)
            {
                disp = 1;
            }
            else
            {
                disp = 0;
            }

            UserDataBase.EditUser(txbNome.Text, int.Parse(row.Cells["cd_usuario"].Value.ToString()), txbSenha.Text, disp);
            UserDataBase.GetUsuarios(dataGridView1);
        }
    }    
}
