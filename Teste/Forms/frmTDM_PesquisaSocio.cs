using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

namespace Teste.Forms
{
    public partial class frmTDM_PesquisaSocio : Form
    {
        public Form ReferenciaForm { get; set; }        

        public frmTDM_PesquisaSocio()
        {
            InitializeComponent();            
        }

        private void cmdPesquisaFatura_Click(object sender, EventArgs e)
        {
            lstSocios.Items.Clear();
            SocioDAL sDal = new SocioDAL();
            List<Socio> list = sDal.RetornaSocioByNome(txtNome.Text);
            foreach(Socio socio in list)
            {
               PopulaLista(socio);
            }
        }

        private void PopulaLista(Socio socio)
        {
            ListViewItem item;
            item = new ListViewItem();
            item.Text = socio.Titulo.ToString();
            item.SubItems.Add(socio.Nome.ToString());            
            lstSocios.Items.Add(item);
        }

        private void lstSocios_DoubleClick(object sender, EventArgs e)
        {
            Socio s = Singleton<Socio>.Instance();
            s.Titulo = int.Parse(lstSocios.FocusedItem.Text);
            Close();
        }       
    }
}
