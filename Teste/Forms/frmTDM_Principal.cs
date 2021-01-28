﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Teste.Forms;

namespace Teste
{
    public partial class frmTDM_Princiapal : Form
    {
        public frmTDM_Princiapal()
        {
            //frmTDM_Login frmLogin = new frmTDM_Login();
            //frmLogin.ShowDialog();

            InitializeComponent();

            // para sistema não sobrepor a barra de tarefas do windows.
            Screen tela = Screen.FromPoint(this.Location);
            Rectangle R = tela.WorkingArea;
            Size S = R.Size;
            MaximumSize = S;
            TopMost = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = (frmTDM_Princiapal.ActiveForm.Width * 30) / 100;
            pictureBox1.Height = (frmTDM_Princiapal.ActiveForm.Height * 70) / 100;
            pictureBox1.Top = frmTDM_Princiapal.ActiveForm.Height - 800;
            pictureBox1.Left = frmTDM_Princiapal.ActiveForm.Width - 1170;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTDM_CadastroSocio frm = new frmTDM_CadastroSocio();
            frm.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Deseja efetuar um backup?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string path = Application.StartupPath;
                System.Diagnostics.Process.Start(path + "\\backup.bat");
                MessageBox.Show("Backup concluído.", "Mensagem", MessageBoxButtons.OK);
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTDM_CadastroSocio frm = new frmTDM_CadastroSocio();
            frm.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdReceitas_Click(object sender, EventArgs e)
        {
            frmTDM_Receitas frm = new frmTDM_Receitas();
            frm.ShowDialog();
        }

        private void cmdRelatorios_Click(object sender, EventArgs e)
        {
            if(pnlRelatorios.Visible == false)
            {
                pnlRelatorios.Visible = true;
                cmdRelatorios.BackColor = Color.Goldenrod;
            }
            else
            {
                pnlRelatorios.Visible = false;
                cmdRelatorios.BackColor =  Color.FromArgb(37, 46, 59);
            }
        }

        private void lblRelRelacaoSocios_MouseEnter(object sender, EventArgs e)
        {
            lblRelRelacaoSocios.BackColor = Color.DarkGoldenrod;
        }

        private void lblRelRelacaoSocios_MouseLeave(object sender, EventArgs e)
        {
            lblRelRelacaoSocios.BackColor = Color.Goldenrod;
        }

        private void lblRelAReceber_MouseEnter(object sender, EventArgs e)
        {
            lblRelAReceber.BackColor = Color.DarkGoldenrod;
        }

        private void lblRelAReceber_MouseLeave(object sender, EventArgs e)
        {
            lblRelAReceber.BackColor = Color.Goldenrod;
        }

        private void lblRelAtrasados_MouseEnter(object sender, EventArgs e)
        {
            lblRelAtrasados.BackColor = Color.DarkGoldenrod;
        }

        private void lblRelAtrasados_MouseLeave(object sender, EventArgs e)
        {
            lblRelAtrasados.BackColor = Color.Goldenrod;
        }

        private void lblRelRecebido_MouseEnter(object sender, EventArgs e)
        {
            lblRelRecebido.BackColor = Color.DarkGoldenrod;
        }

        private void lblRelRecebido_MouseLeave(object sender, EventArgs e)
        {
            lblRelRecebido.BackColor = Color.Goldenrod;
        }
    }
}