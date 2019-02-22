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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            pnlBtnProdutos.Hide();
            

//            FormFiliais f2 = new FormFiliais();
  //          f2.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadPrdt formCadPrdt = new FormCadPrdt();
            formCadPrdt.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlBtnProdutos.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEdtPrdt formEdtPrdt = new FormEdtPrdt();
            formEdtPrdt.Show();
        }
    }
}
