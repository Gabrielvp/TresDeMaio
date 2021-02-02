using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

namespace Teste
{
    public partial class frmTDM_Login : Form
    {
        MySqlConnection mConn;
        string strConexao = Connection.Conexao();
        public frmTDM_Login()
        {
            InitializeComponent();
            TesteConexao();
        }

        private void TesteConexao()
        {
            strConexao = Connection.Conexao();
            mConn = new MySqlConnection(strConexao);
            try

            {
                mConn.Open();
                mConn.Close();
            }
            catch(SystemException ex)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados\n" + ex.Message, "Mensagem");
                cmdConfigConexao.Visible = true;
            }
            finally
            {
                mConn.Close();
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            if (!Login())
            {
                MessageBox.Show("Usuário ou senha incorretos", "Mensagem");
                txtSenha.Text = "";
            }
            else
            {
                Usuarios u = new Usuarios();
                UsuarioDAL uDAL = new UsuarioDAL();
                Usuarios a = Singleton<Usuarios>.Instance();

                u = uDAL.RetornaIdByNome(txtUsuario.Text);
                a.User = txtUsuario.Text;
                a.Id = u.Id;

                DialogResult = DialogResult.OK;
            }
        }

        private bool Login()
        {
            mConn = new MySqlConnection(strConexao);
            bool encontrado = false;
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            try
            {
                string sql = "SELECT Id FROM Usuarios WHERE Usuario='" + txtUsuario.Text + "' AND Senha='" + txtSenha.Text + "'";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    encontrado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return encontrado;
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                settings["Server"].Value = txtServer.Text;
                settings["User"].Value = txtUser.Text;
                settings["DataBase"].Value = txtDataBase.Text;
                settings["Password"].Value = txtPassword.Text;
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                cmdConfigConexao.Visible = false;
                pnlConexao.Visible = false;
                TesteConexao();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

        private void cmdConfigConexao_Click(object sender, EventArgs e)
        {
            if (pnlConexao.Visible == false)
            {
                pnlConexao.Visible = true;
            }
            else
            {
                pnlConexao.Visible = false; ;
            }
            pnlConexao.Dock = DockStyle.Fill;
            try
            {
                txtServer.Text = ConfigurationManager.AppSettings["Server"];
                txtUser.Text = ConfigurationManager.AppSettings["User"];
                txtDataBase.Text = ConfigurationManager.AppSettings["DataBase"];
                txtPassword.Text = ConfigurationManager.AppSettings["Password"];
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
