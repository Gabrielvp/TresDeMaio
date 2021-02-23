using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    class PagamentoDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;
        public PagamentoDAL()
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
        public bool InsertPagamento(Pagamento p)
        {
            bool gravou = false;
            string query = " INSERT INTO Pagamentos(" +
                           "    Documento, DataVencimento, Valor, Desconto, Juros, ValorDescJuros, ValorPago, DataPagamento, " +
                           "    ObsPagamento, IdSocio, IdReceita " +
                           ")" +
                           " VALUES " +
                           "(" +
                           "    @Documento, @DataVencimento, @Valor, @Desconto, @Juros, @ValorDescJuros, @ValorPago, @DataPagamento, " +
                           "    @ObsPagamento, @IdSocio, @IdReceita " +
                           ")";

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.Parameters.AddWithValue("@Documento", p.Documento);
                comm.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);
                comm.Parameters.AddWithValue("@Valor", p.Valor);
                comm.Parameters.AddWithValue("@Desconto", p.Desconto);
                comm.Parameters.AddWithValue("@Juros", p.Juros);
                comm.Parameters.AddWithValue("@ValorDescJuros", p.ValorDescJuros);
                comm.Parameters.AddWithValue("@ValorPago", p.ValorPago);
                comm.Parameters.AddWithValue("@DataPagamento", p.DataPagamento);
                comm.Parameters.AddWithValue("@ObsPagamento", p.ObsPagamento);
                comm.Parameters.AddWithValue("@IdSocio", p.IdSocio);
                comm.Parameters.AddWithValue("@IdReceita", p.IdReceita);
                comm.ExecuteNonQuery();
                gravou = true;
                mConn.Close();
            }
            catch (SystemException ex)
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
            return gravou;
        }

        public bool UpdateReceita(long idReceita)
        {
            bool gravou = false;
            try
            {
                // abre conexão com banco
                mConn.Close();
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            string query = " UPDATE Receitas SET " +
                           "    FlagPago = true" +
                           " WHERE " +
                           "    Id =" + idReceita;

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;

            try
            {
                comm.ExecuteNonQuery();
                gravou = true;
                mConn.Close();
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                gravou = false;
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.ShowDialog();
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            return gravou;
        }

        public List<Pagamento> RetornaReceitaPagaBySocio(int idSocio)
        {
            List<Pagamento> list = new List<Pagamento>();
            try
            {
                string sql = " SELECT " +
                             "      p.DataPagamento, " +
                             "      r.Valor, " +
                             "      p.IdSocio, " +
                             "      p.ValorPago, " +
                             "      r.Documento, " +
                             "      r.DataVencimento, " +
                             "      p.Desconto, " +
                             "      p.Juros, " +
                             "      p.ValorDescJuros, " +
                             "      P.ObsPagamento " +
                             " FROM " +
                             "      pagamentos p inner join receitas r on p.idReceita = r.id " +
                             " WHERE " +
                             "      p.idsocio = " + idSocio +
                             " ORDER BY DataPagamento, DataVencimento DESC ";

                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new Pagamento(long.Parse(rd["Documento"].ToString()),
                        DateTime.Parse(rd["DataVencimento"].ToString()),
                        double.Parse(rd["Valor"].ToString()),
                        int.Parse(rd["IdSocio"].ToString()),
                        double.Parse(rd["Desconto"].ToString()),
                        double.Parse(rd["Juros"].ToString()),
                        double.Parse(rd["ValorDescJuros"].ToString()),
                        double.Parse(rd["ValorPago"].ToString()),
                        DateTime.Parse(rd["DataPagamento"].ToString()),
                        rd["ObsPagamento"].ToString()));
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
    }
}
