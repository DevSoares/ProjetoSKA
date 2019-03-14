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
        public static bool travaEx { get; set; }
        
        public FormPrincipal()
        {
            InitializeComponent();
        }


        //  A primeira aba a ser exibida é a de produtos, para o gridview mostrar os produtos é necessário
        //  buscar as informações no servidor, para isso e alterado a função OnLoad.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            travaEx = true;
            load_getProdutos();
            load_getFiliais();
            load_getMovimentacoes();

        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if (dataGVFilial.RowCount > 0)
            {
                FormCadPrdt formCadPrdt = new FormCadPrdt();
                formCadPrdt.Show();
                load_getProdutos();
                load_getMovimentacoes();
            }
            else
            {
                MessageBox.Show("É necessário cadastrar uma filial!");
            }
            
        }

  
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                    showFormEditarProduto(dataGVProdutos);
                    load_getProdutos();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }     
            travaEx = true;
        }

        private void btnCadFilial_Click(object sender, EventArgs e)
        {
            FormCadFilial formCadFilial = new FormCadFilial();
            formCadFilial.Show();
            load_getFiliais();
        }

        private void btnDelFilial_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                showFormDeletarFilial(dataGVFilial);
                load_getFiliais();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
            travaEx = true;
            
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                showFormEditarFilial(dataGVFilial);
                load_getFiliais();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
            travaEx = true;
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
            dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos").Tables[0]; 
        }
        //
        //  Atualiza apenas o gridView filiais
        public void load_getFiliais()
        {
            dataGVFilial.DataSource = ConManager.Consultar("SELECT * FROM Filiais").Tables[0];
        }

        public void load_getMovimentacoes()
        {
            gridViewMovimentacoes.DataSource = ConManager.Consultar("SELECT Movimentacoes.cd_movimentacao" +
                        ",Movimentacoes.cd_produto AS 'Código Produto'" +
                        ",Produtos.nome AS 'Produto'" +
                        ",Usuarios.usuario,Remetente.nome AS 'Filial Remetente'" +
                        ",Destinataria.nome AS 'Filial Destinataria'" +
                        ",Movimentacoes.dt_movimentacao " +
                        ",Produtos.disponivel " +
                        "FROM Movimentacoes " +
                        "INNER JOIN Produtos ON Movimentacoes.cd_produto = Produtos.cd_produto " +
                        "INNER JOIN Usuarios ON Movimentacoes.cd_usuario = Usuarios.cd_usuario " +
                        "LEFT JOIN Filiais Remetente ON Movimentacoes.cd_filial_remetente = Remetente.id " +
                        "LEFT JOIN Filiais Destinataria ON Movimentacoes.cd_filial_destinataria = Destinataria.id " +
                        "ORDER BY Movimentacoes.cd_movimentacao DESC").Tables[0];
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            StaticGrid.DataSource = ConManager.Consultar("SELECT * FROM Produtos").Tables[0];
            if (travaEx!=true)
            {
                showFormDeletarProduto(dataGVProdutos);
                load_getProdutos();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
            travaEx = true;
        }

        public void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                ShowFormMovimentar(gridViewMovimentacoes);
                load_getMovimentacoes();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
            travaEx = true;
            load_getMovimentacoes();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (travaEx!=true)
            {                
                gridViewMovimentacoes = ConManager.GetMovimentacaoProduto(gridViewMovimentacoes);

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
            travaEx = true;
            load_getMovimentacoes();
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

        private void btnPesqFil_Click(object sender, EventArgs e)
        {
            StaticGrid = gridViewMovimentacoes;
            ShowFormPesquisarMovimentacaoPorFilial();
            gridViewMovimentacoes = FormPrincipal.StaticGrid;
        }

        private void btnPesqData_Click(object sender, EventArgs e)
        {

        }
        /*
         * 
         *      Controle da travaEx
         * 
         */
        private void dataGVProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            travaEx = false;
        }
        private void dataGVFilial_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            travaEx = false;
        }
        private void gridViewMovimentacoes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            travaEx = false;
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

        public static void ShowFormPesquisarMovimentacaoPorFilial()
        {
            FormPesqMovimentacaoPorFilial formPesq = new FormPesqMovimentacaoPorFilial();
            formPesq.Show();
        }

        public void showFormEditarFilial(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            if (row.Cells["disponivel"].Value.Equals(true))
            {
                //atribuindo novo form e passando os dados da row selecionada
                FormEdtFilial formEdtFilial = new FormEdtFilial();
                formEdtFilial.setGridViewID(int.Parse(row.Cells["id"].Value.ToString()));
                formEdtFilial.setGridViewNome(row.Cells["nome"].Value.ToString());
                formEdtFilial.setGridViewCidade(row.Cells["cidade"].Value.ToString());
                formEdtFilial.setGridViewLogradouro(row.Cells["logradouro"].Value.ToString());
                formEdtFilial.setGridViewTelefone(row.Cells["telefone"].Value.ToString());
                formEdtFilial.Show();
            }
            else
            {
                MessageBox.Show("Filial Indisponível!");
            }
            load_getFiliais();
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
            formDeletarFilial.setDisponivel(row.Cells["disponivel"].Value.Equals(true));
            formDeletarFilial.Show();
            load_getFiliais();
   
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
            load_getProdutos();
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
