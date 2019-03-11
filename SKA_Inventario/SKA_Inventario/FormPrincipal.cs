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


        //  A primeira aba a ser exibida é a de produtos, para o gridview mostrar os produtos é necessário
        //  buscar as informações no servidor, para isso e alterado a função OnLoad.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);            
            load_getProdutos();
            load_getFiliais();
            load_getMovimentacoes();

        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadPrdt formCadPrdt = new FormCadPrdt();
            formCadPrdt.Show();
            load_getProdutos();
            load_getMovimentacoes();
        }

  
        private void btnEditar_Click(object sender, EventArgs e)
        {            
            conManager.showFormEditarProduto(dataGVProdutos);
            load_getProdutos();
        }

        private void btnCadFilial_Click(object sender, EventArgs e)
        {
            FormCadFilial formCadFilial = new FormCadFilial();
            formCadFilial.Show();
            load_getFiliais();
        }

        private void btnDelFilial_Click(object sender, EventArgs e)
        {
            conManager.showFormDeletarFilial(dataGVFilial);
            load_getFiliais();
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            conManager.showFormEditarFilial(dataGVFilial);
            load_getFiliais();
        }

        //
        //  Atualiza o gridView no formulário principal quando uma aba é selecionada
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            load_getFiliais();
            load_getProdutos();
            load_getMovimentacoes();
        }

        //
        //  Atualiza apenas o gridView produtos
        public void load_getProdutos()
        {
            dataGVProdutos = conManager.getProdutos(dataGVProdutos);
        }
        //
        //  Atualiza apenas o gridView filiais
        public void load_getFiliais()
        {
            dataGVFilial = conManager.getFiliais(dataGVFilial);
        }

        public void load_getMovimentacoes()
        {
            gridViewMovimentacoes = ConManager.GetMovimentacoes(gridViewMovimentacoes);
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            conManager.showFormDeletarProduto(dataGVProdutos);
            this.load_getProdutos();
        }

        public void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
