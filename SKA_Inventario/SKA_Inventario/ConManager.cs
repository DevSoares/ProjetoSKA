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
        //  Função para retornar o cd_usuario validando login e senha
        //
        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            // valor padrão para retorno da função
            int userId = 0;

            SqlConnection con = new SqlConnection("Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;");
            using (SqlCommand cmd = new SqlCommand("SELECT cd_usuario, senha, guid_usuario FROM Usuarios WHERE usuario=@username", con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // dr.Read() = we found user(s) with matching username!
                    int dbUserId = Convert.ToInt32(dr["cd_usuario"]);
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
            // Retorno da função com o cd_usuario que está logado
            return userId;
        }

        //
        //  Função para retornar um DataSet
        //
        public static DataSet Consultar(string query)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new DataSet();
            }
        }
        //
        //  Função para retornar um DataSet passando um parametro de pesquisa string
        //
        public static DataSet Consultar(string query, string parametro, string parametroValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue(parametro, parametroValue);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new DataSet();
            }
        }
        //
        //  Função para retornar um DataSet passando um parametro de pesquisa int
        //
        public static DataSet Consultar(string query, string parametro, int parametroValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue(parametro, parametroValue);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new DataSet();
            }
        }
        //
        //  Função para editar a filial selecionada na tela de filiais
        //
        public static void EditarFilial(int edt_id, string edt_nome, string edt_cidade, string edt_logradouro, string edt_telefone)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();                           
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando parametros
                    command.Parameters.AddWithValue("@ParamID", edt_id);
                    command.Parameters.AddWithValue("@ParamNome", edt_nome);
                    command.Parameters.AddWithValue("@ParamCidade", edt_cidade);
                    command.Parameters.AddWithValue("@ParamLogradouro", edt_logradouro);
                    command.Parameters.AddWithValue("@ParamTelefone", edt_telefone);
                    command.Connection = connection;
                    command.CommandText = "UPDATE Filiais SET nome=@ParamNome, cidade=@ParamCidade, logradouro=@ParamLogradouro, telefone=@ParamTelefone WHERE id=@paramID";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Filial editada!!\n Nome: " + edt_nome + "\n ID: " + edt_id.ToString());
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
        public static void DeletarFilial(int del_id, string del_nome, int disp)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando o parametro
                    command.Parameters.AddWithValue("paramID", del_id);
                    command.Parameters.AddWithValue("@pDisp", disp);
                    command.Connection = connection;
                    command.CommandText = "UPDATE Filiais SET disponivel=@pDisp WHERE id=@paramID";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Filial Alterada!!\n Nome: " + del_nome + "\n ID: " + del_id.ToString());
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
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão com o servidor sql
                    connection.Open();
                    //  definindo parametros do SqlCommand
                    SqlCommand sqlCommand = new SqlCommand();
                    //  Adicionando os parametros
                    sqlCommand.Parameters.AddWithValue("@paramNome", cad_nome);
                    sqlCommand.Parameters.AddWithValue("@paramCidade", cad_cidade);
                    sqlCommand.Parameters.AddWithValue("@paramLogradouro", cad_logradouro);
                    sqlCommand.Parameters.AddWithValue("@paramTelefone", cad_telefone);
                    sqlCommand.Parameters.AddWithValue("@disponivel", 1);
                    //  Definindo atributos do SqlCommand
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = "INSERT INTO Filiais (nome, cidade, logradouro, telefone, disponivel) VALUES (@paramNome, @paramCidade, @paramLogradouro, @paramTelefone, @disponivel);";
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
                    SqlCommand sqlCommand = new SqlCommand();
                    //  Adicionando os parametros
                    sqlCommand.Parameters.AddWithValue("@paramNome", cad_nome);
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
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão com o servidor sql
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    //  Adicionando os parametros
                    sqlCommand.Parameters.AddWithValue("@paramNome", nome);
                    sqlCommand.Parameters.AddWithValue("@paramID", cod_prdt);
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
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o sqlCommand
                    SqlCommand command = new SqlCommand();
                    //  adicionando o parametro
                    command.Parameters.AddWithValue("@paDisponivel", disp);
                    command.Parameters.AddWithValue("@paramID", del_id);
                    command.Connection = connection;
                    command.CommandText = "UPDATE Produtos SET disponivel = @paDisponivel WHERE cd_produto=@paramID";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Status do Produto Alterado!!\n Nome: " + del_nome + "\n ID: " + del_id.ToString());
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }              
        //
        //      Função para pegar o último produto cadastrado
        public static int GetLastProduto()
        {
            int last_produto = 0;           
            try
            {
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
        //
        //      Função para validar o usuario
        //
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
                    command.Parameters.AddWithValue("@pCDusuario", cd_usuario);
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
                        "INNER JOIN Usuarios ON Movimentacoes.cd_usuario = Usuarios.cd_usuario " +
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
                    if (gridView.RowCount == 0) {
                        MessageBox.Show("Identidade inválida! ");
                    }
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
