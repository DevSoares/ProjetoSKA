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
    public partial class FormEdtFilial : Form
    {
        private int gridViewID;
        private string gridViewNome;
        private string gridViewCidade;
        private string gridViewLogradouro;
        private string gridViewTelefone;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setTextBoxes();
        }

        public FormEdtFilial()
        {
            InitializeComponent();
        }

        private void setTextBoxes() {
            txbNomeFilial.Text = getGridViewNome();
            txbIDFilial.Text = getGridViewID().ToString();
            txbCidadeFilial.Text = getGridViewCidade();
            txbLogradouroFilial.Text = getGridViewLogradouro();
            txbTelefoneFilial.Text = getGridViewTelefone();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbNomeFilial.Text)&&!string.IsNullOrWhiteSpace(txbCidadeFilial.Text)&&!string.IsNullOrWhiteSpace(txbLogradouroFilial.Text)&&!string.IsNullOrWhiteSpace(txbTelefoneFilial.Text))
            {
                ConManager.EditarFilial(this.getGridViewID(), txbNomeFilial.Text, txbCidadeFilial.Text, txbLogradouroFilial.Text, txbTelefoneFilial.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos acima!");
            }
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
        public void setGridViewCidade(string newCidade)
        {
            this.gridViewCidade = newCidade;
        }
        public string getGridViewCidade()
        {
            return this.gridViewCidade;
        }
        public void setGridViewLogradouro(string newLogradouro)
        {
            this.gridViewLogradouro = newLogradouro;
        }
        public string getGridViewLogradouro()
        {
            return this.gridViewLogradouro;
        }
        public void setGridViewTelefone(string newTelefone)
        {
            this.gridViewTelefone = newTelefone;
        }
        public string getGridViewTelefone()
        {
            return this.gridViewTelefone;
        }

        private void txbTelefoneFilial_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbTelefoneFilial.Text, "[^0-9]"))
            {
                MessageBox.Show("Favor digitar apenas numeros");
                txbTelefoneFilial.Text = txbTelefoneFilial.Text.Remove(txbTelefoneFilial.Text.Length - 1);
            }
        }
    }
}
