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
        public static DataGridView StaticGrid { get; set; }

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
            showFormEditarProduto(dataGVProdutos);
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
            showFormDeletarFilial(dataGVFilial);
            load_getFiliais();
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            showFormEditarFilial(dataGVFilial);
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
            dataGVProdutos = ConManager.GetProdutosGridView(dataGVProdutos); 
        }
        //
        //  Atualiza apenas o gridView filiais
        public void load_getFiliais()
        {
            dataGVFilial = ConManager.GetFiliaisGridView(dataGVFilial);
        }

        public void load_getMovimentacoes()
        {
            gridViewMovimentacoes = ConManager.GetMovimentacoes(gridViewMovimentacoes);
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            showFormDeletarProduto(dataGVProdutos);
            this.load_getProdutos();
        }

        public void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            ShowFormMovimentar(gridViewMovimentacoes);
            this.load_getMovimentacoes();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ConManager.GetMovimentacaoProduto(gridViewMovimentacoes);
        }

        private void btnListarMovimentacoes_Click(object sender, EventArgs e)
        {
            this.load_getMovimentacoes();
        }

        private void btnPesCodPrdt_Click(object sender, EventArgs e)
        {
            StaticGrid = gridViewMovimentacoes;
            ShowFormPesquisarMovimentacaoPorCdProduto();
            gridViewMovimentacoes = FormPrincipal.StaticGrid;
        }

        /*
         * 
         * 
         *      SEÇÃO SHOW FORMS
         * 
         * 
         */
        public static void ShowFormPesquisarMovimentacaoPorCdProduto()
        {
            FormPesquisarMovimentacaoPorCdProduto formPesquisar = new FormPesquisarMovimentacaoPorCdProduto();
            formPesquisar.Show();
        }

        public void showFormEditarFilial(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormEdtFilial formEdtFilial = new FormEdtFilial();
            formEdtFilial.setGridViewID(int.Parse(row.Cells["id"].Value.ToString()));
            formEdtFilial.setGridViewNome(row.Cells["nome"].Value.ToString());
            formEdtFilial.setGridViewCidade(row.Cells["cidade"].Value.ToString());
            formEdtFilial.setGridViewLogradouro(row.Cells["logradouro"].Value.ToString());
            formEdtFilial.setGridViewTelefone(row.Cells["telefone"].Value.ToString());
            formEdtFilial.Show();
        }
        //
        // Mostar o formulário Deletar Filial
        //
        public void showFormDeletarFilial(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormDeletarFilial formDeletarFilial = new FormDeletarFilial();
            formDeletarFilial.setGridViewID(int.Parse(row.Cells["id"].Value.ToString()));
            formDeletarFilial.setGridViewNome(row.Cells["nome"].Value.ToString());
            formDeletarFilial.setGridViewCidade(row.Cells["cidade"].Value.ToString());
            formDeletarFilial.setGridViewLogradouro(row.Cells["logradouro"].Value.ToString());
            formDeletarFilial.setGridViewTelefone(row.Cells["telefone"].Value.ToString());
            formDeletarFilial.Show();
        }
        //
        //  Mostrar o formulário de editar produto
        //
        public void showFormEditarProduto(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            if (row.Cells["disponivel"].Value.Equals(true))
            {
                //atribuindo novo form e passando os dados da row selecionada
                FormEdtPrdt formEdtPrdt = new FormEdtPrdt();
                formEdtPrdt.setGridViewID(int.Parse(row.Cells["cd_produto"].Value.ToString()));
                formEdtPrdt.setGridViewNome(row.Cells["nome"].Value.ToString());
                formEdtPrdt.setGridViewDataCadastro(row.Cells["dt_criacao"].Value.ToString());
                formEdtPrdt.Show();
            }
            else
            {
                MessageBox.Show("Produto Indisponível!");
            }
        }
        //
        //  Mostrar o formulário de Deletar produto
        //
        public void showFormDeletarProduto(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormDeletarPrdt formDeletarPrdt = new FormDeletarPrdt();
            formDeletarPrdt.setGridViewID(int.Parse(row.Cells["cd_produto"].Value.ToString()));
            formDeletarPrdt.setGridViewNome(row.Cells["nome"].Value.ToString());
            formDeletarPrdt.setGridViewDataCadastro(row.Cells["dt_criacao"].Value.ToString());
            formDeletarPrdt.setDisponivel(row.Cells["disponivel"].Value.Equals(true));
            formDeletarPrdt.Show();
        }
        public static void ShowFormMovimentar(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            if (row.Cells["disponivel"].Value.Equals(true))
            {
                FormMovimentar formMovimentar = new FormMovimentar();
                formMovimentar.Cd_produto = ConManager.GetCD_ProdutoPorCD_Movimentacao(int.Parse(row.Cells["cd_movimentacao"].Value.ToString()));
                formMovimentar.Nome_produto = (row.Cells["Produto"].Value.ToString());
                formMovimentar.Filial_Remetente = row.Cells["Filial Destinataria"].Value.ToString();
                formMovimentar.Show();
            }
            else
            {
                MessageBox.Show("Produto Indisponível!");
            }
        }
    }
}
