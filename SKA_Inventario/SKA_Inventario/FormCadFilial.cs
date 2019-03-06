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
        private ConManager conManager = new ConManager();

        public FormCadFilial()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            conManager.CadastrarFilial(txbNomeFilial.Text, txbCidadeFilial.Text, txbLogFilial.Text, txbTelFilial.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }
    }
}
