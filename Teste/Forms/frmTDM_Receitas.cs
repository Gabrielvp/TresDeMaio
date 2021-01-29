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
            txtTitulo.Focus();
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
            if (txtValor.Text != "")
            {
                txtValor.Text = double.Parse(txtValor.Text).ToString("F2");
            }
        }

        private void PopulaLista()
        {
            lstMensaliddes.Items.Clear();
            int atraso = 0;
            ReceitaDAL rDal = new ReceitaDAL();
            List<Receita> list = rDal.RetornaReceitaBySocio(int.Parse(lblIdSocio.Text));
            foreach (Receita r in list)
            {
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

            if(lstMensaliddes.SelectedItems.Count == 0)
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
    }
}
