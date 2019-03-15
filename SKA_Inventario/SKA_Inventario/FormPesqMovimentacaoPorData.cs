using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKA_Inventario
{
    public partial class FormPesqMovimentacaoPorData : Form
    {
        public FormPesqMovimentacaoPorData()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            FormPrincipal.StaticGrid.DataSource = ConManager.Consultar("SELECT Movimentacoes.cd_movimentacao" +
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
                        "WHERE dt_movimentacao = @data " +
                        "ORDER BY Movimentacoes.cd_movimentacao DESC", "@data", theDate).Tables[0];
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Dispose();
        }
    }
}
