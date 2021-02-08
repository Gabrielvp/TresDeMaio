using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                    comm.Parameters.AddWithValue("@Titulo", s.Titulo ?? null);
                    comm.Parameters.AddWithValue("@CPF", s.Cpf ?? null);
                    comm.Parameters.AddWithValue("@Nome", s.Nome ?? null);
                    comm.Parameters.AddWithValue("@Rg", s.Rg ?? null);
                    comm.Parameters.AddWithValue("@OrgaoExpedidor", s.OrgaoExpedidor ?? null);
                    comm.Parameters.AddWithValue("@UFOrgaoExpedidor", s.UfOrgaoExpedidor ?? null);
                    comm.Parameters.AddWithValue("@DataExpedicao", s.DataExpedicao ?? null);
                    comm.Parameters.AddWithValue("@DataNascimento", s.DataNascimento ?? null);
                    comm.Parameters.AddWithValue("@DataAdesao", s.DataAdesao ?? null);
                    comm.Parameters.AddWithValue("@DataCadastro", s.DataCadastro ?? null);
                    comm.Parameters.AddWithValue("@DataAtualizacao", s.DataAtualizacao ?? null);
                    comm.Parameters.AddWithValue("@FoneResidencial", s.FoneResidencial ?? null);
                    comm.Parameters.AddWithValue("@FoneCelular", s.FoneCelular ?? null);
                    comm.Parameters.AddWithValue("@FoneComercial", s.FoneComercial ?? null);
                    comm.Parameters.AddWithValue("@Email", s.Email ?? null);
                    comm.Parameters.AddWithValue("@Obs", s.Obs ?? null);
                    comm.Parameters.AddWithValue("@Situacao", s.Situacao ?? null);
                    comm.Parameters.AddWithValue("@UltPagamento", s.UltPagto ?? null);
                    comm.Parameters.AddWithValue("@Ativo", s.Ativo);
                    comm.Parameters.AddWithValue("@PathImagem", s.PathImagem ?? null);
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

        public bool UpdatedSocio(Socio s)
        {
            bool gravou = false;
            string sql;
            // verifica se a conexão está aberta
            if (mConn.State == ConnectionState.Open)
            {
                sql = "UPDATE Socio SET" +
                      "    Titulo = @Titulo," +
                      "    CPF = @CPF," +
                      "    Nome = @Nome," +
                      "    Rg = @Rg," +
                      "    OrgaoExpedidor = @OrgaoExpedidor," +
                      "    UFOrgaoExpedidor = @UFOrgaoExpedidor," +
                      "    DataExpedicao = @DataExpedicao," +
                      "    DataNascimento = @DataNascimento," +
                      "    DataAdesao = @DataAdesao," +
                      "    DataAtualizacao = @DataAtualizacao," +
                      "    FoneResidencial = @FoneResidencial," +
                      "    FoneCelular = @FoneCelular," +
                      "    FoneComercial = @FoneComercial," +
                      "    Email = @Email," +
                      "    Obs = @Obs," +
                      "    Situacao = @Situacao," +
                      "    UltPagamento = @UltPagamento," +
                      "    Ativo = @Ativo," +
                      "    PathImagem = @PathImagem" +
                      " WHERE" +
                      "    ID = " + s.Id;

                MySqlCommand comm = mConn.CreateCommand();
                comm.CommandText = sql;
                try
                {
                    comm.Parameters.AddWithValue("@Titulo", s.Titulo);
                    comm.Parameters.AddWithValue("@CPF", s.Cpf ?? null);
                    comm.Parameters.AddWithValue("@Nome", s.Nome ?? null);
                    comm.Parameters.AddWithValue("@Rg", s.Rg ?? null);
                    comm.Parameters.AddWithValue("@OrgaoExpedidor", s.OrgaoExpedidor ?? null);
                    comm.Parameters.AddWithValue("@UFOrgaoExpedidor", s.UfOrgaoExpedidor ?? null);
                    comm.Parameters.AddWithValue("@DataExpedicao", s.DataExpedicao);
                    comm.Parameters.AddWithValue("@DataNascimento", s.DataNascimento);
                    comm.Parameters.AddWithValue("@DataAdesao", s.DataAdesao);
                    comm.Parameters.AddWithValue("@DataCadastro", s.DataCadastro);
                    comm.Parameters.AddWithValue("@DataAtualizacao", s.DataAtualizacao);
                    comm.Parameters.AddWithValue("@FoneResidencial", s.FoneResidencial);
                    comm.Parameters.AddWithValue("@FoneCelular", s.FoneCelular ?? null);
                    comm.Parameters.AddWithValue("@FoneComercial", s.FoneComercial ?? null);
                    comm.Parameters.AddWithValue("@Email", s.Email ?? null);
                    comm.Parameters.AddWithValue("@Obs", s.Obs ?? null);
                    comm.Parameters.AddWithValue("@Situacao", s.Situacao ?? null);
                    comm.Parameters.AddWithValue("@UltPagamento", s.UltPagto ?? null);
                    comm.Parameters.AddWithValue("@Ativo", s.Ativo);
                    comm.Parameters.AddWithValue("@PathImagem", s.PathImagem ?? null);
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

        public Socio RetornaSocioByTitulo(string titulo)
        {
            Socio s = new Socio();
            try
            {
                string sql = "SELECT * FROM Socio WHERE Titulo = " + titulo;
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    s.Id = int.Parse(rd["Id"].ToString());
                    s.Nome = rd["Nome"].ToString();
                    s.Cpf = rd["Cpf"].ToString();
                    s.Titulo = int.Parse(rd["Titulo"].ToString());
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
            return s;
        }

        public List<Socio> RetornaSocioByNome(string nome)
        {
            List<Socio> list = new List<Socio>();
            try
            {
                string sql = "SELECT * FROM Socio WHERE Nome LIKE('%" + nome + "%')";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new Socio(rd["Nome"].ToString(), int.Parse(rd["Titulo"].ToString())));
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
            return list;
        }

        public Socio RetornaSocioByCpf(string cpf)
        {
            Socio s = new Socio();
            try
            {
                string sql = "SELECT Titulo FROM Socio WHERE Cpf ='" + cpf + "'";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    s.Titulo = int.Parse(rd["Titulo"].ToString());
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
            return s;
        }
    }
}
