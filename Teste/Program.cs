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
            try
            {

                if (f.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmTDM_Princiapal());
                }
            }
            catch(SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Verifique", 2, exception);
                frm.ShowDialog();
            }
           
        }
    }
}
