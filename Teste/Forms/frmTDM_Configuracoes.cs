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
            int cont = 0;
            string ano = null;
            DateTime? data = null;
            string convertData = null;
            try
            {
                _oleCmd.CommandText = "SELECT Nome, Titulo, Situacao, Pagamento, Telefone, obs, obs2 FROM [Socios$]";
                OleDbDataReader reader = _oleCmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetValue(3).ToString().Length == 4)
                    {
                        ano = reader.GetValue(3).ToString();
                    }
                    else if(reader.GetValue(3).ToString().Length > 4)
                    {
                        convertData = reader.GetValue(3).ToString();
                        data = DateTime.Parse(convertData.ToString());
                    }

                    item = new ListViewItem();
                    item.Text = reader.GetValue(0).ToString();
                    item.SubItems.Add(reader.GetValue(1).ToString());
                    item.SubItems.Add(reader.GetValue(2).ToString());
                    if (!string.IsNullOrEmpty(ano))
                    {
                        item.SubItems.Add(ano.ToString());
                    }
                    else
                    {
                        item.SubItems.Add(data.ToString());
                    }
                    item.SubItems.Add(reader.GetValue(4).ToString());
                    item.SubItems.Add(reader.GetValue(5).ToString());
                    lstImportacao.Items.Add(item);
                    cont += 1;
                    ano = null;
                    data = null;
                }
                reader.Close();
                lblCont.Text = cont.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
