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
    public partial class FormDeletarPrdt : Form
    {
        private int gridViewID;
        private string gridViewNome;
        private string gridViewDataCadastro;
        private ConManager conManager = new ConManager();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setTextBoxes();
        }

        public FormDeletarPrdt()
        {
            InitializeComponent();
        }

        private void setTextBoxes()
        {
            txbNomePrdt.Text = getGridViewNome();
            txbCodPrdt.Text = getGridViewID().ToString();
            txbDataPrdt.Text = getGridViewDataCadastro();
        }

        //
        //  sets e gets das propriedades resgatadas do gridview
        //
        public void setGridViewID(int newID)
        {
            gridViewID = newID;
        }
        public int getGridViewID()
        {
            return gridViewID;
        }
        public void setGridViewNome(string newNome)
        {
            this.gridViewNome = newNome;
        }
        public string getGridViewNome()
        {
            return this.gridViewNome;
        }
        public void setGridViewDataCadastro(string newDataCadastro)
        {
            this.gridViewDataCadastro = newDataCadastro;
        }
        public string getGridViewDataCadastro()
        {
            return this.gridViewDataCadastro;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conManager.deletarProduto(gridViewID,gridViewNome);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Close();
        }
    }
}
