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
    public partial class FormPesqMovimentacaoPorFilial : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setComboBox();
        }
        public FormPesqMovimentacaoPorFilial()
        {
            InitializeComponent();
        }
        private void setComboBox()
        {
            cb_Filial.DataSource = ConManager.Consultar("SELECT nome FROM Filiais").Tables[0];
            cb_Filial.DisplayMember = "nome";
            cb_Filial.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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
                        "WHERE cd_filial_remetente = @parametro OR cd_filial_destinataria = @parametro " +
                        "ORDER BY Movimentacoes.cd_movimentacao DESC", "@parametro", cb_Filial.SelectedIndex+1).Tables[0];
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            this.Dispose();
        }
    }
}
