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
            // TODO: esta linha de código carrega dados na tabela 'tresdemaio_dbDataSet.socio'. Você pode movê-la ou removê-la conforme necessário.
            this.socioTableAdapter.Fill(this.tresdemaio_dbDataSet.socio);
            this.reportViewer1.RefreshReport();
        }
    }
}
