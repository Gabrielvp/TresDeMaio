using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmTDM_Login : Form
    {
        MySqlConnection mConn;
        public frmTDM_Login()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Server=localhost;User Id=root;Database=TresDeMaio_DB;password=102910");
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            if (!Login())
            {                
                MessageBox.Show("Usuário ou senha incorretos","Mensagem");
                txtSenha.Text = "";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool Login()
        {
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
    }
}
