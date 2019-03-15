using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKA_Inventario
{
    public partial class FormLogin : Form
    {
        static int cd_usuario;

        public static int get_cd_usuario()
        {
            return cd_usuario;
        }      

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int cod_usuario = ConManager.GetUserIdByUsernameAndPassword(txbUsuario.Text, txbSenha.Text);
            if(Program.ValidLogin(cod_usuario, txbUsuario.Text) == true)
            {
<<<<<<< HEAD
                this.Dispose();
=======
                cd_usuario = cod_usuario;
                if (ConManager.ValidUser(cd_usuario)==true)
                {
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    formPrincipal.Text = formPrincipal.Text + " | Usuário: " + txbUsuario.Text + " |";
                    this.Hide();
                    formPrincipal.FormClosed += new FormClosedEventHandler(formPrincipal.FormPrincipal_FormClosed);
                }
                else
                {
                    MessageBox.Show("Usuário Indisponível!");
                }
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
>>>>>>> tela_movimentacoes
            }
        }
    }
}
