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
        public static string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";

        //
        //  Função para criptografar a senha
        //
        public static string HashSHA1(string valor)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(valor);
            var hash = sha1.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        //
        //  Função para retornar o cod_usuario validando login e senha
        //
        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            // valor padrão para retorno da função
            int userId = 0;

            SqlConnection con = new SqlConnection("Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;");
            using (SqlCommand cmd = new SqlCommand("SELECT cod_usuario, senha, guid_usuario FROM Usuarios WHERE usuario=@username", con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // dr.Read() = we found user(s) with matching username!
                    int dbUserId = Convert.ToInt32(dr["cod_usuario"]);
                    string dbPassword = Convert.ToString(dr["senha"]);
                    string dbUserGuid = Convert.ToString(dr["guid_usuario"]);
                    // dr.read() pega a senha cadastrada no DB e transforma para string
                    // o guid_usuario é recuperado do DB e atribuido como string em dbUserGuid
                    // agora a senha fornecida pelo usuario é concatenada com a guid recuperada do servidor
                    //então é efetuado a criptografia
                    string hashedPassword = HashSHA1(password + dbUserGuid);
                    // agora a senha recem criptografada é comparada com a senha criptografada no DB
                    if (dbPassword == hashedPassword)
                    {                        
                        userId = dbUserId;
                    }
                }
                con.Close();
            }
            // Retorno da função com o cod_usuario que está logado
            return userId;
        }

        //
        //  função para atualizar o GridView da tela Filiais
        //
        public static DataGridView GetFiliaisGridView(DataGridView gridView)
        {
            try
            {
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
        public static DataGridView GetProdutosGridView(DataGridView gridView)
        {
            try
            {
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
        //  Função para atualizar as opções de checkbox de filiais
        //
        public static ComboBox GetFiliaisCheckBox(ComboBox comboBox)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();

                    //definindo sqlcommand
                    string cmdQuery = "SELECT nome FROM Filiais";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // preenchendo o gridview com o dataset
                    comboBox.DataSource = dataSet.Tables[0];
                    comboBox.DisplayMember = "nome";
                    connection.Close();
                    return comboBox;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return comboBox;
            }
        }
        //
        //  Função para editar a filial selecionada na tela de filiais
        //
        public static void EditarFilial(int edt_id, string edt_nome, string edt_cidade, string edt_logradouro, string edt_telefone)
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
        // Função para deletar a filial selecionada no gridView
        //
        public static void DeletarFilial(int del_id, string del_nome)
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
        public static void CadastrarFilial(string cad_nome, string cad_cidade, string cad_logradouro, string cad_telefone)
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
        public static void CadastrarProduto(string cad_nome)
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
                    sqlCommand.Parameters.AddWithValue("@paramDisponivel", 1);
                    //  Definindo atributos do SqlCommand
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO Produtos (nome, disponivel) VALUES (@paramNome, @paramDisponivel);";
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
        public static void EditarProduto(int cod_prdt, string nome)
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
        // Função para deletar o produto selecionado no gridView
        //
        public static void DeletarProduto(int del_id, string del_nome, int disp)
        {
            string msgDelConf = "Status do Produto Alterado!!\n Nome: " + del_nome + "\n ID: " + del_id.ToString();
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
                    command.Parameters.AddWithValue("@paDisponivel", disp);
                    command.Parameters.Add(paramID);
                    command.Connection = connection;
                    command.CommandText = "UPDATE Produtos SET disponivel = @paDisponivel WHERE cd_produto=@paramID";
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

        public static int GetLastProduto()
        {
            int last_produto = 0;           
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {    
                    //  abrindo a conexão
                    connection.Open();                   
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand("SELECT TOP 1 cd_produto FROM Produtos ORDER BY cd_produto DESC", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        last_produto = reader.GetInt32(0);
                    }
                    reader.Close();                                                          
                    return last_produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return last_produto;
        }

        public static bool ValidUser(int cd_usuario)
        {
            bool valido = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand("SELECT TOP 1 disponivel FROM Usuarios WHERE cd_usuario =@pCDusuario ORDER BY cd_usuario DESC", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        valido = reader.GetBoolean(0);
                    }
                    reader.Close();
                    return valido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return valido;
        }

        public static DataGridView GetMovimentacoes(DataGridView gridView)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();

                    //definindo sqlcommand
                    string cmdQuery = "SELECT Movimentacoes.cd_movimentacao" +
                        ",Movimentacoes.cd_produto AS 'Código Produto'"+
                        ",Produtos.nome AS 'Produto'" +
                        ",Usuarios.usuario,Remetente.nome AS 'Filial Remetente'" +
                        ",Destinataria.nome AS 'Filial Destinataria'" +
                        ",Movimentacoes.dt_movimentacao " +
                        ",Produtos.disponivel "+
                        "FROM Movimentacoes " +
                        "INNER JOIN Produtos ON Movimentacoes.cd_produto = Produtos.cd_produto " +
                        "INNER JOIN Usuarios ON Movimentacoes.cd_usuario = Usuarios.cod_usuario " +
                        "LEFT JOIN Filiais Remetente ON Movimentacoes.cd_filial_remetente = Remetente.id " +
                        "LEFT JOIN Filiais Destinataria ON Movimentacoes.cd_filial_destinataria = Destinataria.id "+
                        "ORDER BY Movimentacoes.cd_movimentacao DESC";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // definindo gridview como read-only
                    // preenchendo o gridview com o dataset
                    gridView.DataSource = dataSet.Tables[0];
                    connection.Close();
                    return gridView;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return gridView;
        }

        public static void MovimentarProduto(int cd_produto, int cd_remetente, int cd_destinataria)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string cmdQuery = "INSERT INTO Movimentacoes (cd_produto, cd_usuario, cd_filial_remetente, cd_filial_destinataria) VALUES (@cd_produto, @cd_usuario, @cd_remetente, @cd_destinataria);";
                    SqlCommand command = new SqlCommand(cmdQuery, connection);
                    command.Parameters.AddWithValue("@cd_produto", cd_produto);
                    command.Parameters.AddWithValue("@cd_usuario", FormLogin.get_cd_usuario());
                    command.Parameters.AddWithValue("@cd_remetente", cd_remetente);
                    command.Parameters.AddWithValue("@cd_destinataria", cd_destinataria);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Movimentação efetuada!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
               

        public static int GetCD_ProdutoPorCD_Movimentacao(int cd_movimementacao)
        {
            int cd_produto = 0;
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {                    
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand("SELECT cd_produto FROM Movimentacoes WHERE cd_movimentacao=@pCDMov", connection);
                    command.Parameters.AddWithValue("@pCDMov", cd_movimementacao);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cd_produto = reader.GetInt32(0);
                    }
                    reader.Close();
                    return cd_produto;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cd_produto;
        }

        public static int GetCD_FilialPorNomeFilial(string nome)
        {
            int cd_filial = 0;
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand("SELECT id FROM Filiais WHERE nome=@pCDMov", connection);
                    command.Parameters.AddWithValue("@pCDMov", nome);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cd_filial = reader.GetInt32(0);
                    }
                    reader.Close();
                    return cd_filial;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cd_filial;
        }

        public static DataGridView GetMovimentacaoProduto(DataGridView gridView)
        {
            DataGridViewRow row = gridView.Rows[gridView.CurrentRow.Index];
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();
                    string cmdQuery = "SELECT Movimentacoes.cd_movimentacao" +
                        ",Movimentacoes.cd_produto AS 'Código Produto'" +
                        ",Produtos.nome AS 'Produto'" +
                        ",Usuarios.usuario,Remetente.nome AS 'Filial Remetente'" +
                        ",Destinataria.nome AS 'Filial Destinataria'" +
                        ",Movimentacoes.dt_movimentacao " +
                        ",Produtos.disponivel " +
                        "FROM Movimentacoes " +
                        "INNER JOIN Produtos ON Movimentacoes.cd_produto = Produtos.cd_produto " +
                        "INNER JOIN Usuarios ON Movimentacoes.cd_usuario = Usuarios.cod_usuario " +
                        "LEFT JOIN Filiais Remetente ON Movimentacoes.cd_filial_remetente = Remetente.id " +
                        "LEFT JOIN Filiais Destinataria ON Movimentacoes.cd_filial_destinataria = Destinataria.id "+
                        "WHERE Movimentacoes.cd_produto = @pCDproduto "+
                        "ORDER BY Movimentacoes.cd_movimentacao DESC";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@pCDproduto", int.Parse(row.Cells["Código Produto"].Value.ToString()));
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return gridView;
        }              

        public static DataGridView GetMovimentacaoCDProduto(DataGridView gridView, int cd_produto)
        {            
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();
                    string cmdQuery = "SELECT Movimentacoes.cd_movimentacao" +
                        ",Movimentacoes.cd_produto AS 'Código Produto'" +
                        ",Produtos.nome AS 'Produto'" +
                        ",Usuarios.usuario,Remetente.nome AS 'Filial Remetente'" +
                        ",Destinataria.nome AS 'Filial Destinataria'" +
                        ",Movimentacoes.dt_movimentacao " +
                        ",Produtos.disponivel " +
                        "FROM Movimentacoes " +
                        "INNER JOIN Produtos ON Movimentacoes.cd_produto = Produtos.cd_produto " +
                        "INNER JOIN Usuarios ON Movimentacoes.cd_usuario = Usuarios.cod_usuario " +
                        "LEFT JOIN Filiais Remetente ON Movimentacoes.cd_filial_remetente = Remetente.id " +
                        "LEFT JOIN Filiais Destinataria ON Movimentacoes.cd_filial_destinataria = Destinataria.id " +
                        "WHERE Movimentacoes.cd_produto = @pCDproduto " +
                        "ORDER BY Movimentacoes.cd_movimentacao DESC";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@pCDproduto", cd_produto);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // preenchendo o gridview com o dataset                    
                    gridView.DataSource = dataSet.Tables[0];
                    connection.Close();
                    return gridView;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return  gridView;
        }
    }
}
