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

        //
        //  função para atualizar o GridView da tela Filiais
        //
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

        //
        //  Função para atualizar o gridView na tela de produtos
        //
        public DataGridView getProdutos(DataGridView gridView)
        {
            try
            {
                this.connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();

                    //definindo sqlcommand
                    string cmdQuery = "SELECT * FROM Produtos";
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

        //
        // Mostrar o formulário de editar filial
        //
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
        //  Função para editar a filial selecionada na tela de filiais
        //
        public void EditarFilial(int edt_id, string edt_nome, string edt_cidade, string edt_logradouro, string edt_telefone)
        {
            //  pegando o index da linha selecionada no datagridview
            string msgEdtConf = "Filial editada!!\n Nome: " + edt_nome + "\n ID: " + edt_id.ToString() ;
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o parametro de exclusão
                    SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
                    paramID.Value = edt_id;
                    SqlParameter paramNome = new SqlParameter("@ParamNome", SqlDbType.NVarChar, 50);
                    paramNome.Value =  edt_nome;
                    SqlParameter paramCidade = new SqlParameter("@ParamCidade", SqlDbType.NVarChar, 50);
                    paramCidade.Value = edt_cidade;
                    SqlParameter paramLogradouro = new SqlParameter("@ParamLogradouro", SqlDbType.NVarChar, 50);
                    paramLogradouro.Value = edt_logradouro;
                    SqlParameter paramTelefone = new SqlParameter("@ParamTelefone", SqlDbType.NVarChar, 50);
                    paramTelefone.Value = edt_telefone;

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
                    MessageBox.Show(msgEdtConf);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        // Função para deletar a filial selecionada no gridView
        //
        public void DeletarFilial(int del_id, string del_nome)
        {
            string msgDelConf = "Filial excluída!!\n Nome: " + del_nome + "\n ID: " + del_id.ToString();
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o parametro de exclusão
                    SqlParameter paramID = new SqlParameter("@paramID", SqlDbType.Int);
                    paramID.Value = del_id;

                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando o parametro
                    command.Parameters.Add(paramID);
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Filiais WHERE id=@paramID";
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

        //
        // Função para cadastrar filial
        //
        public void CadastrarFilial(string cad_nome, string cad_cidade, string cad_logradouro, string cad_telefone)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão com o servidor sql
                    connection.Open();

                    //  definindo parametros do SqlCommand
                    SqlCommand sqlCommand = new SqlCommand();
                    SqlParameter paramNome = new SqlParameter("@paramNome", SqlDbType.NVarChar, 50);
                    paramNome.Value = cad_nome;
                    SqlParameter paramCidade = new SqlParameter("@paramCidade", SqlDbType.NVarChar, 50);
                    paramCidade.Value = cad_cidade;
                    SqlParameter paramLogradouro = new SqlParameter("@paramLogradouro", SqlDbType.NVarChar, 50);
                    paramLogradouro.Value = cad_logradouro;
                    SqlParameter paramTelefone = new SqlParameter("@paramTelefone", SqlDbType.NVarChar, 50);
                    paramTelefone.Value = cad_telefone;
                    //  Adicionando os parametros
                    sqlCommand.Parameters.Add(paramNome);
                    sqlCommand.Parameters.Add(paramCidade);
                    sqlCommand.Parameters.Add(paramLogradouro);
                    sqlCommand.Parameters.Add(paramTelefone);
                    //  Definindo atributos do SqlCommand
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO Filiais (nome, cidade, logradouro, telefone) VALUES (@paramNome, @paramCidade, @paramLogradouro, @paramTelefone);";
                    sqlCommand.CommandType = CommandType.Text;
                    //  Executando o SqlCommand
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Filial cadastrada!!");
                    //  Fechando a conexão
                    connection.Close();
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
        }

        //
        // Função para cadastrar o produto
        //
        public void CadastrarProduto(string cad_nome)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão com o servidor sql
                    connection.Open();

                    //  definindo parametros do SqlCommand
                    SqlCommand sqlCommand = new SqlCommand();
                    SqlParameter paramNome = new SqlParameter("@paramNome", SqlDbType.NVarChar, 50);
                    paramNome.Value = cad_nome;
                    
                    //  Adicionando os parametros
                    sqlCommand.Parameters.Add(paramNome);                    
                    //  Definindo atributos do SqlCommand
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO Produtos (nome) VALUES (@paramNome);";
                    sqlCommand.CommandType = CommandType.Text;
                    //  Executando o SqlCommand
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado!!");
                    //  Fechando a conexão
                    connection.Close();
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
        }

        //
        //  Função para editar o produto
        //
        public void editarProduto(int cod_prdt, string nome)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão com o servidor sql
                    connection.Open();

                    //  definindo parametros do SqlCommand
                    SqlCommand sqlCommand = new SqlCommand();
                    SqlParameter paramNome = new SqlParameter("@paramNome", SqlDbType.NVarChar, 50);
                    paramNome.Value = nome;
                    SqlParameter paramID = new SqlParameter("@paramID", SqlDbType.Int);
                    paramID.Value = cod_prdt;

                    //  Adicionando os parametros
                    sqlCommand.Parameters.Add(paramNome);
                    sqlCommand.Parameters.Add(paramID);
                    //  Definindo atributos do SqlCommand
                    sqlCommand.Connection = connection;                    
                    sqlCommand.CommandText = "UPDATE Produtos SET nome=@paramNome WHERE cd_produto=@paramID";
                    sqlCommand.CommandType = CommandType.Text;
                    //  Executando o SqlCommand
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Produto Editado!\n Código Produto: "+cod_prdt+"\n Nome: "+nome);
                    //  Fechando a conexão
                    connection.Close();
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
        }

        //
        //  Mostrar o formulário de editar produto
        //
        public void showFormEditarProduto(DataGridView gridView)
        {
            //  pegando o index da linha selecionada no datagridview
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            //atribuindo novo form e passando os dados da row selecionada
            FormEdtPrdt formEdtPrdt = new FormEdtPrdt();
            formEdtPrdt.setGridViewID(int.Parse(row.Cells["cd_produto"].Value.ToString()));
            formEdtPrdt.setGridViewNome(row.Cells["nome"].Value.ToString());
            formEdtPrdt.setGridViewDataCadastro(row.Cells["dt_criacao"].Value.ToString());
            formEdtPrdt.Show();
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
            formDeletarPrdt.Show();
        }

        //
        // Função para deletar o produto selecionado no gridView
        //
        public void deletarProduto(int del_id, string del_nome)
        {
            string msgDelConf = "Produto excluído!!\n Nome: " + del_nome + "\n ID: " + del_id.ToString();
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o parametro de exclusão
                    SqlParameter paramID = new SqlParameter("@paramID", SqlDbType.Int);
                    paramID.Value = del_id;

                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando o parametro
                    command.Parameters.Add(paramID);
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Produtos WHERE cd_produto=@paramID";
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
    }
}
