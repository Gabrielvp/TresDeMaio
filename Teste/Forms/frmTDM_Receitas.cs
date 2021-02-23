using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Funcoes;
using Teste.Models;

namespace Teste.Forms
{
    public partial class frmTDM_Receitas : Form
    {
        public string Result { get; set; }
        public frmTDM_Receitas()
        {
            InitializeComponent();
        }

        public frmTDM_Receitas(string valor)
        {
            InitializeComponent();
            txtTitulo.Text = valor;
        }

        private void cmdPesquisaSocio_Click(object sender, EventArgs e)
        {
            Socio s = Singleton<Socio>.Instance();
            frmTDM_PesquisaSocio frm = new frmTDM_PesquisaSocio();
            frm.ReferenciaForm = this;
            frm.ShowDialog();
            txtTitulo.Text = s.Titulo.ToString();
            txtTitulo_Leave(null, null);
        }

        private void BuscaSocioByTitulo(string titulo)
        {
            SocioDAL sDAL = new SocioDAL();
            Socio s = sDAL.RetornaSocioByTitulo(titulo);
            mskCpf.Text = s.Cpf;
            lblNome.Text = s.Nome;
            lblIdSocio.Text = s.Id.ToString();
            lblNome.Visible = true;
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() != "")
            {
                BuscaSocioByTitulo(txtTitulo.Text);
                PopulaLista();
                PopulaListaPagos();
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Replace(".", "");
            cpf = cpf.Replace(",", "");
            if (cpf != "         -")
            {
                SocioDAL sDal = new SocioDAL();
                Socio s = sDal.RetornaSocioByCpf(mskCpf.Text);
                if (s.Titulo != 0)
                {
                    txtTitulo.Text = s.Titulo.ToString();
                    txtTitulo_Leave(null, null);
                }
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            LimparBaixa();
        }

        private void Limpar()
        {
            txtTitulo.Text = "";
            mskCpf.Text = "";
            lblNome.Text = "";
            lblNome.Visible = false;
            lblIdSocio.Text = "idSocio";
            txtDocumento.Text = "";
            txtParcela.Text = "";
            mskDataVencimento.Text = "";
            txtDiaVencimento.Text = "";
            txtValor.Text = "";
            txtObs.Text = "";
            lstMensaliddes.Items.Clear();
            lstUltPagamento.Items.Clear();
            txtTitulo.Focus();
            lblMensalidades.Text = "0";
            lblPagamentos.Text = "0";
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            if (!lblIdSocio.Text.Equals("idSocio"))
            {
                if (ckbGerarParcelas.Checked)
                {
                    DateTime data = DateTime.Parse(mskDataVencimento.Text);
                    if (txtDiaVencimento.Text.Trim() != "0")
                    {
                        string ajustaDiaData = txtDiaVencimento.Text + data.ToString().Substring(2, 8);
                        data = DateTime.Parse(ajustaDiaData);
                    }

                    int n = int.Parse(txtParcela.Text);
                    for (int i = 0; i < n; i++)
                    {
                        InserirReceitaParcelada(data, i + 1);
                        if (txtDiaVencimento.Text.Trim() != "0")
                        {
                            data = data.AddMonths(1);
                        }
                        else
                        {
                            data = data.AddDays(30);
                        }
                        PopulaLista();
                    }
                    frmTDM_Menssagem frm = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                    frm.ShowDialog();
                    LimpezaParcial();
                }
                else
                {
                    InserirReceita(DateTime.Parse(mskDataVencimento.Text));
                    PopulaLista();
                }
            }
            else
            {
                //AtualizarReceita();
            }
        }

        private void InserirReceita(DateTime data)
        {
            bool gravou = false;
            ReceitaDAL rDal = new ReceitaDAL();
            try
            {
                Receita r = new Receita
                {
                    Documento = long.Parse(txtDocumento.Text),
                    Parcela = int.Parse(txtParcela.Text),
                    DataVencimento = data,
                    DiaVencimento = int.Parse(txtDiaVencimento.Text),
                    Valor = double.Parse(txtValor.Text),
                    FlagPago = false,
                    Obs = txtObs.Text,
                    DataCadastro = DateTime.Now,
                    IdSocio = int.Parse(lblIdSocio.Text)
                };
                gravou = rDal.InsertReceita(r);
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.ShowDialog();
            }
            if (gravou)
            {
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frm.ShowDialog();
                LimpezaParcial();
                //Limpar();
            }
        }

        private void InserirReceitaParcelada(DateTime data, int parcela)
        {
            bool gravou = false;
            ReceitaDAL rDal = new ReceitaDAL();
            try
            {
                Receita r = new Receita
                {
                    Documento = long.Parse(GeraNumeroDocumentoParcelado(data, parcela)),
                    Parcela = int.Parse(txtParcela.Text),
                    DataVencimento = data,
                    DiaVencimento = int.Parse(txtDiaVencimento.Text),
                    Valor = double.Parse(txtValor.Text),
                    FlagPago = false,
                    Obs = txtObs.Text,
                    DataCadastro = DateTime.Now,
                    IdSocio = int.Parse(lblIdSocio.Text)
                };
                gravou = rDal.InsertReceita(r);
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.ShowDialog();
            }
        }

        private void LimpezaParcial()
        {
            mskDataVencimento.Text = "";
            txtDiaVencimento.Text = "0";
            txtValor.Text = "";
            txtParcela.Text = "1";
            txtDocumento.Text = "";
            ckbGerarParcelas.Checked = false;
            txtDiaVencimento.Enabled = false;
            txtParcela.Enabled = false;
        }

        private void AtualizarReceita()
        {
            bool gravou = false;
            ReceitaDAL rDal = new ReceitaDAL();
            try
            {
                Receita r = new Receita
                {
                    Documento = int.Parse(txtDocumento.Text),
                    Parcela = int.Parse(txtParcela.Text),
                    DataVencimento = DateTime.Parse(mskDataVencimento.Text),
                    DiaVencimento = int.Parse(txtDiaVencimento.Text),
                    Valor = double.Parse(txtValor.Text),
                    Obs = txtObs.Text,
                    IdSocio = int.Parse(lblIdSocio.Text)
                };
                gravou = rDal.InsertReceita(r);
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.ShowDialog();
            }
            if (gravou)
            {
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frm.ShowDialog();
                Limpar();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            double valor = 0;
            bool result = double.TryParse(txtValor.Text, out valor);
            if (result == false)
            {
                MessageBox.Show("Campo valor deve ser numérico", "Aviso");
                txtValor.Text = "0,00";
                txtValor.Focus();
                return;
            }

            if (txtValor.Text != "")
            {
                txtValor.Text = double.Parse(txtValor.Text).ToString("F2");
            }
            else
            {
                txtValor.Text = "0";
            }
        }

        private void PopulaLista()
        {
            int cont = 0;
            lstMensaliddes.Items.Clear();
            int atraso = 0;
            ReceitaDAL rDal = new ReceitaDAL();
            List<Receita> list = rDal.RetornaReceitaBySocio(int.Parse(lblIdSocio.Text));
            foreach (Receita r in list)
            {
                cont += 1;
                atraso = (DateTime.Now - r.DataVencimento).Days;
                if (atraso == 0 && DateTime.Now.Day != r.DataVencimento.Day) atraso = 1;
                ListViewItem item;
                item = new ListViewItem();
                item.Text = r.DataVencimento.ToString().Substring(0, 10);
                item.SubItems.Add(r.Valor.ToString("F2"));
                item.SubItems.Add(atraso.ToString());
                item.SubItems.Add(r.Documento.ToString());
                item.SubItems.Add(r.Parcela.ToString());
                item.SubItems.Add(r.DiaVencimento.ToString());
                item.SubItems.Add(r.Obs.ToString());
                item.SubItems.Add(r.Id.ToString());
                lstMensaliddes.Items.Add(item);
            }
            lblMensalidades.Text = cont.ToString();
        }

        private void PopulaListaPagos()
        {
            int cont = 0;
            lstUltPagamento.Items.Clear();
            PagamentoDAL pDal = new PagamentoDAL();
            List<Pagamento> list = pDal.RetornaReceitaPagaBySocio(int.Parse(lblIdSocio.Text));
            foreach (Pagamento p in list)
            {
                cont += 1;
                ListViewItem item;
                item = new ListViewItem();
                item.Text = p.DataPagamento.ToString().Substring(0, 10);
                item.SubItems.Add(p.Valor.ToString("F2"));
                item.SubItems.Add(p.ValorPago.ToString("F2"));
                item.SubItems.Add(p.Documento.ToString());
                item.SubItems.Add(p.DataVencimento.ToString().Substring(0, 10));
                item.SubItems.Add(p.Desconto.ToString("F2"));
                item.SubItems.Add(p.Juros.ToString("F2"));
                item.SubItems.Add(p.ValorDescJuros.ToString("F2"));
                item.SubItems.Add(p.ObsPagamento.ToString());
                lstUltPagamento.Items.Add(item);
            }
            lblPagamentos.Text = cont.ToString();
        }

        private string GeraNumeroDocumento()
        {
            string NrDocumento;
            string titulo = txtTitulo.Text;
            string ano = mskDataVencimento.Text.Substring(8, 2);
            string mes = mskDataVencimento.Text.Substring(3, 2);
            string dia;
            string parcela;

            if (txtDiaVencimento.Text.Trim() != "" && txtDiaVencimento.Text != "0")
            {
                dia = txtDiaVencimento.Text;
            }
            else
            {
                dia = mskDataVencimento.Text.Substring(0, 2);
            }

            if (txtParcela.Text != "" && txtParcela.Text != "1")
            {
                parcela = txtParcela.Text;
            }
            else
            {
                parcela = "1";
            }
            if (ckbGerarParcelas.Checked)
            {
                NrDocumento = titulo + ano + mes + dia;
            }
            else
            {
                NrDocumento = titulo + ano + mes + dia + parcela;
            }
            return NrDocumento;
        }

        private string GeraNumeroDocumentoParcelado(DateTime data, int parcela)
        {
            string NrDocumento;
            string titulo = txtTitulo.Text;
            string ano = data.ToString().Substring(8, 2);
            string mes = data.ToString().Substring(3, 2);
            string dia = data.ToString().Substring(0, 2);

            NrDocumento = titulo + ano + mes + dia + parcela;
            return NrDocumento;
        }

        private void mskDataVencimento_Leave(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            if (mskDataVencimento.Text.Length == 10)
            {
                if (v.ValidaData(mskDataVencimento.Text) == false)
                {
                    MessageBox.Show("Data inválida.", "Mensagem");
                    mskDataVencimento.Focus();
                    return;
                }
            }
            if (mskDataVencimento.Text == "  /  /")
            {
                MessageBox.Show("Data de vencimento inválida.", "Mensagem");
                mskDataVencimento.Focus();
                return;
            }
            if (mskDataVencimento.Text.Length != 10)
            {
                MessageBox.Show("Data inválida.", "Mensagem");
                mskDataVencimento.Focus();
                return;
            }
        }

        private void ckbGerarParcelas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGerarParcelas.Checked)
            {
                txtDiaVencimento.Enabled = true;
                txtParcela.Enabled = true;
                if (txtDocumento.Text.Trim() != "")
                {
                    txtDocumento.Text = GeraNumeroDocumento();
                }
            }
            else
            {
                txtDiaVencimento.Enabled = false;
                txtParcela.Enabled = false;
                txtDiaVencimento.Text = "0";
                txtParcela.Text = "1";
                if (mskDataVencimento.Text != "  /  /")
                {
                    txtDocumento.Text = GeraNumeroDocumento();
                }
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (mskDataVencimento.Text != "  /  /")
            {
                txtDocumento.Text = "";
                txtDocumento.Text = GeraNumeroDocumento();
            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (lstMensaliddes.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia.", "Mensagem");
                return;
            }

            if (lstMensaliddes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione a mensalidade", "Mensagem");
                return;
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show($"Deseja excluir a mensalidade com vencimento em\n {lstMensaliddes.FocusedItem.SubItems[0].Text} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(lstMensaliddes.FocusedItem.SubItems[7].Text);
                        bool deletado = false;
                        ReceitaDAL rDal = new ReceitaDAL();
                        deletado = rDal.DeletaReceita(id);
                        if (deletado)
                        {
                            PopulaLista();
                            frmTDM_Menssagem frm = new frmTDM_Menssagem("Mensalidade excluída.", 1, "");
                            frm.ShowDialog();
                        }
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void frmTDM_Receitas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void lstMensaliddes_DoubleClick(object sender, EventArgs e)
        {
            tbLancamentos.SelectedTab = tabPage2;
            txtDocumentoBaixa.Text = lstMensaliddes.FocusedItem.SubItems[3].Text;
            mskVencimentoBaixa.Text = lstMensaliddes.FocusedItem.SubItems[0].Text;
            txtValorBaixa.Text = lstMensaliddes.FocusedItem.SubItems[1].Text;
            txtValorPagoBaixa.Text = txtValorBaixa.Text;
            mskDataPagamentoBaixa.Text = DateTime.Now.ToString();
            lblIdParcela.Text = lstMensaliddes.FocusedItem.SubItems[7].Text;
        }

        private void txtDescontoBaixa_Leave(object sender, EventArgs e)
        {
            if (txtDescontoBaixa.Text.Trim() == "")
            {
                txtDescontoBaixa.Text = 0.00.ToString();
            }
            if (txtDescontoBaixa.Text.Trim() != "")
            {
                if (txtJurosBaixa.Text.Trim() != "" && double.Parse(txtJurosBaixa.Text) > 0)
                {
                    MessageBox.Show("Para lançar valor de desconto não pode haver juros.", "Aviso");
                    txtDescontoBaixa.Focus();
                    return;
                }
                double valor;
                valor = double.Parse(txtValorBaixa.Text);
                valor = valor * double.Parse(txtDescontoBaixa.Text) / 100;
                txtValorDescJurosBaixa.Text = valor.ToString("F2");
                txtValorPagoBaixa.Text = (double.Parse(txtValorBaixa.Text) - valor).ToString();
                txtValorPagoBaixa.Text = double.Parse(txtValorPagoBaixa.Text).ToString("F2");
                txtDescontoBaixa.Text = double.Parse(txtDescontoBaixa.Text).ToString("F2");
            }
        }

        private void txtJurosBaixa_Leave(object sender, EventArgs e)
        {
            if (txtJurosBaixa.Text == "")
            {
                txtJurosBaixa.Text = "0";
            }

            if (txtJurosBaixa.Text.Trim() != "" && txtJurosBaixa.Text != "0")
            {
                if (txtDescontoBaixa.Text.Trim() != "" && double.Parse(txtDescontoBaixa.Text) > 0)
                {
                    MessageBox.Show("Para lançar valor de juros não pode haver desconto.", "Aviso");
                    txtJurosBaixa.Focus();
                    return;
                }
                double valor;
                valor = double.Parse(txtValorBaixa.Text);
                valor = valor * double.Parse(txtJurosBaixa.Text) / 100;
                txtValorDescJurosBaixa.Text = valor.ToString("F2");
                txtValorPagoBaixa.Text = (double.Parse(txtValorBaixa.Text) + valor).ToString();
                txtValorPagoBaixa.Text = double.Parse(txtValorPagoBaixa.Text).ToString("F2");
                txtJurosBaixa.Text = double.Parse(txtJurosBaixa.Text).ToString("F2");
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.Text = "";
        }

        private void txtDescontoBaixa_Enter(object sender, EventArgs e)
        {
            txtDescontoBaixa.Text = "";
        }

        private void txtJurosBaixa_Enter(object sender, EventArgs e)
        {
            txtJurosBaixa.Text = "";
        }

        private void txtValorPagoBaixa_Leave(object sender, EventArgs e)
        {
            double diferenca;
            double percentual;
            double valorAPAgar = double.Parse(txtValorBaixa.Text);
            double valorPago = double.Parse(txtValorPagoBaixa.Text);
            if (valorPago < valorAPAgar)
            {
                diferenca = valorAPAgar - valorPago;
                percentual = diferenca * 100 / valorAPAgar;
                txtDescontoBaixa.Text = percentual.ToString("F2");
            }
            else if (valorPago > valorAPAgar)
            {
                diferenca = valorPago - valorAPAgar;
                percentual = diferenca * 100 / valorAPAgar;
                txtJurosBaixa.Text = percentual.ToString("F2");
            }
            txtValorPagoBaixa.Text = double.Parse(txtValorPagoBaixa.Text).ToString("F2");
        }

        private void LimparBaixa()
        {
            txtDocumentoBaixa.Text = "";
            mskVencimentoBaixa.Text = "";
            txtValorBaixa.Text = "0.00";
            txtDescontoBaixa.Text = "0.00";
            txtJurosBaixa.Text = "0.00";
            txtValorDescJurosBaixa.Text = "0.00";
            txtValorPagoBaixa.Text = "0.00";
            mskDataPagamentoBaixa.Text = "";
            txtObsPagamentoBaixa.Text = "";
            lblIdParcela.Text = "identificador";
        }

        private void cmdBaixar_Click(object sender, EventArgs e)
        {
            if (lblIdParcela.Text.Equals("identificador"))
            {
                MessageBox.Show("Selecione a mensalidade", "Mensagem");
                return;
            }
            if (mskDataPagamentoBaixa.Text == "  /  /")
            {
                MessageBox.Show("Informe a data de pagamento.", "Mensagem");
                return;
            }
            bool gravou = false;
            PagamentoDAL pDAL = new PagamentoDAL();
            try
            {
                Pagamento p = new Pagamento()
                {
                    Documento = long.Parse(txtDocumentoBaixa.Text),
                    DataVencimento = DateTime.Parse(mskVencimentoBaixa.Text),
                    Valor = double.Parse(txtValorBaixa.Text),
                    Desconto = double.Parse(txtDescontoBaixa.Text),
                    Juros = double.Parse(txtJurosBaixa.Text),
                    ValorDescJuros = double.Parse(txtValorDescJurosBaixa.Text),
                    ValorPago = double.Parse(txtValorPagoBaixa.Text),
                    DataPagamento = DateTime.Parse(mskDataPagamentoBaixa.Text),
                    ObsPagamento = txtObsPagamentoBaixa.Text,
                    IdSocio = int.Parse(lblIdSocio.Text),
                    IdReceita = int.Parse(lblIdParcela.Text)
                };
                gravou = pDAL.InsertPagamento(p);
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                gravou = false;
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados", 2, exception);
                frmErro.ShowDialog();
            }
            if (gravou)
            {
                try
                {
                    gravou = pDAL.UpdateReceita(long.Parse(lblIdParcela.Text));
                    frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                    frmSucesso.ShowDialog();
                    PopulaLista();
                    PopulaListaPagos();
                    LimparBaixa();
                }
                catch (SystemException ex)
                {
                    string exception = ex.Message.ToString();
                    gravou = false;
                    frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados", 2, exception);
                    frmErro.ShowDialog();
                }
            }
        }

        private void cmdLimparBaixa_Click(object sender, EventArgs e)
        {
            LimparBaixa();
        }

        private void cmdPesquisaFatura_Click(object sender, EventArgs e)
        {
            BuscaReceitaAberta(txtDocumento.Text, 1);
        }

        private void BuscaReceitaAberta(string documento, int tipo)
        {
            Receita r;
            ReceitaDAL rDAL = new ReceitaDAL();
            r = rDAL.RetornaReceitaByDocumento(long.Parse(lblIdSocio.Text), long.Parse(documento));
            if (r == null)
            {
                MessageBox.Show("Parcela não existe ou está quitada.", "Mensagem");
            }
            else
            {
                CarregaReceita(r, tipo);
            }
        }

        private void CarregaReceita(Receita r, int tipo)
        {
            if (tipo == 1)
            {
                txtValor.Text = r.Valor.ToString("F2");
                mskDataVencimento.Text = r.DataVencimento.ToString();
                txtObs.Text = r.Obs;
                if (r.Parcela > 1)
                {
                    txtParcela.Text = r.Parcela.ToString();
                    ckbGerarParcelas.Checked = true;
                }
                if (r.DiaVencimento > 0)
                {
                    txtDiaVencimento.Text = r.DiaVencimento.ToString();
                }
            }
            else
            {
                txtValorBaixa.Text = r.Valor.ToString("F2");
                txtValorPagoBaixa.Text = r.Valor.ToString("F2");
                mskVencimentoBaixa.Text = r.DataVencimento.ToString();
                lblIdParcela.Text = r.Id.ToString();
            }
        }

        private void cmdPesquisaReceitaBaixa_Click(object sender, EventArgs e)
        {
            if (lblIdSocio.Text.Equals("idSocio"))
            {
                MessageBox.Show("Selecione o sócio.", "Mensagem");
                return;
            }
            else
            {
                frmTDM_PesquisaFatura frm = new frmTDM_PesquisaFatura(lblIdSocio.Text);
                frm.ShowDialog();
            }
            //BuscaReceitaAberta(txtDocumentoBaixa.Text, 2);
        }
    }
}
