using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste.DAL;
using Teste.systemException;
using Teste.Models;
using Teste.Funcoes;

namespace Teste.Forms
{
    public partial class frmTDM_PesquisaFatura : Form
    {
        public Form ReferenciaForm { get; set; }
        public long IdSocio { get; set; }

        public frmTDM_PesquisaFatura()
        {
            InitializeComponent();
            mskDtInicio.Focus();
        }

        public frmTDM_PesquisaFatura(string idSocio)
        {
            InitializeComponent();
            IdSocio = int.Parse(idSocio);
            cmdPesquisaFatura_Click(null, null);

        }

        private void cmdPesquisaFatura_Click(object sender, EventArgs e)
        {
            lstFaturas.Items.Clear();
            ReceitaDAL rDAL = new ReceitaDAL();
            List<Receita> list = rDAL.RetornaReceitaBySocio(IdSocio);
            foreach (Receita receita in list)
            {
                PopulaLista(receita);
            }
        }

        private void PopulaLista(Receita receita)
        {
            int atraso = 0;
            atraso = (DateTime.Now - receita.DataVencimento).Days;
            ListViewItem item;
            item = new ListViewItem();
            item.Text = receita.Documento.ToString();
            item.SubItems.Add(receita.Valor.ToString("F2"));
            item.SubItems.Add(receita.DataVencimento.ToString().Substring(0, 10));
            item.SubItems.Add(atraso.ToString());
            item.SubItems.Add(receita.Id.ToString("F2"));
            lstFaturas.Items.Add(item);
        }

        private void cmdPesquisa_Click(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            string dtInicio = mskDtInicio.Text;
            string dtFim = mskDtFim.Text;
            try
            {
                if (v.ValidaData(dtInicio.ToString()) == false)
                {
                    MessageBox.Show("Data inicial inválida.", "Mensagem");
                    return;
                }
                if (v.ValidaData(dtFim.ToString()) == false)
                {
                    MessageBox.Show("Data final inválida.", "Mensagem");
                    return;
                }
                Validacoes.ValidaDatas(dtInicio, dtFim);
            }
            catch (DomainException dex)
            {
                MessageBox.Show(dex.Message, "Verifique");
                return;
            }

            dtInicio = dtInicio.ToString().Substring(6, 4) + "-" + dtInicio.ToString().Substring(3, 2) + "-" + dtInicio.ToString().Substring(0, 2);
            dtFim = dtFim.ToString().Substring(6, 4) + "-" + dtFim.ToString().Substring(3, 2) + "-" + dtFim.ToString().Substring(0, 2);

            lstFaturas.Items.Clear();
            ReceitaDAL rDAL = new ReceitaDAL();
            List<Receita> list = rDAL.RetornaReceitaByPeriodo(IdSocio, dtInicio, dtFim);
            foreach (Receita receita in list)
            {
                PopulaLista(receita);
            }
        }
    }
}
