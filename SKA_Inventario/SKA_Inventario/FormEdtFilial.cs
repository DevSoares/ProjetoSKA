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
    public partial class FormEdtFilial : Form
    {
        private int gridViewID;
        private string gridViewNome;
        private string gridViewCidade;
        private string gridViewLogradouro;
        private string gridViewTelefone;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setTextBoxes();
        }

        public FormEdtFilial()
        {
            InitializeComponent();
        }

        private void setTextBoxes() {
            txbNomeFilial.Text = getGridViewNome();
            txbIDFilial.Text = getGridViewID().ToString();
            txbCidadeFilial.Text = getGridViewCidade();
            txbLogradouroFilial.Text = getGridViewLogradouro();
            txbTelefoneFilial.Text = getGridViewTelefone();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }

        //  sets e gets das propriedades resgatadas do gridview
        public void setGridViewID(int newID)
        {
            gridViewID = newID;
        }
        public int getGridViewID()
        {
            return gridViewID;
        }
        public void setGridViewNome(string newNome)
        {
            this.gridViewNome = newNome;
        }
        public string getGridViewNome()
        {
            return this.gridViewNome;
        }
        public void setGridViewCidade(string newCidade)
        {
            this.gridViewCidade = newCidade;
        }
        public string getGridViewCidade()
        {
            return this.gridViewCidade;
        }
        public void setGridViewLogradouro(string newLogradouro)
        {
            this.gridViewLogradouro = newLogradouro;
        }
        public string getGridViewLogradouro()
        {
            return this.gridViewLogradouro;
        }
        public void setGridViewTelefone(string newTelefone)
        {
            this.gridViewTelefone = newTelefone;
        }
        public string getGridViewTelefone()
        {
            return this.gridViewTelefone;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

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
                    paramID.Value = getGridViewID();
                    SqlParameter paramNome = new SqlParameter("@ParamNome", SqlDbType.NVarChar,50);
                    paramNome.Value = txbNomeFilial.Text;
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
            this.Close();
        }
    }
}
