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
    public partial class FormPrincipal : Form
    {
        private ConManager conManager = new ConManager();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadPrdt formCadPrdt = new FormCadPrdt();
            formCadPrdt.Show();
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

        private void btnDelFilial_Click(object sender, EventArgs e)
        {
            conManager.showFormDeletarFilial(dataGVFilial);                       
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            conManager.showFormEditarFilial(dataGVFilial);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            dataGVFilial = conManager.getFiliais(dataGVFilial);        
        }
    }
}
