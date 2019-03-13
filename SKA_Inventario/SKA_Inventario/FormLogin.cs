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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int cod_usuario = ConManager.GetUserIdByUsernameAndPassword(txbUsuario.Text, txbSenha.Text);
            if(Program.ValidLogin(cod_usuario, txbUsuario.Text) == true)
            {
                this.Dispose();
            }
        }
    }
}
