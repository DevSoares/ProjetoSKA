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
            setGridView(conManager.GetGridViewFiliais(dataGridViewFilial));
        }

        public FormCadPrdt()
        {
            InitializeComponent();
        }

        private void setGridView(DataGridView gridView)
        {
            this.dataGridViewFilial = gridView;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            conManager.CadastrarProduto(txbNomePrdt.Text);

            DataGridViewRow row = dataGridViewFilial.Rows[dataGridViewFilial.CurrentRow.Index];
            int cd_produto = ConManager.GetLastProduto();
            int cd_filial = int.Parse(row.Cells["id"].Value.ToString());
            int cd_usuario = FormLogin.get_cd_usuario();
            ConManager.CadPrdtMovimentar(cd_produto, cd_filial, cd_usuario);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Close();
        }             
    }
}
