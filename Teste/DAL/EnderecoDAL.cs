using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    public class EnderecoDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;

        public EnderecoDAL()
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

        public bool InsertEndereco(Endereco e)
        {
            bool gravou = false;            
            string query = "INSERT INTO Endereco(" +
                           "Cep, Rua, Numero, Bairro, Cidade, UF, Complemento, IdSocio" +
                           ")" +
                           "VALUES" +
                           "(" +
                           "@Cep, @Rua, @Numero, @Bairro, @Cidade, @UF, @Complemento, @IdSocio" +
                           ")";           

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.Parameters.AddWithValue("@Cep", e.Cep);
                comm.Parameters.AddWithValue("@Rua", e.Rua);
                comm.Parameters.AddWithValue("@Numero", e.Numero);
                comm.Parameters.AddWithValue("@Bairro", e.Bairro);
                comm.Parameters.AddWithValue("@Cidade", e.Cidade);
                comm.Parameters.AddWithValue("@UF", e.Uf);
                comm.Parameters.AddWithValue("@Complemento", e.Complemento);
                comm.Parameters.AddWithValue("@IdSocio", e.IdSocio);
                comm.ExecuteNonQuery();
                gravou = true;
                mConn.Close();
            }
            catch(SystemException ex)
            {
                string exception = ex.Message.ToString();
                gravou = false;
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados", 2, exception);
                frmErro.Show();                
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            if (gravou)
            {
                frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frmSucesso.Show();                
            }
            return gravou;
        }

        public bool UpdateEndereco(Endereco e)
        {
            bool gravou = false;
            string query = " UPDATE Endereco SET " +
                           "    Cep = @Cep," +
                           "    Rua = @Rua," +
                           "    Numero = @Numero," +
                           "    Bairro = @Bairro," +
                           "    Cidade = @Cidade," +
                           "    UF = @UF," +
                           "    Complemento = @Complemento" +                                                      
                           " WHERE " +
                           "    idSocio =" + e.IdSocio;

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.Parameters.AddWithValue("@Cep", e.Cep);
                comm.Parameters.AddWithValue("@Rua", e.Rua);
                comm.Parameters.AddWithValue("@Numero", e.Numero);
                comm.Parameters.AddWithValue("@Bairro", e.Bairro);
                comm.Parameters.AddWithValue("@Cidade", e.Cidade);
                comm.Parameters.AddWithValue("@UF", e.Uf);                
                comm.Parameters.AddWithValue("@Complemento", e.Complemento);                
                comm.ExecuteNonQuery();
                gravou = true;
                mConn.Close();
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                gravou = false;
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Erro! Revise os dados!", 2, exception);
                frmErro.Show();
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            if (gravou)
            {
                frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frmSucesso.Show();
            }
            return gravou;
        }
    }
}
