﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

namespace Teste.Forms.Reports
{
    public partial class frmTDM_RelSocios : Form
    {
        string path = null;
        StreamWriter sw = null;
        public frmTDM_RelSocios()
        {
            InitializeComponent();
        }      

        private void InitializeReport()
        {
            path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\RelSocios.html";
        }

        private void AbreHTML()
        {
            try
            {
                using (sw = new StreamWriter(path))
                {
                    sw.WriteLine("<HTML>");
                    sw.WriteLine("<BODY>");
                    sw.WriteLine("<FONT FACE='VERDANA' SIZE='1'>");
                    sw.WriteLine("<TABLE CELLSPACING=1 CELLPADDING=1 STYLE='WIDTH=750'>");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

        private void Cabecalho()
        {
            int cont = 0;
            string cabecalho;          
            //cabecalho = "<TR><TD><FONT FACE='VERDANA' SIZE='4'><b>S.R. 3 De Maio</b></TD><TD ALIGN=RIGHT><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></TR>";
            //cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Relação Sócios</FONT></TD></TR>";         
            cabecalho = "<div>";
            cabecalho += "<img width=100 height=103 ALIGN=LEFT src='" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Images\\logo3DeMaio.png'/>";
            cabecalho += "<tr><TD ALIGN=LEFT width=400><FONT FACE='VERDANA' SIZE='4'><b>&nbsp;&nbsp;&nbsp;&nbsp;S.R. 3 De Maio</b></TD><br /><TD ALIGN=RIGHT width=250><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></tr>";
            cabecalho += "<tr><TD><FONT FACE = 'VERDANA' SIZE='2'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Relação de mensalidades abertas</FONT></TD></tr>";
            cabecalho += "</DIV>";

            cabecalho += "<TR><TD><br /></TD></TR> ";
            cabecalho += "<TR><TD><br /></TD></TR> ";
            cabecalho += "<TR><TD><br /></TD></TR> ";

            cabecalho += "</TABLE>";
            cabecalho += "<TABLE CELLSPACING=1 CELLPADDING=1 STYLE='WIDTH=750'>";

            cabecalho += "<tr>";            
            cabecalho += "<td  ALIGN=LEFT WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>Título</B></FONT></TD>";
            cabecalho += "<td  ALIGN=LEFT WIDTH=650><FONT FACE='VERDANA' SIZE='2'><B>Nome</B></FONT></TD>";
            cabecalho += "</tr>";

            SocioDAL sDAL = new SocioDAL();
            List<Socio> list = sDAL.RetornaSocioByNome(txtNome.Text);
            foreach (Socio socio in list)
            {
                cont += 1;
                cabecalho += "<tr>";
                cabecalho += "<td  ALIGN=LEFT WIDTH=100><FONT FACE='VERDANA' SIZE='2'>" + socio.Titulo + "</FONT></TD>";
                cabecalho += "<td  ALIGN=LEFT WIDTH=650><FONT FACE='VERDANA' SIZE='2'>" + socio.Nome + "</B></FONT></TD>";
                cabecalho += "</tr>";               
                cabecalho += "<TR><TD COLSPAN=2><hr /></TD ></TR> ";                
            }

            cabecalho += "<tr>";
            cabecalho += "<td  ALIGN=LEFT WIDTH=100><FONT FACE='VERDANA' SIZE='2'>Sócios: " + cont + "</FONT></TD>";
            cabecalho += "</tr>";

            try
            {
                using (sw = File.AppendText(path))
                {
                    sw.WriteLine(cabecalho);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

        private void FechaHTML()
        {
            string fechamento;
            fechamento = "</FONT>";
            fechamento += "</TABLE>";
            fechamento += "</Body>";
            fechamento += "</HTML>";

            using (sw = File.AppendText(path))
            {
                sw.WriteLine(fechamento);
            }
            if (sw != null) sw.Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            InitializeReport();
            AbreHTML();
            Cabecalho();
            FechaHTML();
            Process.Start(path);
        }
    }
}
