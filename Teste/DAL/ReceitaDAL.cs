using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste.systemException;
using Teste.Models;

namespace Teste.DAL
{
    class ReceitaDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;

        public ReceitaDAL()
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

        public bool InsertReceita(Receita r)
        {
            bool gravou = false;
            string query = " INSERT INTO Receitas( " +
                           "    Documento, Parcela, DataVencimento, DiaVencimento, Valor, FlagPago, Obs, DataCadastro, IdSocio " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           "    @Documento, @Parcela, @DataVencimento, @DiaVencimento, @Valor, @FlagPago, @Obs, @DataCadastro, @IdSOcio " +
                           " ) ";

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.Parameters.AddWithValue("@Documento", r.Documento);
                comm.Parameters.AddWithValue("@Parcela", r.Parcela);
                comm.Parameters.AddWithValue("@DataVencimento", r.DataVencimento);
                comm.Parameters.AddWithValue("@DiaVencimento", r.DiaVencimento);
                comm.Parameters.AddWithValue("@Valor", r.Valor);
                comm.Parameters.AddWithValue("@FlagPago", r.FlagPago);
                comm.Parameters.AddWithValue("@Obs", r.Obs);
                comm.Parameters.AddWithValue("@DataCadastro", r.DataCadastro);
                comm.Parameters.AddWithValue("@IdSocio", r.IdSocio);
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
            return gravou;
        }

        public bool UpdateReceita(Receita r)
        {
            bool gravou = false;
            string query = " UPDATE Receitas SET " +
                           "    Documento = @Documento," +
                           "    Parcela = @Parcela," +
                           "    DataVencimento = @DataVencimento," +
                           "    DiaVencimento = @DiaVencimento," +
                           "    Valor = @Valor," +
                           "    Obs = @Obs" +
                           " WHERE " +
                           "    id =" + r.Id;

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.Parameters.AddWithValue("@Documento", r.Documento);
                comm.Parameters.AddWithValue("@Parcela", r.Parcela);
                comm.Parameters.AddWithValue("@DataVencimento", r.DataVencimento);
                comm.Parameters.AddWithValue("@DiaVencimento", r.DiaVencimento);
                comm.Parameters.AddWithValue("@Valor", r.Valor);
                comm.Parameters.AddWithValue("@Obs", r.Obs);
                comm.ExecuteNonQuery();
                gravou = true;
                mConn.Close();
            }
            catch (SystemException ex)
            {
                gravou = false;
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return gravou;
        }

        public List<Receita> RetornaReceitaBySocio(long id)
        {
            List<Receita> list = new List<Receita>();
            try
            {
                string sql = "SELECT * FROM Receitas WHERE IdSocio = " + id + " And FlagPago = 0 ORDER BY DataVencimento ASC ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new Receita(int.Parse(rd["Id"].ToString()),
                        long.Parse(rd["Documento"].ToString()),
                        int.Parse(rd["Parcela"].ToString()),
                        DateTime.Parse(rd["DataVencimento"].ToString()),
                        int.Parse(rd["DiaVencimento"].ToString()),
                        double.Parse(rd["Valor"].ToString()),
                        bool.Parse(rd["FlagPago"].ToString()),
                        rd["Obs"].ToString()));
                }

                rd.Close();
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
            return list;
        }       

        public List<Receita> RetornaReceitaByPeriodo(long id, string inicio, string fim)
        {            
            List<Receita> list = new List<Receita>();
            try
            {
                string sql = " SELECT * FROM Receitas WHERE " +
                             "  IdSocio = " + id + " " +
                             "  And FlagPago = 0 " +
                             "  And (DataVencimento >= cast('" + inicio + "' as date)" +
                             "  and DataVencimento <= cast('" + fim + "' as date))" +
                             "  ORDER BY DataVencimento ASC ";

                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new Receita(int.Parse(rd["Id"].ToString()),
                        long.Parse(rd["Documento"].ToString()),
                        int.Parse(rd["Parcela"].ToString()),
                        DateTime.Parse(rd["DataVencimento"].ToString()),
                        int.Parse(rd["DiaVencimento"].ToString()),
                        double.Parse(rd["Valor"].ToString()),
                        bool.Parse(rd["FlagPago"].ToString()),
                        rd["Obs"].ToString()));
                }

                rd.Close();
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            catch(DomainException de)
            {
                MessageBox.Show(de.Message);
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return list;
        }

        public Receita RetornaReceitaByDocumento(long socio, long documento)
        {
            Receita r = null;
            try
            {
                string sql = "SELECT * FROM Receitas WHERE idSocio = " + socio + " And Documento = " + documento + " And FlagPago = 0 ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    r = new Receita
                    {
                        Id = int.Parse(rd["Id"].ToString()),
                        Documento = long.Parse(rd["Documento"].ToString()),
                        Parcela = int.Parse(rd["Parcela"].ToString()),
                        DataVencimento = DateTime.Parse(rd["DataVencimento"].ToString()),
                        DiaVencimento = int.Parse(rd["DiaVencimento"].ToString()),
                        Valor = double.Parse(rd["Valor"].ToString()),
                        FlagPago = bool.Parse(rd["FlagPago"].ToString()),
                        Obs = rd["Obs"].ToString()
                    };
                }

                rd.Close();
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
            return r;
        }

        public bool DeletaReceita(long id)
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
                string sql = "DELETE FROM Receitas WHERE Id = " + id;
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
