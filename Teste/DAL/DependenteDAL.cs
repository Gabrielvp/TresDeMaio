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
                catch (SystemException ex)
                {
                    string exception = ex.Message.ToString();
                    gravou = false;
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
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

        public bool UpdateDependente(Dependente d)
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

                comm.CommandText = "UPDATE Dependente SET " +
                                   "    Cpf = @Cpf," +
                                   "    Nome = @Nome," +
                                   "    Obs = @Obs," +
                                   "    DataNascimento = @DataNascimento," +
                                   "    Parentesco = @Parentesco," +
                                   "    Numero = @Numero," +
                                   "    Fone = @Fone," +
                                   "    DataInclusao = @DataInclusao " +
                                   "WHERE ID =" + d.Id;

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
                    comm.ExecuteNonQuery();
                    gravou = true;
                }
                catch (SystemException ex)
                {
                    string exception = ex.Message.ToString();
                    gravou = false;
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
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

        public Dependente RetornaDepentendeByID(long idDependente)
        {
            Dependente d = null;
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
            try
            {
                string sql = "SELECT * FROM Dependente WHERE Id = " + idDependente;
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int? intNumero = null;
                    DateTime? dtNasc = null;
                    if (rd["Numero"].ToString() != "")
                    {
                        intNumero = int.Parse(rd["Numero"].ToString());
                    }
                    if (rd["DataNascimento"].ToString() != "")
                    {
                        dtNasc = DateTime.Parse(rd["DataNascimento"].ToString());
                    }

                    d = new Dependente
                    {
                        Id = int.Parse(rd["Id"].ToString()),
                        Cpf = rd["Cpf"].ToString(),
                        Nome = rd["Nome"].ToString(),
                        DataNascimento = dtNasc,
                        Parentesco = rd["Parentesco"].ToString(),
                        Numero = intNumero,
                        Obs = rd["Obs"].ToString(),
                        Fone = rd["Fone"].ToString(),
                        DataInclusao = DateTime.Parse(rd["DataInclusao"].ToString()),
                        IdSocio = int.Parse(rd["IdSocio"].ToString())
                    };
                }
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return d;
        }

        public bool DeletaDependente(long idDependente)
        {
            bool deletado = false;
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
            try
            {
                string sql = "DELETE FROM Dependente WHERE Id = " + idDependente;
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                deletado = true;
            }
            catch (SystemException ex)
            {
                deletado = false;
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return deletado;
        }
    }
}
