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
    public partial class FormMovimentar : Form
    {
        public int Cd_produto { get; set; }
        public string Nome_produto { get; set; }
        public string Filial_Remetente { get; set; }

        public FormMovimentar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setTextBoxes();
        }

        public void setTextBoxes()
        {
            txbCdPrdt.Text = Cd_produto.ToString();
            txbNomePrdt.Text = Nome_produto;
            txbRemetente.Text = Filial_Remetente;
            cbDestinataria.DataSource = ConManager.Consultar("SELECT nome FROM Filiais WHERE disponivel = 1 AND nome !=@nome ", "@nome", Filial_Remetente).Tables[0];
            cbDestinataria.DisplayMember = "nome";
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            ConManager.MovimentarProduto(Cd_produto,ConManager.GetCD_FilialPorNomeFilial(Filial_Remetente), ConManager.GetCD_FilialPorNomeFilial(cbDestinataria.Text));
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Close();
        }
    }
}
