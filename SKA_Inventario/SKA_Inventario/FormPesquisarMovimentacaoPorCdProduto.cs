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
        public static DataGridView gridView { get; set; }

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
            FormPrincipal.StaticGrid =  ConManager.GetMovimentacaoCDProduto(gridView, Int32.Parse(txbCDPrdt.Text));
            this.Close();
        }
    }
}
