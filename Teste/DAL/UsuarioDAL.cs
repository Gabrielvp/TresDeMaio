using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    class UsuarioDAL
    {

        string strConexao = Connection.Conexao();
        MySqlConnection mConn;

        public UsuarioDAL()
        {
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
        }

        public Usuarios RetornaIdByNome(string usuario)
        {
            Usuarios u = new Usuarios();
            try
            {
                string sql = "SELECT Id FROM Usuarios WHERE Usuario = '" + usuario + "'";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    u.Id = int.Parse(rd["Id"].ToString());
                }
                rd.Close();
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
            return u;
        }
    }
}
