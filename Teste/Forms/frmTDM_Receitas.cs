using System;
using System.Windows.Forms;
using Teste.DAL;
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
            txtCpf.Text = s.Cpf;
            lblNome.Text = s.Nome;
            lblNome.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTDM_PesquisaSocio frm = new frmTDM_PesquisaSocio();
            frm.ReferenciaForm = this;
            frm.ShowDialog();
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if(txtTitulo.Text.Trim() != "")
            {
                BuscaSocioByTitulo(txtTitulo.Text);
            }            
        }
    }
}
