using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    class SocioDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;

        public SocioDAL()
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
        public bool InsertSocio(Socio s)
        {
            bool gravou = false;
            string sql;
            // verifica se a conexão está aberta
            if (mConn.State == ConnectionState.Open)
            {                
                sql = "INSERT INTO Socio" +
                      "(" +
                      "    Titulo, CPF, Nome, Rg, OrgaoExpedidor, UFOrgaoExpedidor," +
                      "    DataExpedicao, DataNascimento, DataAdesao, DataCadastro, DataAtualizacao," +
                      "    FoneResidencial, FoneCelular, FoneComercial, Email, Obs, Situacao, UltPagamento, Ativo, PathImagem" +
                      ")" +
                      "VALUES" +
                      "(" +
                      "    @Titulo, @CPF, @Nome, @Rg, @OrgaoExpedidor, @UFOrgaoExpedidor, @DataExpedicao, " +
                      "    @DataNascimento, @DataAdesao, @DataCadastro, @DataAtualizacao, @FoneResidencial," +
                      "    @FoneCelular, @FoneComercial, @Email, @Obs, @Situacao, @UltPagamento, @Ativo, @PathImagem" +
                      ")";
                MySqlCommand comm = mConn.CreateCommand();
                comm.CommandText = sql;
                try
                {
                    comm.Parameters.AddWithValue("@Titulo", s.Titulo);
                    comm.Parameters.AddWithValue("@CPF", s.Cpf);
                    comm.Parameters.AddWithValue("@Nome", s.Nome);
                    comm.Parameters.AddWithValue("@Rg", s.Rg);
                    comm.Parameters.AddWithValue("@OrgaoExpedidor", s.OrgaoExpedidor);
                    comm.Parameters.AddWithValue("@UFOrgaoExpedidor", s.UfOrgaoExpedidor);
                    comm.Parameters.AddWithValue("@DataExpedicao", s.DataExpedicao);
                    comm.Parameters.AddWithValue("@DataNascimento", s.DataNascimento);
                    comm.Parameters.AddWithValue("@DataAdesao", s.DataAdesao);
                    comm.Parameters.AddWithValue("@DataCadastro", s.DataCadastro);
                    comm.Parameters.AddWithValue("@DataAtualizacao", s.DataAtualizacao);
                    comm.Parameters.AddWithValue("@FoneResidencial", s.FoneResidencial);
                    comm.Parameters.AddWithValue("@FoneCelular", s.FoneCelular);
                    comm.Parameters.AddWithValue("@FoneComercial", s.FoneComercial);
                    comm.Parameters.AddWithValue("@Email", s.Email);
                    comm.Parameters.AddWithValue("@Obs", s.Obs);
                    comm.Parameters.AddWithValue("@Situacao", s.Situacao);
                    comm.Parameters.AddWithValue("@UltPagamento", s.UltPagto);
                    comm.Parameters.AddWithValue("@Ativo", s.Ativo);
                    comm.Parameters.AddWithValue("@PathImagem", s.PathImagem);
                    comm.ExecuteNonQuery();
                    gravou = true;
                    mConn.Close();

                }
                catch (SystemException e)
                {
                    //MessageBox.Show(e.Message.ToString());
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados!", 2);
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
    }

}
