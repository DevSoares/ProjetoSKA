using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKA_Inventario
{
    class ConManager
    {
        private string connString;        

        //  função para atualizar o GridView de Filiais
        public DataGridView getFiliais(DataGridView gridView)
        {
            try
            {
                this.connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();

                    //definindo sqlcommand
                    string cmdQuery = "SELECT * FROM Filiais";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // definindo gridview como read-only
                    gridView.ReadOnly = true;
                    // preenchendo o gridview com o dataset
                    gridView.DataSource = dataSet.Tables[0];
                    connection.Close();
                    return gridView;
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return gridView;
            }
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

        //  em construção
        public void EditarFilial(DataGridView gridView, FormEdtFilial formEdtFilial)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            string msgDelConf = "Filial editada!!\n Nome: " + txbNomeFilial.Text + "\n ID: " + getGridViewID().ToString();
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o parametro de exclusão
                    SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
                    paramID.Value = row.Cells["id"].Value;
                    SqlParameter paramNome = new SqlParameter("@ParamNome", SqlDbType.NVarChar, 50);
                    paramNome.Value =  txbNomeFilial.Text;
                    SqlParameter paramCidade = new SqlParameter("@ParamCidade", SqlDbType.NVarChar, 50);
                    paramCidade.Value = txbCidadeFilial.Text;
                    SqlParameter paramLogradouro = new SqlParameter("@ParamLogradouro", SqlDbType.NVarChar, 50);
                    paramLogradouro.Value = txbLogradouroFilial.Text;
                    SqlParameter paramTelefone = new SqlParameter("@ParamTelefone", SqlDbType.NVarChar, 50);
                    paramTelefone.Value = txbTelefoneFilial.Text;

                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando parametros
                    command.Parameters.Add(paramID);
                    command.Parameters.Add(paramNome);
                    command.Parameters.Add(paramCidade);
                    command.Parameters.Add(paramLogradouro);
                    command.Parameters.Add(paramTelefone);

                    command.Connection = connection;
                    command.CommandText = "UPDATE Filiais SET nome=@ParamNome, cidade=@ParamCidade, logradouro=@ParamLogradouro, telefone=@ParamTelefone WHERE id=@paramID";
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                    MessageBox.Show(msgDelConf);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
    }
}
