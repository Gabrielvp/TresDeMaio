using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    public class DependenteDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;
        public bool InsertDependente(Dependente d)
        {
            mConn = new MySqlConnection(strConexao);
            bool gravou = false;
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            // verifica se a conexão está aberta
            if (mConn.State == ConnectionState.Open)
            {
                MySqlCommand comm = mConn.CreateCommand();

                comm.CommandText = "INSERT INTO Dependente(Cpf, Nome, Obs, DataNascimento, Parentesco, Numero, Fone, DataInclusao, IdSocio)" +
                "VALUES" +
                "(@Cpf, @Nome, @Obs, @DataNascimento, @Parentesco, @Numero, @Fone, @DataInclusao, @IdSocio)";

                try
                {
                    comm.Parameters.AddWithValue("@Cpf", d.Cpf);
                    comm.Parameters.AddWithValue("@Nome", d.Nome);
                    comm.Parameters.AddWithValue("@Obs", d.Obs);
                    comm.Parameters.AddWithValue("@DataNascimento", d.DataNascimento);
                    comm.Parameters.AddWithValue("@Parentesco", d.Parentesco);
                    comm.Parameters.AddWithValue("@Numero", d.Numero);
                    comm.Parameters.AddWithValue("@Fone", d.Fone);
                    comm.Parameters.AddWithValue("@DataInclusao", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ssss"));
                    comm.Parameters.AddWithValue("@IdSocio", d.IdSocio);
                    comm.ExecuteNonQuery();
                    gravou = true;
                }
                catch (SystemException e)
                {
                    gravou = false;
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados!" + e.Message, 2);
                    frmErro.Show();
                }
                finally
                {
                    mConn.Close();
                }               
            }
            mConn.Close();
            return gravou;
        }
    }
}
