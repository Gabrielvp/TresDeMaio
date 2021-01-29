using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmTDM_Menssagem : Form
    {
        private readonly Timer timer = new Timer();
        string exception;
        public frmTDM_Menssagem(string mensagem, int tipo, string ex)
        {
            InitializeComponent();           
            lblMensagem.Text = mensagem;
            exception = ex;
            if(tipo == 1)
            {                
                lblMensagem.BackColor = Color.YellowGreen;
                cmdDetalhes.Visible = false;
            }
            else if(tipo == 2)
            {             
                lblMensagem.BackColor = Color.DarkOrange;
                cmdDetalhes.Visible = true;                
            }
            
            timer.Interval = 2000;
            timer.Start();
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {            
            timer.Stop();
            Close();
        }

        private void cmdDetalhes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(exception, "Exception");
        }
    }
}
