using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Teste.Models;
using Teste.systemException;

namespace Teste.Funcoes
{
    class Validacoes
    {
        public bool ValidaData(string date)
        {
            bool validou;
            bool ehBissexto = false;
            string dia;
            string mes;
            string ano;
            dia = date.Substring(0, 2);
            mes = date.Substring(3, 2);
            ano = date.Substring(6, 4);

            if (DateTime.IsLeapYear(int.Parse(ano)))
            {
                ehBissexto = true;
            }

            switch (int.Parse(mes))
            {
                case 1:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 2:
                    if (ehBissexto)
                    {
                        if (int.Parse(dia) > 29)
                        {
                            validou = false;
                            break;
                        }
                    }
                    else
                    {
                        if (int.Parse(dia) > 28)
                        {
                            validou = false;
                            break;
                        }
                    }
                    validou = true;
                    break;
                case 3:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 4:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 5:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 6:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 7:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 8:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 9:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 10:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 11:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 12:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                default:
                    validou = false;
                    break;
            }
            return validou;
        }

        public static bool VerificaAcessoCadastroSocios(int idUsuario)
        {
            string strConexao = Connection.Conexao();
            MySqlConnection mConn;
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
            bool autorizado = false;
            try
            {
                string sql = "SELECT PSocios FROM Usuarios WHERE Id = " + idUsuario + " And PSocios = 1 ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    autorizado = true;
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
            return autorizado;
        }

        public static bool VerificaAcessoReceitas(int idUsuario)
        {
            string strConexao = Connection.Conexao();
            MySqlConnection mConn;
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
            bool autorizado = false;
            try
            {
                string sql = "SELECT PReceitas FROM Usuarios WHERE Id = " + idUsuario + " And PReceitas = 1 ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    autorizado = true;
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
            return autorizado;
        }

       public static bool VerificaAcessoRelatorios(int idUsuario)
        {
            string strConexao = Connection.Conexao();
            MySqlConnection mConn;
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
            bool autorizado = false;
            try
            {
                string sql = "SELECT PRelatorios FROM Usuarios WHERE Id = " + idUsuario + " And PRelatorios = 1 ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    autorizado = true;
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
            return autorizado;
        }

        public static bool VerificaIsAdministrator(int idUsuario)
        {
            string strConexao = Connection.Conexao();
            MySqlConnection mConn;
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
            bool autorizado = false;
            try
            {
                string sql = "SELECT IsAdministrator FROM Usuarios WHERE Id = " + idUsuario + " And IsAdministrator = 1 ";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    autorizado = true;
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
            return autorizado;
        }

        public static void ValidaDatas(string dtInicio, string dtFim)
        {
            if (dtInicio == "  /  /")
            {
                throw new DomainException("Informe a data inicial");
            }

            if (dtFim == "  /  /")
            {
                throw new DomainException("Informe a data final");
            }

            if (DateTime.Parse(dtInicio) > DateTime.Parse(dtFim))
            {
                throw new DomainException("Data final não pode ser menor que a data inicial");
            }
        }
    }
}
