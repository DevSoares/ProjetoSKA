using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKA_Inventario
{
    public partial class FormCadFilial : Form
    {
        public FormCadFilial()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbNomeFilial.Text)&&!string.IsNullOrWhiteSpace(txbCidadeFilial.Text)&&!string.IsNullOrWhiteSpace(txbLogFilial.Text)&&!string.IsNullOrWhiteSpace(txbTelFilial.Text))
            {
                ConManager.CadastrarFilial(txbNomeFilial.Text, txbCidadeFilial.Text, txbLogFilial.Text, txbTelFilial.Text);
                this.Close();

            }
            else
            {
                MessageBox.Show("Por favor preencha os campos acima!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }

        private void txbTelFilial_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbTelFilial.Text, "[^0-9]"))
            {
                MessageBox.Show("Favor digitar apenas numeros");
                txbTelFilial.Text = txbTelFilial.Text.Remove(txbTelFilial.Text.Length - 1);
            }
        }
    }
}
