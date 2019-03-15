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
    public partial class FormCadPrdt : Form
    {
        private ConManager conManager = new ConManager();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setComboBox();
        }

        public FormCadPrdt()
        {
            InitializeComponent();
        }

        private void setComboBox()
        {
            cb_Filial.DataSource = ConManager.Consultar("SELECT nome FROM Filiais").Tables[0];
            cb_Filial.DisplayMember = "nome";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConManager.CadastrarProduto(txbNomePrdt.Text);                     
            ConManager.MovimentarProduto(ConManager.GetLastProduto(), ConManager.GetCD_FilialPorNomeFilial(cb_Filial.Text), ConManager.GetCD_FilialPorNomeFilial(cb_Filial.Text));
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Close();
        }             
    }
}
