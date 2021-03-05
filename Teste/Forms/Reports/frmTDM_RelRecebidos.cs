using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Teste.Models;

namespace Teste.Forms.Reports
{
    public partial class frmTDM_RelRecebidos : Form
    {
        string path = null;
        StreamWriter sw = null;
        public frmTDM_RelRecebidos()
        {
            InitializeComponent();
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
                
        private void InitializeReport()
        {
            path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\RelRecebidos.html";
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
            //cabecalho = "<TR><TD><FONT FACE='VERDANA' SIZE='4'><b>S.R. 3 De Maio</b></TD><TD ALIGN=RIGHT><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></TR>";
            //cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>Relação de recebimentos</FONT></TD></TR>";
            cabecalho = "<div>";
            cabecalho += "<img width=100 height=103 ALIGN=LEFT src='" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Images\\logo3DeMaio.png'/>";
            cabecalho += "<tr><TD ALIGN=LEFT width=400><FONT FACE='VERDANA' SIZE='4'><b>&nbsp;&nbsp;&nbsp;&nbsp;S.R. 3 De Maio</b></TD><br /><TD ALIGN=RIGHT width=250><FONT FACE='VERDANA' SIZE='2'>" + DateTime.Now + "</FONT></TD></tr>";
            cabecalho += "<tr><TD><FONT FACE = 'VERDANA' SIZE='2'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Relação de recebimentos</FONT></TD></tr>";
            cabecalho += "</DIV>";
            if (txtTitulo.Text.Trim() != "")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Título: " + txtTitulo.Text + "</FONT></TD></TR>";
            }
            if (txtNome.Text.Trim() != "")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Sócio: " + txtNome.Text + "</FONT></TD></TR>";
            }
            if ((mskInicio.Text != "  /  /") && mskFim.Text != "  /  /")
            {
                cabecalho += "<TR><TD><FONT FACE = 'VERDANA' SIZE='2'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Período de: " + mskInicio.Text + " à " + mskFim.Text + "</FONT></TD></TR>";
            }
            if ((txtTitulo.Text.Trim() != "") && (txtNome.Text.Trim() != ""))
            {
                cabecalho += "<TR><TD COLSPAN=2><br /></TD ></TR> ";
            }
            if ((txtTitulo.Text.Trim() == "") && (txtNome.Text.Trim() == ""))
            {
                cabecalho += "<TR><TD COLSPAN=2><br /></TD ></TR> ";
                cabecalho += "<TR><TD COLSPAN=2><br /></TD ></TR> ";
            }
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

