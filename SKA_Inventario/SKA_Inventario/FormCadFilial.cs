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
    public partial class FormCadFilial : Form
    {
        public FormCadFilial()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
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
                    SqlParameter paramNome = new SqlParameter("@paramNome", SqlDbType.NVarChar,50);
                    paramNome.Value = txbNomeFilial.Text;
                    SqlParameter paramCidade = new SqlParameter("@paramCidade", SqlDbType.NVarChar, 50);
                    paramCidade.Value = txbCidadeFilial.Text;
                    SqlParameter paramLogradouro = new SqlParameter("@paramLogradouro", SqlDbType.NVarChar,50);
                    paramLogradouro.Value = txbLogFilial.Text;
                    SqlParameter paramTelefone = new SqlParameter("@paramTelefone", SqlDbType.NVarChar, 50);
                    paramTelefone.Value = txbTelFilial.Text;
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
                    MessageBox.Show("INSERT INTO Filiais (nome, cidade, logradouro, telefone) VALUES (@paramNome, @paramCidade, @paramLogradouro, @paramTelefone);");
                    //  Fechando a conexão
                    connection.Close();
                }                
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }
    }
}
