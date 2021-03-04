using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.Forms.Reports
{
    public partial class frmTDM_RelAReceber : Form
    {
        string path = null;
        StreamWriter sw = null;
        public frmTDM_RelAReceber()
        {
            InitializeComponent();
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtNome.Text = "";
            mskInicio.Text = "";
            mskFim.Text = "";
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                InitializeReport();
                AbreHTML();
                Cabecalho();
                ProcessaRelatorio();
                FechaHTML();
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um dos filtros.", "Aviso");
            }
        }

        private bool Valida()
        {
            bool validou = false;
            if(txtTitulo.Text.Trim() != "")
            {
                validou = true;
            }
            if(txtNome.Text.Trim() != "")
            {
                validou = true;
            }
            if((mskInicio.Text != "  /  /") && (mskFim.Text != "  /  /"))
            {
                validou = true;
            }
            return validou;
        }

        private void InitializeReport()
        {
            path = @"C:\Report\RelAReceber.html";
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
            string cabecalho;
            cabecalho = "<TR><TD><FONT FACE='VERDANA' SIZE='4'><b>S.R. 3 De Maio</b></TD><TD ALIGN=RIGHT><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></TR>";
            cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Relação de mensalidades abertas</FONT></TD></TR>";
            if (txtTitulo.Text.Trim() != "")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Título: " + txtTitulo.Text + "</FONT></TD></TR>";
            }
            if (txtNome.Text.Trim() != "")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Sócio: " + txtNome.Text + "</FONT></TD></TR>";
            }
            if ((mskInicio.Text != "  /  /") && mskFim.Text != "  /  /")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Período de: " + mskInicio.Text + " à " + mskFim.Text + "</FONT></TD></TR>";
            }
            cabecalho += "<TR><TD><br /></TD ></TR> ";
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

        public void ProcessaRelatorio()
        {
            int cont = 0;
            string body;
            double valor = 0;
            double total = 0;
            long titulo = 0;
            int atraso;
            double totalRelatorio = 0;

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

            try
            {
                string sql = " SELECT S.Titulo, S.Nome, R.Documento, R.DataVencimento, R.Valor " +
                             " FROM Receitas R INNER JOIN Socio S ON R.IdSocio = S.ID " +
                             " WHERE FlagPago = 0 ";

                if (txtTitulo.Text.Trim() != "")
                {
                    sql += " And S.Titulo = " + txtTitulo.Text;
                }
                if ((mskInicio.Text != "  /  /") && (mskFim.Text != "  /  /"))
                {
                    sql += "  And (R.DataVencimento >= cast('" + Funcoes.Formatacoes.FormataDataSql(mskInicio.Text) + "' as date) " +
                           "  And DataVencimento <= cast('" + Funcoes.Formatacoes.FormataDataSql(mskFim.Text) + "' as date)) ";
                }
                if (txtNome.Text.Trim() != "")
                {
                    sql += " And S.Nome = '" + txtNome.Text + "'";
                }

                sql += " ORDER BY S.Nome, R.DataVencimento ASC ";

                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {                    
                    if ((titulo == 0) || (titulo != long.Parse(rd["Titulo"].ToString())))
                    {
                        body = "</TABLE>";
                        body += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE = 'WIDTH=750'>";
                        if (valor > 0)
                        {
                            body += "<tr>";
                            body += "<td  ALIGN=LEFT WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=CENTER WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>" + total.ToString("F2") + "</B></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "</tr>";
                            totalRelatorio += total;
                            total = 0;
                            titulo = long.Parse(rd["Titulo"].ToString());
                        }

                        body += "</TABLE>";
                        body += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE = 'WIDTH=750'>";
                        body += "<TR><TD COLSPAN=2><hr /></TD ></TR> ";
                        body += "<tr>";
                        body += "<td  ALIGN=LEFT WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>Título: " + rd["Titulo"].ToString() + "</B></FONT></TD>";
                        body += "<td  ALIGN=LEFT WIDTH=650><FONT FACE='VERDANA' SIZE='2'><B>Sócio: " + rd["Nome"].ToString() + "</B></FONT></TD>";
                        body += "</tr>";
                        body += "</TABLE>";
                        body += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE = 'WIDTH=750'>";

                        body += "<tr>";
                        body += "<td  ALIGN=LEFT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Documento</B></FONT></TD>";
                        body += "<td  ALIGN=CENTER WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Vencimento</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Valor</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'><B>Atraso</B></FONT></TD>";
                        body += "</tr>";

                        try
                        {
                            using (sw = File.AppendText(path))
                            {
                                sw.WriteLine(body);
                            }
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message, "Aviso");
                        }
                    }
                    if ((titulo == 0) || (titulo == long.Parse(rd["Titulo"].ToString())))
                    {
                        DateTime dt = DateTime.Parse(rd["DataVencimento"].ToString());
                        atraso = (DateTime.Now - dt).Days;
                        cont += 1;
                        valor = double.Parse(rd["Valor"].ToString());
                        total += valor;                        

                        body = "<tr>";
                        body += "<td  ALIGN=LEFT WIDTH=200><FONT FACE='VERDANA' SIZE='2'>" + rd["Documento"].ToString() + "</FONT></TD>";
                        body += "<td  ALIGN=CENTER WIDTH=200><FONT FACE='VERDANA' SIZE='2'>" + rd["DataVencimento"].ToString().Substring(0, 10) + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'>" + valor.ToString("F2") + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'>" + atraso + "</FONT></TD>";
                        body += "</tr>";
                        try
                        {
                            using (sw = File.AppendText(path))
                            {
                                sw.WriteLine(body);
                            }
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message, "Aviso");
                        }                       
                    }
                    titulo = long.Parse(rd["Titulo"].ToString());                   
                }
                body = "</TABLE>";
                body += "<TABLE CELLSPACING = 1 CELLPADDING = 1 STYLE = 'WIDTH=750'>";
                if (valor > 0)
                {
                    body += "<tr>";
                    body += "<td  ALIGN=LEFT WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=CENTER WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>" + total.ToString("F2") + "</B></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "</tr>";
                    totalRelatorio += total;
                    total = 0;
                    try
                    {
                        using (sw = File.AppendText(path))
                        {
                            sw.WriteLine(body);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso");
                    }
                }
                rd.Close();               

                body = "<TR><TD COLSPAN=4><hr /></TD ></TR> ";
                body += "<tr>";
                body += "<td  ALIGN=LEFT WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=CENTER WIDTH=200><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Total R$" + totalRelatorio.ToString("F2") + "</B></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "</tr>";
                total = 0;

                try
                {
                    using (sw = File.AppendText(path))
                    {
                        sw.WriteLine(body);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Aviso");
                }
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
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() != "")
            {
                RetornaSocioByTitulo();
            }
        }

        private void RetornaSocioByTitulo()
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

            try
            {
                string sql = "SELECT Nome FROM Socio WHERE Titulo=" + int.Parse(txtTitulo.Text);
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtNome.Text = rd["Nome"].ToString();
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
        }

        private void cmdPesquisaSocio_Click(object sender, EventArgs e)
        {
            Socio s = Singleton<Socio>.Instance();
            frmTDM_PesquisaSocio frm;
            if (txtNome.Text.Trim() != "")
            {
                frm = new frmTDM_PesquisaSocio(txtNome.Text.Trim());
            }
            else
            {
                frm = new frmTDM_PesquisaSocio();
            }
            frm.ShowDialog();
            txtTitulo.Text = s.Titulo.ToString();
            txtTitulo_Leave(null, null);
        }
    }
}
