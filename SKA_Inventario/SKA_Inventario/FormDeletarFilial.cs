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
    public partial class FormDeletarFilial : Form
    {
        private int gridViewID;
        private string gridViewNome;
        private string gridViewCidade;
        private string gridViewLogradouro;
        private string gridViewTelefone;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setLabels();
        }

        public FormDeletarFilial()
        {
            InitializeComponent();           
          
        }

        private void setLabels()
        {
            lblNomeFilial.Text = "Nome: "+ getGridViewNome();
            lblIDFilial.Text = "ID: "+ getGridViewID().ToString();
            lblCidadeFilial.Text = "Cidade: " + getGridViewCidade();
            lblLogradouroFilial.Text = "Logradouro: "+getGridViewLogradouro();
            lblTelefoneFilial.Text = "Telefone: "+getGridViewTelefone();
        }
        
        private void btnConfirmarExclusao_Click(object sender, EventArgs e)
        {
            
            string msgDelConf = "Filial excluída!!\n Nome: " + getGridViewNome() + "\n ID: " + getGridViewID().ToString();
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //  abrindo a conexão
                    connection.Open();
                    //  configurando o parametro de exclusão
                    SqlParameter paramID = new SqlParameter("@paramID", SqlDbType.Int);
                    paramID.Value = getGridViewID();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }
    }
}
