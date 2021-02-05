using System;
using System.Configuration;
using System.Windows.Forms;

namespace Teste.Models
{
    public class Connection
    {
        static string Server = null;
        static string User = null;
        static string DataBase = null;
        static string Password = null;

        public static string Conexao()
        {
            CarregaConfiguracoesBD();
            return $"Server={Server};User Id={User};Database={DataBase};password={Password}";
        }

        private static void CarregaConfiguracoesBD()
        {
            try
            {
                Server = ConfigurationManager.AppSettings["Server"];
                User = ConfigurationManager.AppSettings["User"];
                DataBase = ConfigurationManager.AppSettings["DataBase"];
                Password = ConfigurationManager.AppSettings["Password"];
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
