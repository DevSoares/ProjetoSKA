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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            pnlBtnFilial.Hide();
            pnlBtnProdutos.Show();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            pnlBtnProdutos.Hide();
            pnlBtnFilial.Visible = true;
            pnlBtnFilial.Show();

        //    Application.DoEvents();

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
            pnlBtnFilial.Hide();
            pnlBtnProdutos.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEdtPrdt formEdtPrdt = new FormEdtPrdt();
            formEdtPrdt.Show();
        }

        private void btnCadFilial_Click(object sender, EventArgs e)
        {
            FormCadFilial formCadFilial = new FormCadFilial();
            formCadFilial.Show();
        }
    }
}
