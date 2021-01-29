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
                InserirReceita();
                PopulaLista();
            }
            else
            {
                //AtualizarReceita();
            }
        }

        private void InserirReceita()
        {
            bool gravou = false;
            ReceitaDAL rDal = new ReceitaDAL();
            try
            {
                Receita r = new Receita
                {
                    Documento = long.Parse(txtDocumento.Text),
                    Parcela = int.Parse(txtParcela.Text),
                    DataVencimento = DateTime.Parse(mskDataVencimento.Text),
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

        private void LimpezaParcial()
        {
            mskDataVencimento.Text = "";
            txtDiaVencimento.Text = "0";
            txtValor.Text = "";
            txtParcela.Text = "1";
            txtDocumento.Text = "";
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
            catch(SystemException ex)
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
            txtValor.Text = double.Parse(txtValor.Text).ToString("F2");
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
            string NrDocumento = "";
            string titulo = txtTitulo.Text;
            string ano = mskDataVencimento.Text.Substring(6, 4);
            string mes = mskDataVencimento.Text.Substring(3, 2);
            string dia = "";
            string parcela = "";

            if (txtDiaVencimento.Text.Trim() != "" && txtDiaVencimento.Text != "0")
            {
                dia = txtDiaVencimento.Text;
            }
            else
            {
                dia = mskDataVencimento.Text.Substring(0, 2);
            }

            if (txtParcela.Text.Trim() != "" && txtParcela.Text != "1")
            {
                parcela = txtParcela.Text;
            }
            else
            {
                parcela = "1";
            }

            NrDocumento = titulo + ano + mes + parcela;
            return NrDocumento;
        }

        private void txtParcela_Leave(object sender, EventArgs e)
        {
            txtDocumento.Text = GeraNumeroDocumento();
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
    }
}
