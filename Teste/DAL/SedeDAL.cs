using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.DAL
{
    class SedeDAL
    {
        string strConexao = Connection.Conexao();
        MySqlConnection mConn;
        public bool InsertSede(Sede s)
        {
            mConn = new MySqlConnection(strConexao);
            try
            {
                // abre conexão com banco
                mConn.Close();
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            bool gravou = false;
            string query = " INSERT INTO Sede( " +
                           " NomeFantasia, RazaoSocial, Cnpj, InscricaoEstadual, Endereco, Numero, Bairro, Cidade," +
                           " UF, Telefone, Email " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @NomeFantasia, @RazaoSocial, @Cnpj, @InscricaoEstadual, @Endereco, @Numero, @Bairro, @Cidade," +
                           " @UF, @Telefone, @Email " +
                           " ) ";

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;
            try
            {
                comm.Parameters.AddWithValue("@NomeFantasia", s.NomeFantasia);
                comm.Parameters.AddWithValue("@RazaoSocial", s.RazaoSocial);
                comm.Parameters.AddWithValue("@Cnpj", s.Cnpj);
                comm.Parameters.AddWithValue("@InscricaoEstadual", s.InscricaoEstadual);
                comm.Parameters.AddWithValue("@Endereco", s.Endereco);
                comm.Parameters.AddWithValue("@Numero", s.Numero);
                comm.Parameters.AddWithValue("@Bairro", s.Bairro);
                comm.Parameters.AddWithValue("@Cidade", s.Cidade);
                comm.Parameters.AddWithValue("@UF", s.Uf);
                comm.Parameters.AddWithValue("@Telefone", s.Telefone);
                comm.Parameters.AddWithValue("@Email", s.Email);
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
            if (gravou)
            {
                frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frmSucesso.Show();
            }
            return gravou;
        }

        public bool UpdateSede(Sede s)
        {
            mConn = new MySqlConnection(strConexao);
            try
            {
                // abre conexão com banco
                mConn.Close();
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            bool gravou = false;

            try
            {
                string query = " UPDATE Sede SET " +
                               "    NomeFantasia = @NomeFantasia," +
                               "    RazaoSocial = @RazaoSocial," +
                               "    Cnpj = @Cnpj," +
                               "    InscricaoEstadual = @InscricaoEstadual," +
                               "    Endereco = @Endereco," +
                               "    Numero = @Numero," +
                               "    Bairro = @Bairro," +
                               "    Cidade = @Cidade," +
                               "    UF = @UF," +
                               "    Telefone = @Telefone," +
                               "    Email = @Email " +
                               " WHERE " +
                               "    Id =" + s.Id;

                MySqlCommand comm = mConn.CreateCommand();
                comm.CommandText = query;


                comm.Parameters.AddWithValue("@NomeFantasia", s.NomeFantasia);
                comm.Parameters.AddWithValue("@RazaoSocial", s.RazaoSocial);
                comm.Parameters.AddWithValue("@Cnpj", s.Cnpj);
                comm.Parameters.AddWithValue("@InscricaoEstadual", s.InscricaoEstadual);
                comm.Parameters.AddWithValue("@Endereco", s.Endereco);
                comm.Parameters.AddWithValue("@Numero", s.Numero);
                comm.Parameters.AddWithValue("@Bairro", s.Bairro);
                comm.Parameters.AddWithValue("@Cidade", s.Cidade);
                comm.Parameters.AddWithValue("@UF", s.Uf);
                comm.Parameters.AddWithValue("@Telefone", s.Telefone);
                comm.Parameters.AddWithValue("@Email", s.Email);
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

        public Sede RetornaSede()
        {
            mConn = new MySqlConnection(strConexao);
            try
            {
                // abre conexão com banco
                mConn.Close();
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Sede s = null; ;
            try
            {
                string sql = "SELECT * FROM Sede ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    s = new Sede
                    {
                        Id = int.Parse(rd["Id"].ToString()),
                        NomeFantasia = rd["NomeFantasia"].ToString(),
                        RazaoSocial = rd["RazaoSocial"].ToString(),
                        Cnpj = rd["CNPJ"].ToString(),
                        InscricaoEstadual = rd["InscricaoEstadual"].ToString(),
                        Endereco = rd["Endereco"].ToString(),
                        Numero = rd["Numero"].ToString(),
                        Bairro = rd["Bairro"].ToString(),
                        Cidade = rd["Cidade"].ToString(),
                        Uf = rd["UF"].ToString(),
                        Telefone = rd["Telefone"].ToString(),
                        Email = rd["Email"].ToString()
                    };
                }

                rd.Close();
            }
            catch (SystemException ex)
            {
                string exception;
                exception = ex.Message;
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
