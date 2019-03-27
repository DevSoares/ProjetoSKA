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
        public static bool run_load { get; set; }
        private int controle_btn_ordem_prdt = 0;
        private int controle_btn_ordem_mov = 0;

        
        
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
            run_load = false;
            load_cb_prdt_filiais();
            load_getProdutos();
            load_getFiliais();
            load_getMovimentacoes();
            cb_prdt_filial.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            if (dataGVFilial.RowCount > 0)
            {
                FormCadPrdt formCadPrdt = new FormCadPrdt();
                formCadPrdt.Show();
                formCadPrdt.FormClosed += FormCadPrdt_FormClosed;
            }
            else
            {
                MessageBox.Show("É necessário cadastrar uma filial!");
            }
            
        }

        private void FormCadPrdt_FormClosed(object sender, FormClosedEventArgs e)
        {
            load_getProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                    showFormEditarProduto(dataGVProdutos);
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
            formCadFilial.FormClosed += FormCadFilial_FormClosed;
        }

        private void FormCadFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
            load_getFiliais();
        }

        private void btnDelFilial_Click(object sender, EventArgs e)
        {
            if (travaEx != true)
            {
                DataGridViewRow row = dataGVFilial.Rows[dataGVFilial.CurrentRow.Index];
                DataSet table = ConManager.Consultar("SELECT *  FROM Movimentacoes "+
                        "INNER JOIN Produtos ON Movimentacoes.cd_produto = Produtos.cd_produto "+
                        "WHERE cd_movimentacao IN(SELECT MAX(cd_movimentacao) FROM Movimentacoes GROUP BY cd_produto) "+
                        "AND cd_filial_destinataria = @valor AND Produtos.disponivel = 1", "@valor", int.Parse(row.Cells["id"].Value.ToString()));
                if (table.Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("A filial selecionado possui produtos vinculados!" +
                    "\nPor favor movimente os produtos para outras filiais e tente novamente.");
                }
                else
                {
                    showFormDeletarFilial(dataGVFilial);
                }        
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
            dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos ORDER BY Produtos.cd_produto DESC").Tables[0]; 
        }
        //
        //  Atualiza apenas o gridView filiais
        public void load_getFiliais()
        {
            dataGVFilial.DataSource = ConManager.Consultar("SELECT * FROM Filiais").Tables[0];
        }
        //
        //  Atualiza apenas o combo box de filiais na tela de produtos
        public void load_cb_prdt_filiais()
        {
            cb_prdt_filial.DataSource = ConManager.Consultar("SELECT nome FROM Filiais").Tables[0];
            cb_prdt_filial.DisplayMember = "nome";
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
            if (travaEx!=true)
            {
                StaticGrid = dataGVProdutos;
                showFormDeletarProduto(dataGVProdutos);                
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
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
            travaEx = true;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (travaEx!=true)
            {
                DataGridViewRow row = gridViewMovimentacoes.Rows[gridViewMovimentacoes.CurrentRow.Index];
                int cd_produto = int.Parse(row.Cells["Código Produto"].Value.ToString());
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
                        "WHERE Movimentacoes.cd_produto = @pCDproduto " +
                        "ORDER BY Movimentacoes.cd_movimentacao DESC", "@pCDproduto", cd_produto).Tables[0]; 
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
                load_getMovimentacoes();
            }
            travaEx = true;            
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

        private void btn_ordem_Click(object sender, EventArgs e)
        {
            DataGridViewColumn cd_produto = dataGVProdutos.Columns[0];
            DataGridViewColumn nome_produto = dataGVProdutos.Columns[1];
            controle_btn_ordem_prdt = controle_btn_ordem_prdt + 1;
            if (controle_btn_ordem_prdt >= 4)
            {
                controle_btn_ordem_prdt = 0;
            }
            switch (controle_btn_ordem_prdt)
            {
                case 0:
                    dataGVProdutos.Sort(cd_produto, ListSortDirection.Descending);
                    btn_ordem.Text = "Data +";
                    break;
                case 1:
                    dataGVProdutos.Sort(nome_produto, ListSortDirection.Ascending);
                    btn_ordem.Text = "Az";
                    break;
                case 2:
                    dataGVProdutos.Sort(nome_produto, ListSortDirection.Descending);
                    btn_ordem.Text = "Za";
                    break;
                case 3:
                    dataGVProdutos.Sort(cd_produto, ListSortDirection.Ascending);
                    btn_ordem.Text = "Data -";
                    break;
            }
        }

        private void btn_ordem_mov_Click(object sender, EventArgs e)
        {
            DataGridViewColumn cd_produto = gridViewMovimentacoes.Columns[0];
            DataGridViewColumn nome_produto = gridViewMovimentacoes.Columns[1];
            controle_btn_ordem_mov = controle_btn_ordem_mov + 1;
            if (controle_btn_ordem_mov >= 4)
            {
                controle_btn_ordem_mov = 0;
            }
            switch (controle_btn_ordem_mov)
            {
                case 0:
                    gridViewMovimentacoes.Sort(cd_produto, ListSortDirection.Descending);
                    btn_ordem_mov.Text = "Data +";
                    break;
                case 1:
                    gridViewMovimentacoes.Sort(nome_produto, ListSortDirection.Ascending);
                    btn_ordem_mov.Text = "Az";
                    break;
                case 2:
                    gridViewMovimentacoes.Sort(nome_produto, ListSortDirection.Descending);
                    btn_ordem_mov.Text = "Za";
                    break;
                case 3:
                    gridViewMovimentacoes.Sort(cd_produto, ListSortDirection.Ascending);
                    btn_ordem_mov.Text = "Data -";
                    break;
            }
        }

        private void btn_pesq_prdt_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(txbPesq.Text) || string.IsNullOrWhiteSpace(txbPesq.Text)) 
            {
                dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos ORDER BY cd_produto DESC").Tables[0];
            }
            else
            {
                dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos WHERE nome LIKE '%'+@nome+'%'", "@nome", txbPesq.Text).Tables[0];
            }
        }

        private void txbPesq_Click(object sender, EventArgs e)
        {
            txbPesq.Text = "";
        }

        private void btn_pesq_prdt_cd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txb_CD_prdt.Text)|| string.IsNullOrWhiteSpace(txb_CD_prdt.Text))
            {
                dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos ORDER BY cd_produto DESC").Tables[0];
            }
            else
            {
                dataGVProdutos.DataSource = ConManager.Consultar("SELECT * FROM Produtos WHERE cd_produto=@cd_produto", "@cd_produto", Int32.Parse(txb_CD_prdt.Text)).Tables[0];
            }
        }

        private void txb_CD_prdt_Click(object sender, EventArgs e)
        {
            txb_CD_prdt.Text = "";
        }

        private void btn_pesq_prdt_filial_Click(object sender, EventArgs e)
        {
            dataGVProdutos.DataSource = ConManager.Consultar("SELECT Movimentacoes.cd_produto " +
                ", Produtos.nome , Produtos.dt_criacao, Movimentacoes.cd_filial_destinataria AS 'Código da Filial' " +
                ",Filiais.nome AS 'Nome da Filial' " +
                ", Produtos.disponivel FROM Movimentacoes " +
                "LEFT JOIN Produtos ON Produtos.cd_produto = Movimentacoes.cd_produto " +
                "LEFT JOIN Filiais ON Filiais.id = Movimentacoes.cd_filial_destinataria "+
                "WHERE cd_movimentacao IN (SELECT MAX(cd_movimentacao) FROM Movimentacoes GROUP BY	cd_produto) " +
                "AND cd_filial_destinataria=@parametro " +
                "ORDER BY Produtos.cd_produto DESC", "@parametro", ConManager.GetCD_FilialPorNomeFilial(cb_prdt_filial.Text)).Tables[0];
        }


        private void txb_CD_prdt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_CD_prdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Favor digitar apenas numeros");
                txb_CD_prdt.Text = txb_CD_prdt.Text.Remove(txb_CD_prdt.Text.Length - 1);
            }
        }

        private void btnPesqData_Click(object sender, EventArgs e)
        {
            StaticGrid = gridViewMovimentacoes;
            ShowFormPesqMovimentacaoPorData();
            gridViewMovimentacoes = StaticGrid;
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
                formEdtFilial.FormClosed += FormEdtFilial_FormClosed;
            }
            else
            {
                MessageBox.Show("Filial Indisponível!");
            }
        }

        private void FormEdtFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            formDeletarFilial.FormClosed += FormDeletarFilial_FormClosed;
   
        }

        private void FormDeletarFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                formEdtPrdt.FormClosed += FormEdtPrdt_FormClosed;
            }
            else
            {
                MessageBox.Show("Produto Indisponível!");
            }
            load_getProdutos();
        }

        private void FormEdtPrdt_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            formDeletarPrdt.FormClosed += FormDeletarPrdt_FormClosed;
        }

        private void FormDeletarPrdt_FormClosed(object sender, FormClosedEventArgs e)
        {
            load_getProdutos();
        }

        public void ShowFormMovimentar(DataGridView gridView)
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
                formMovimentar.FormClosed += FormMovimentar_FormClosed;
            }
            else
            {
                MessageBox.Show("Produto Indisponível!");
            }
        }        

        private void FormMovimentar_FormClosed(object sender, FormClosedEventArgs e)
        {
            load_getMovimentacoes();
        }

        public static void ShowFormPesqMovimentacaoPorData()
        {
            FormPesqMovimentacaoPorData formPesq = new FormPesqMovimentacaoPorData();
            formPesq.Show();
        }
    }
}
