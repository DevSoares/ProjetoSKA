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
        public FormPrincipal()
        {
            InitializeComponent();
            pnlBtnFilial.Hide();
            pnlBtnProdutos.Show();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            
            pnlBtnProdutos.Hide();
            pnlBtnFilial.Visible = true;
            pnlBtnFilial.Show();

            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();

                    //definindo sqlcommand
                    string cmdQuery = "SELECT * FROM Filiais";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);
                    //  definindo dataAdapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // definindo gridview como read-only
                    dataGVFilial.ReadOnly = true;
                    // preenchendo o gridview com o dataset
                    dataGVFilial.DataSource = dataSet.Tables[0];

                    //  habilitando a seleção de row do gridview
                    
                

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadPrdt formCadPrdt = new FormCadPrdt();
            formCadPrdt.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlBtnFilial.Hide();
            pnlBtnProdutos.Show();
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

            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = this.dataGVFilial.Rows[dataGVFilial.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormDeletarFilial formDeletarFilial = new FormDeletarFilial();
            formDeletarFilial.setGridViewID(int.Parse(row.Cells["id"].Value.ToString()));
            formDeletarFilial.setGridViewNome(row.Cells["nome"].Value.ToString());
            formDeletarFilial.setGridViewCidade(row.Cells["cidade"].Value.ToString());
            formDeletarFilial.setGridViewLogradouro(row.Cells["logradouro"].Value.ToString());
            formDeletarFilial.setGridViewTelefone(row.Cells["telefone"].Value.ToString());
            formDeletarFilial.Show();
                       
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = this.dataGVFilial.Rows[dataGVFilial.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormEdtFilial formEdtFilial = new FormEdtFilial();
            formEdtFilial.setGridViewID(int.Parse(row.Cells["id"].Value.ToString()));
            formEdtFilial.setGridViewNome(row.Cells["nome"].Value.ToString());
            formEdtFilial.setGridViewCidade(row.Cells["cidade"].Value.ToString());
            formEdtFilial.setGridViewLogradouro(row.Cells["logradouro"].Value.ToString());
            formEdtFilial.setGridViewTelefone(row.Cells["telefone"].Value.ToString());
            formEdtFilial.Show();
        }
    }
}