        public void ProcessaRelatorio()
        {
            int cont = 0;
            string body;
            double valor = 0;
            double juros = 0;
            double desconto = 0;
            double valorPago = 0;
            double total = 0;
            double totalJuros = 0;
            double totalDesconto = 0;
            double totalPago = 0;
            long titulo = 0;         
            
            double totalRelatorio = 0;
            double totalRelJuros = 0;
            double totalRelDesconto = 0;
            double totalRelPago = 0;

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
                string sql = " SELECT S.Titulo, S.Nome, P.DataVencimento, P.DataPagamento, P.Valor, P.Juros, P.Desconto, P.ValorPago " +
                             " FROM Pagamentos P INNER JOIN Socio S ON P.IdSocio = S.ID " +
                             " WHERE P.Id > 0 ";

                if (txtTitulo.Text.Trim() != "")
                {
                    sql += " And S.Titulo = " + txtTitulo.Text;
                }
                if ((mskInicio.Text != "  /  /") && (mskFim.Text != "  /  /"))
                {
                    if (rbtnDtVencimento.Checked)
                    {
                        sql += "  And (P.DataVencimento >= cast('" + Funcoes.Formatacoes.FormataDataSql(mskInicio.Text) + "' as date) " +
                               "  And P.DataVencimento <= cast('" + Funcoes.Formatacoes.FormataDataSql(mskFim.Text) + "' as date)) ";
                    }
                    else
                    {
                        sql += "  And (P.DataPagamento >= cast('" + Funcoes.Formatacoes.FormataDataSql(mskInicio.Text) + "' as date) " +
                               "  And P.DataPagamento <= cast('" + Funcoes.Formatacoes.FormataDataSql(mskFim.Text) + "' as date)) ";
                    }
                }
                if (txtNome.Text.Trim() != "")
                {
                    sql += " And S.Nome = '" + txtNome.Text + "'";
                }
                if (rbtnDtVencimento.Checked)
                {
                    sql += " ORDER BY S.Nome, P.DataVencimento ASC ";
                }
                else
                {
                    sql += " ORDER BY S.Nome, P.DataPagamento ASC ";
                }

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
                            body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'><B>" + total.ToString("F2") + "</B></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                            body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>" + totalPago.ToString("F2") + "</B></FONT></TD>";
                            body += "</tr>";
                            totalRelatorio += total;
                            totalRelJuros += totalJuros;
                            totalRelDesconto += totalDesconto;
                            totalRelPago += totalPago;

                            total = 0;
                            totalJuros = 0;
                            totalDesconto = 0;
                            totalPago = 0;
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
                        body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>Vencimento</B></FONT></TD>";
                        body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>Pagamento</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'><B>Valor</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>%Juros</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'><B>%Desconto</B></FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Pago</B></FONT></TD>";
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
                        cont += 1;
                        valor = double.Parse(rd["Valor"].ToString());
                        juros = double.Parse(rd["Juros"].ToString());
                        desconto = double.Parse(rd["Desconto"].ToString());
                        valorPago = double.Parse(rd["ValorPago"].ToString());

                        total += valor;
                        totalJuros += juros;
                        totalDesconto += desconto;
                        totalPago += valorPago;

                        body = "<tr>";
                        body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'>" + rd["DataVencimento"].ToString().Substring(0, 10) + "</FONT></TD>";
                        body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'>" + rd["DataPagamento"].ToString().Substring(0, 10) + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'>" + valor.ToString("F2") + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'>" + juros.ToString("F2") + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'>" + desconto.ToString("F2") + "</FONT></TD>";
                        body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'>" + valorPago.ToString("F2") + "</FONT></TD>";
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
                    body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'><B>" + total.ToString("F2") + "</B></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                    body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>" + totalPago.ToString("F2") + "</B></FONT></TD>";
                    body += "</tr>";
                    totalRelatorio += total;
                    totalRelJuros += totalJuros;
                    totalRelDesconto += totalDesconto;
                    totalRelPago += totalPago;

                    total = 0;
                    totalJuros = 0;
                    totalDesconto = 0;
                    totalPago = 0;

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

                body = "<TR><TD COLSPAN=6><hr /></TD ></TR> ";
                body += "<tr>";
                body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Total R$" + totalRelatorio.ToString("F2") + "</B></FONT></TD>";
                body += "</tr>";                

                body += "<tr>";
                body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=CENTER WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=150><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=100><FONT FACE='VERDANA' SIZE='2'></FONT></TD>";
                body += "<td  ALIGN=RIGHT WIDTH=200><FONT FACE='VERDANA' SIZE='2'><B>Recebido R$" + totalRelPago.ToString("F2") + "</B></FONT></TD>";
                body += "</tr>";

                total = 0;
                totalJuros = 0;
                totalDesconto = 0;
                totalPago = 0;

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

        private bool Valida()
        {
            bool validou = false;
            if (txtTitulo.Text.Trim() != "")
            {
                validou = true;
            }
            if (txtNome.Text.Trim() != "")
            {
                validou = true;
            }
            if ((mskInicio.Text != "  /  /") && (mskFim.Text != "  /  /"))
            {
                validou = true;
            }
            return validou;
        }

        private void frmTDM_RelEmAtraso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtNome.Text = "";
            mskInicio.Text = "";
            mskFim.Text = "";
        }

        private void txtTitulo_Leave_1(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() != "")
            {
                RetornaSocioByTitulo();
            }
        }

        private void cmdLimpar_Click_1(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtNome.Text = "";
            rbtnDtPagamento.Checked = true;
            mskInicio.Text = "";
            mskFim.Text = "";
        }

        private void cmdPesquisaSocio_Click_1(object sender, EventArgs e)
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
            txtTitulo_Leave_1(null, null);
        }
    }
}
