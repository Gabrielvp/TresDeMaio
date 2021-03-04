using System;
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
            path = @"C:\Report\RelSocios.html";
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
            //cabecalho = "<TR><TD ROWSPAN=11><width=20% IMG SRC='C:\\VS\\Teste\\Teste\\Teste\\Images\\logo3DeMaio.png'>&nbsp;&nbsp;&nbsp;&nbsp;</TD></TR>";
            cabecalho = "<TR><TD><FONT FACE='VERDANA' SIZE='4'><b>S.R. 3 De Maio</b></TD><TD ALIGN=RIGHT><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></TR>";
            cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Relação Sócios</FONT></TD></TR>";
            cabecalho += "</TABLE>";
            cabecalho += "<TR><TD><hr /></TD ></TR> ";
            cabecalho += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE='WIDTH=750'>";
            cabecalho += "<TR><TD><br /></TD ></TR> ";

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
                cabecalho += "</TABLE>";
                cabecalho += "<TR><TD><hr /></TD ></TR> ";
                cabecalho += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE='WIDTH=750'>";
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
