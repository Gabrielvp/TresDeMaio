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

        public Usuarios RetornaUsuarioByMatricula(string matricula)
        {
            Usuarios u = null;
            try
            {
                string sql = "SELECT * FROM Usuarios WHERE Matricula = '" + matricula + "'";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    u = new Usuarios
                    {
                        Id = int.Parse(rd["Id"].ToString()),
                        Matricula = rd["Matricula"].ToString(),
                        User = rd["Usuario"].ToString(),
                        Senha = rd["Senha"].ToString(),
                        PSocios = bool.Parse(rd["PSocios"].ToString()),
                        PReceitas = bool.Parse(rd["PReceitas"].ToString()),
                        PRelatorios = bool.Parse(rd["PRelatorios"].ToString()),
                        FIncluirSocios = bool.Parse(rd["FIncluirSocios"].ToString()),
                        FCadastroReceitas = bool.Parse(rd["FCadastroReceitas"].ToString()),
                        FBaixaReceitas = bool.Parse(rd["FBaixaReceitas"].ToString()),
                        IsAdministrator = bool.Parse(rd["IsAdministrator"].ToString()),
                    };
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

        public bool InsertUsuario(Usuarios u)
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
            string query = " INSERT INTO Usuarios( " +
                           " Matricula, Usuario, Senha, PSocios, PReceitas, PRelatorios, " +
                           " FIncluirSocios, FCadastroReceitas, FBaixaReceitas, IsAdministrator" +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @Matricula, @Usuario, @Senha, @PSocios, @PReceitas, @PRelatorios," +
                           " @FIncluirSocios, @FCadastroReceitas, @FBaixaReceitas, @IsAdministrator " +
                           " ) ";

            MySqlCommand comm = mConn.CreateCommand();
            comm.CommandText = query;
            try
            {
                comm.Parameters.AddWithValue("@Matricula", u.Matricula);
                comm.Parameters.AddWithValue("@Usuario", u.User);
                comm.Parameters.AddWithValue("@Senha", u.Senha);
                comm.Parameters.AddWithValue("@PSocios", u.PSocios);
                comm.Parameters.AddWithValue("@PReceitas", u.PReceitas);
                comm.Parameters.AddWithValue("@PRelatorios", u.PRelatorios);
                comm.Parameters.AddWithValue("@FIncluirSocios", u.FIncluirSocios);
                comm.Parameters.AddWithValue("@FCadastroReceitas", u.FCadastroReceitas);
                comm.Parameters.AddWithValue("@FBaixaReceitas", u.FBaixaReceitas);
                comm.Parameters.AddWithValue("@IsAdministrator", u.IsAdministrator);
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

        public bool UpdateUsuario(Usuarios u)
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
                string query = " UPDATE Usuarios SET " +
                               "    Matricula = @Matricula," +
                               "    Usuario = @Usuario," +
                               "    Senha = @Senha," +
                               "    PSocios = @PSocios," +
                               "    PReceitas = @PReceitas," +
                               "    PRelatorios = @PRelatorios," +
                               "    FIncluirSocios = @FIncluirSocios," +
                               "    FCadastroReceitas = @FCadastroReceitas," +
                               "    FBaixaReceitas = @FBaixaReceitas," +
                               "    IsAdministrator = @IsAdministrator " +
                               " WHERE " +
                               "    Id =" + u.Id;

                MySqlCommand comm = mConn.CreateCommand();
                comm.CommandText = query;

                comm.Parameters.AddWithValue("@Matricula", u.Matricula);
                comm.Parameters.AddWithValue("@Usuario", u.User);
                comm.Parameters.AddWithValue("@Senha", u.Senha);
                comm.Parameters.AddWithValue("@PSocios", u.PSocios);
                comm.Parameters.AddWithValue("@PReceitas", u.PReceitas);
                comm.Parameters.AddWithValue("@PRelatorios", u.PReceitas);
                comm.Parameters.AddWithValue("@FIncluirSocios", u.FIncluirSocios);
                comm.Parameters.AddWithValue("@FCadastroReceitas", u.FCadastroReceitas);
                comm.Parameters.AddWithValue("@FBaixaReceitas", u.FBaixaReceitas);
                comm.Parameters.AddWithValue("@IsAdministrator", u.IsAdministrator);
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
            catch (Exception ex)
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
