using System;
using System.Windows.Forms;

namespace Teste.Forms
{
    public partial class frmTDM_Report : Form
    {
        public frmTDM_Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tresdemaio_dbDataSet1.socio'. Você pode movê-la ou removê-la conforme necessário.
            this.socioTableAdapter1.Fill(this.tresdemaio_dbDataSet1.socio);
            // TODO: esta linha de código carrega dados na tabela 'tresdemaio_dbDataSet1.SocioPorNome'. Você pode movê-la ou removê-la conforme necessário.
            this.socioPorNomeTableAdapter.Fill(this.tresdemaio_dbDataSet1.SocioPorNome);
            this.reportViewer1.RefreshReport();            
        }
    }
}
