using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Teste
{
    static class Program
    {
       
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmTDM_Login f = new frmTDM_Login();
            if(f.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmTDM_Princiapal());
            }
           
        }
    }
}
