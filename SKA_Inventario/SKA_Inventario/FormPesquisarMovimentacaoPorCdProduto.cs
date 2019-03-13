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
    public partial class FormPesquisarMovimentacaoPorCdProduto : Form
    {
        public FormPesquisarMovimentacaoPorCdProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("operação cancelada!");
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txbCDPrdt!= null && !string.IsNullOrWhiteSpace(txbCDPrdt.Text))
            {
                FormPrincipal.StaticGrid = ConManager.GetMovimentacaoCDProduto(FormPrincipal.StaticGrid, Int32.Parse(txbCDPrdt.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Insira um valor");
            }            
        }

        private void txbCDPrdt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbCDPrdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Favor digitar apenas numeros");
                txbCDPrdt.Text = txbCDPrdt.Text.Remove(txbCDPrdt.Text.Length - 1);
            }
        }
    }
}
