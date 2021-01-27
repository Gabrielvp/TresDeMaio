using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmTDM_Menssagem : Form
    {
        private readonly Timer timer = new Timer();       
        public frmTDM_Menssagem(string mensagem, int tipo)
        {
            InitializeComponent();           
            lblMensagem.Text = mensagem;            
            if(tipo == 1)
            {                
                lblMensagem.BackColor = Color.YellowGreen;
            }
            else if(tipo == 2)
            {             
                lblMensagem.BackColor = Color.DarkOrange;
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
    }
}
