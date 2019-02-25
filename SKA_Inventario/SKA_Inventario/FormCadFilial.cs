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
            SqlConnection connection = new SqlConnection("Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008;"+"Database=ProjectSKA;"+"User Id=SQL_PROJECT_SKA;"+"Password=Dev0test@;");
            try
            {
                connection.Open();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter paramNome = new SqlParameter("@paramNome", SqlDbType.NVarChar);
            paramNome.Value = txbNomeFilial.Text;
            SqlParameter paramID = new SqlParameter("@paramID", SqlDbType.Int);
            paramID.Value = int.Parse("0004");
            SqlParameter paramCidade = new SqlParameter("@paramCidade", SqlDbType.NVarChar, 50);
            paramCidade.Value = txbCidadeFilial.Text;
            SqlParameter paramLogradouro = new SqlParameter("@paramLogradouro", SqlDbType.NVarChar);
            paramLogradouro.Value = txbLogFilial.Text;
            SqlParameter paramTelefone = new SqlParameter("@paramTelefone", SqlDbType.NVarChar, 50);
            paramTelefone.Value = txbTelFilial.Text;
//          Adicionando os parametros
            sqlCommand.Parameters.Add(paramNome);
            sqlCommand.Parameters.Add(paramID);
            sqlCommand.Parameters.Add(paramCidade);
            sqlCommand.Parameters.Add(paramLogradouro);
            sqlCommand.Parameters.Add(paramTelefone);

            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO Filiais (nome, id, cidade, logradouro, telefone) VALUES (@paramNome, @paramID, @paramCidade, @paramLogradouro, @paramTelefone);";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("INSERT INTO Filiais (nome, id, cidade, logradouro, telefone) VALUES (@paramNome, @paramID, @paramCidade, @paramLogradouro, @paramTelefone);");

            try
            {
                connection.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.ToString());
            }
            this.Close();
        }
    }
}
