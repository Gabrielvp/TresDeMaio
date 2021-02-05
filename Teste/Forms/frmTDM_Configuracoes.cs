using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Teste.Forms
{
    public partial class frmTDM_Configuracoes : Form
    {
        private OleDbConnection _olecon;
        private OleDbCommand _oleCmd;
        private static String _Arquivo = @"C:\dados\Socios.xlsx";
        private String _StringConexao = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + _Arquivo + "; Extended Properties = 'Excel 8.0;HDR=YES'");
        private String _Consulta;

        public frmTDM_Configuracoes()
        {
            InitializeComponent();
            try
            {
                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdLer_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            try
            {
                _oleCmd.CommandText = "SELECT Nome, Titulo, Situacao, Pagamento, Telefone, obs, obs2 FROM [Socios]";
                OleDbDataReader reader = _oleCmd.ExecuteReader();

                while (reader.Read())
                {

                    item = new ListViewItem();
                    item.Text = reader.GetValue(0).ToString();
                    item.SubItems.Add(reader.GetValue(1).ToString());
                    item.SubItems.Add(reader.GetValue(2).ToString());
                    item.SubItems.Add(reader.GetValue(3).ToString());
                    item.SubItems.Add(reader.GetValue(4).ToString());
                    item.SubItems.Add(reader.GetValue(5).ToString());
                    lstImportacao.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulaLista()
        {

        }
    }
}
