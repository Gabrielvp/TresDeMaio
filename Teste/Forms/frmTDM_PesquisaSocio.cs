﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

namespace Teste.Forms
{
    public partial class frmTDM_PesquisaSocio : Form
    {
        public Form ReferenciaForm { get; set; }
        public string NomeReferencia { get; set; }

        public frmTDM_PesquisaSocio()
        {
            InitializeComponent();
        }

        public frmTDM_PesquisaSocio(string nome)
        {
            InitializeComponent();
            NomeReferencia = nome;
            if (NomeReferencia != null)
            {
                txtNome.Text = NomeReferencia;
                cmdPesquisaFatura_Click(null, null);
            }
        }

        private void cmdPesquisaFatura_Click(object sender, EventArgs e)
        {
            lstSocios.Items.Clear();
            SocioDAL sDal = new SocioDAL();
            List<Socio> list = sDal.RetornaSocioByNome(txtNome.Text);
            foreach (Socio socio in list)
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
