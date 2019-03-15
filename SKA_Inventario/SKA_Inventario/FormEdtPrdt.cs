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
    public partial class FormEdtPrdt : Form
    {
        private int gridViewID;
        private string gridViewNome;
        private string gridViewDataCadastro;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setTextBoxes();
        }

        public FormEdtPrdt()
        {
            InitializeComponent();
        }

        private void setTextBoxes()
        {
            txbNomePrdt.Text = getGridViewNome();
            txbCodPrdt.Text = getGridViewID().ToString();
            txbDataPrdt.Text = getGridViewDataCadastro();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConManager.EditarProduto(gridViewID, txbNomePrdt.Text);
            this.Close();
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
    }
}

