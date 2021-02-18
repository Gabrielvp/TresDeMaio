using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

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
            CarregaSede();
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

        private void CarregaSede()
        {            
            SedeDAL sDAL = new SedeDAL();
            Sede s = sDAL.RetornaSede();
            if (s != null)
            {
                lblIdSede.Text = s.Id.ToString();
                txtNmFantasia.Text = s.NomeFantasia;
                txtRazaoSocial.Text = s.RazaoSocial;
                mskCnpj.Text = s.Cnpj;
                txtInscEstadual.Text = s.InscricaoEstadual;
                txtEndereco.Text = s.Endereco;
                txtNumero.Text = s.Numero;
                txtBairro.Text = s.Bairro;
                txtCidade.Text = s.Cidade;
                cmbUfEndereco.Text = s.Uf;
                mskTelefone.Text = s.Telefone;
                txtEmail.Text = s.Email;
            }
        }

        private void cmdLer_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            int cont = 0;
            string ano = null;
            DateTime? data = null;
            string convertData = null;
            string fone = null;
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
                    else if (reader.GetValue(3).ToString().Length > 4)
                    {
                        convertData = reader.GetValue(3).ToString().Substring(0, 10);
                        data = DateTime.Parse(convertData.ToString());
                    }
                    else
                    {
                        ano = null;
                    }

                    if (reader.GetValue(4).ToString().Length == 8)
                    {
                        fone = "(00) 9" + reader.GetValue(4).ToString().Substring(0, 4) + "-" + reader.GetValue(4).ToString().Substring(4, 4);
                    }
                    else if (reader.GetValue(4).ToString().Length == 9)
                    {
                        fone = "(00) " + reader.GetValue(4).ToString().Substring(0, 5) + "-" + reader.GetValue(4).ToString().Substring(5, 4);
                    }
                    else
                    {
                        fone = "";
                    }

                    item = new ListViewItem();
                    item.Text = reader.GetValue(0).ToString();
                    item.SubItems.Add(reader.GetValue(1).ToString());
                    item.SubItems.Add(reader.GetValue(2).ToString());
                    if (!string.IsNullOrEmpty(ano))
                    {
                        item.SubItems.Add(ano.ToString());
                    }
                    else if(data != null)
                    {
                        item.SubItems.Add(data.ToString().Substring(0, 10));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    item.SubItems.Add(fone.ToString());
                    item.SubItems.Add(reader.GetValue(5).ToString() + " - " + reader.GetValue(6).ToString());
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

        private void cmdImportar_Click(object sender, EventArgs e)
        {
            Socio s = new Socio();
            for (int i = 0; i < lstImportacao.Items.Count; i++)
            {
                try
                {
                    s.Nome = lstImportacao.Items[i].SubItems[0].Text;
                    s.Titulo = int.Parse(lstImportacao.Items[i].SubItems[1].Text);
                    s.Situacao = lstImportacao.Items[i].SubItems[2].Text;
                    s.UltPagto = lstImportacao.Items[i].SubItems[3].Text;
                    s.FoneCelular = lstImportacao.Items[i].SubItems[4].Text;
                    s.Obs = lstImportacao.Items[i].SubItems[5].Text;
                    s.DataAdesao = DateTime.Now;
                    InsertSocio(s);
                }
                catch (SystemException ex)
                {

                }
            }
        }

        public bool InsertSocio(Socio s)
        {
            string strConexao = Connection.Conexao();
            MySqlConnection mConn;
            mConn = new MySqlConnection(strConexao);
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool gravou = false;
            string sql;
            // verifica se a conexão está aberta
            if (mConn.State == ConnectionState.Open)
            {
                sql = "INSERT INTO Socio" +
                      "(" +
                      "    Titulo, Nome, FoneCelular, Obs, Situacao, UltPagamento, Ativo, DataAdesao " +
                      ")" +
                      "VALUES" +
                      "(" +
                      "    @Titulo, @Nome, @FoneCelular, @Obs, @Situacao, @UltPagamento, @Ativo, @DataAdesao " +
                      ")";
                MySqlCommand comm = mConn.CreateCommand();
                comm.CommandText = sql;
                try
                {
                    comm.Parameters.AddWithValue("@Titulo", s.Titulo ?? null);
                    comm.Parameters.AddWithValue("@Nome", s.Nome ?? null);
                    comm.Parameters.AddWithValue("@FoneCelular", s.FoneCelular ?? null);
                    comm.Parameters.AddWithValue("@Obs", s.Obs ?? null);
                    comm.Parameters.AddWithValue("@Situacao", s.Situacao ?? null);
                    comm.Parameters.AddWithValue("@UltPagamento", s.UltPagto ?? null);
                    comm.Parameters.AddWithValue("@Ativo", s.Ativo);
                    comm.Parameters.AddWithValue("@DataAdesao", s.DataAdesao);
                    comm.ExecuteNonQuery();
                    gravou = true;
                    mConn.Close();

                }
                catch (SystemException ex)
                {
                    string exception = ex.Message.ToString();
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados!", 2, exception);
                    frmErro.Show();
                    gravou = false;
                }
                finally
                {
                    mConn.Close();
                }
            }
            mConn.Close();
            return gravou;
        }

        private void cmdGravarSede_Click(object sender, EventArgs e)
        {
            Sede();
        }

        private void Sede()
        {
            try
            {
                SedeDAL sDAL = new SedeDAL();
                Sede s = new Sede
                {
                    NomeFantasia = txtNmFantasia.Text,
                    RazaoSocial = txtRazaoSocial.Text,
                    Cnpj = mskCnpj.Text,
                    InscricaoEstadual = txtInscEstadual.Text,
                    Endereco = txtEndereco.Text,
                    Numero = txtNumero.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Uf = cmbUfEndereco.Text,
                    Telefone = mskTelefone.Text,
                    Email = txtEmail.Text
                };
                if (lblIdSede.Text.Equals("idSede"))
                {
                    sDAL.InsertSede(s);
                }
                else
                {
                    s.Id = int.Parse(lblIdSede.Text);
                    sDAL.UpdateSede(s);
                }
                CarregaSede();
            }
            catch(SystemException ex)
            {
                string exception;
                exception = ex.Message;
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Revise os dados", 2, exception);
                frm.ShowDialog();
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            Usuario();
            Limpar();
        }

        private void Usuario()
        {
            try
            {
                UsuarioDAL uDAL = new UsuarioDAL();
                Usuarios u = new Usuarios
                {
                    Matricula = txtMatricula.Text,
                    User = txtUsuario.Text,
                    Senha = txtSenha.Text,
                    PSocios = ckbPSocios.Checked,
                    PReceitas = ckbPReceitas.Checked,
                    PRelatorios = ckbPRelatorios.Checked,
                    FIncluirSocios = ckbFSocios.Checked,
                    FCadastroReceitas = ckbFCadastroReceitas.Checked,
                    FBaixaReceitas = ckbFBaixaReceitas.Checked,
                    IsAdministrator = ckbAdministrador.Checked
                };
                if (lblIdUsuario.Text.Equals("idUsuario"))
                {
                    uDAL.InsertUsuario(u);
                }
                else
                {
                    u.Id = int.Parse(lblIdUsuario.Text);
                    uDAL.UpdateUsuario(u);
                }
                
            }catch(SystemException ex)
            {
                string exception;
                exception = ex.Message;
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Revise os dados", 2, exception);
                frm.ShowDialog();
            }
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            if (txtMatricula.Text.Trim() != "")
            {
                Usuarios u = new Usuarios();
                UsuarioDAL uDAL = new UsuarioDAL();
                u = uDAL.RetornaUsuarioByMatricula(txtMatricula.Text);

                if (u != null)
                {
                    lblIdUsuario.Text = u.Id.ToString();
                    txtMatricula.Text = u.Matricula;
                    txtUsuario.Text = u.User;
                    txtSenha.Text = u.Senha;
                    ckbAdministrador.Checked = u.IsAdministrator;
                    ckbPSocios.Checked = u.PSocios;
                    ckbPReceitas.Checked = u.PReceitas;
                    ckbPRelatorios.Checked = u.PRelatorios;
                    ckbFSocios.Checked = u.FIncluirSocios;
                    ckbFCadastroReceitas.Checked = u.FCadastroReceitas;
                    ckbFBaixaReceitas.Checked = u.FBaixaReceitas;
                }
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtMatricula.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            ckbAdministrador.Checked = false;
            ckbPSocios.Checked = true;
            ckbPReceitas.Checked = true;
            ckbPRelatorios.Checked = true;
            ckbFSocios.Checked = true;
            ckbFCadastroReceitas.Checked = true;
            ckbFBaixaReceitas.Checked = true;
            lblIdUsuario.Text = "isUsuario";
        }
    }
}
