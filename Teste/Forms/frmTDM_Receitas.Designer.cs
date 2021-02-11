
namespace Teste.Forms
{
    partial class frmTDM_Receitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDM_Receitas));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbLancamentos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMensalidades = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstMensaliddes = new System.Windows.Forms.ListView();
            this.vencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atraso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.documento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.mskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPesquisaFatura = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlParcelas = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaVencimento = new System.Windows.Forms.TextBox();
            this.ckbGerarParcelas = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPagamentos = new System.Windows.Forms.Label();
            this.cmdLimparBaixa = new System.Windows.Forms.Button();
            this.cmdBaixar = new System.Windows.Forms.Button();
            this.txtObsPagamentoBaixa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblIdParcela = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lstUltPagamento = new System.Windows.Forms.ListView();
            this.pagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.venc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.juros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorDescJuros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obsPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mskDataPagamentoBaixa = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorDescJurosBaixa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtJurosBaixa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescontoBaixa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorPagoBaixa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorBaixa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskVencimentoBaixa = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdPesquisaReceitaBaixa = new System.Windows.Forms.Button();
            this.txtDocumentoBaixa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPesquisaSocio = new System.Windows.Forms.Button();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbLancamentos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlParcelas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(281, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(163, 31);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "NomeSocio";
            this.lblNome.Visible = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(78, 13);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 22);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 16);
            this.label22.TabIndex = 35;
            this.label22.Text = "Título";
            // 
            // tbLancamentos
            // 
            this.tbLancamentos.Controls.Add(this.tabPage1);
            this.tbLancamentos.Controls.Add(this.tabPage2);
            this.tbLancamentos.Location = new System.Drawing.Point(12, 78);
            this.tbLancamentos.Name = "tbLancamentos";
            this.tbLancamentos.SelectedIndex = 0;
            this.tbLancamentos.Size = new System.Drawing.Size(754, 359);
            this.tbLancamentos.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblMensalidades);
            this.tabPage1.Controls.Add(this.cmdExcluir);
            this.tabPage1.Controls.Add(this.cmdLimpar);
            this.tabPage1.Controls.Add(this.cmdGravar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lstMensaliddes);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtObs);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.mskDataVencimento);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmdPesquisaFatura);
            this.tabPage1.Controls.Add(this.txtDocumento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pnlParcelas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lançamento";
            // 
            // lblMensalidades
            // 
            this.lblMensalidades.AutoSize = true;
            this.lblMensalidades.Location = new System.Drawing.Point(354, 273);
            this.lblMensalidades.Name = "lblMensalidades";
            this.lblMensalidades.Size = new System.Drawing.Size(13, 13);
            this.lblMensalidades.TabIndex = 52;
            this.lblMensalidades.Text = "0";
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcluir.Location = new System.Drawing.Point(653, 287);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(75, 23);
            this.cmdExcluir.TabIndex = 51;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(252, 287);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 8;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(168, 287);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(75, 23);
            this.cmdGravar.TabIndex = 7;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mensalidades";
            // 
            // lstMensaliddes
            // 
            this.lstMensaliddes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vencimento,
            this.valor,
            this.atraso,
            this.documento,
            this.parcela,
            this.diaVencimento,
            this.obs,
            this.Id});
            this.lstMensaliddes.FullRowSelect = true;
            this.lstMensaliddes.GridLines = true;
            this.lstMensaliddes.HideSelection = false;
            this.lstMensaliddes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstMensaliddes.Location = new System.Drawing.Point(353, 43);
            this.lstMensaliddes.Name = "lstMensaliddes";
            this.lstMensaliddes.Size = new System.Drawing.Size(375, 225);
            this.lstMensaliddes.TabIndex = 48;
            this.lstMensaliddes.UseCompatibleStateImageBehavior = false;
            this.lstMensaliddes.View = System.Windows.Forms.View.Details;
            this.lstMensaliddes.DoubleClick += new System.EventHandler(this.lstMensaliddes_DoubleClick);
            // 
            // vencimento
            // 
            this.vencimento.Text = "Vencimento";
            this.vencimento.Width = 100;
            // 
            // valor
            // 
            this.valor.Text = "Valor R$";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor.Width = 100;
            // 
            // atraso
            // 
            this.atraso.Text = "Atraso";
            this.atraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // documento
            // 
            this.documento.Text = "Documento";
            this.documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.documento.Width = 105;
            // 
            // parcela
            // 
            this.parcela.Text = "Parcela";
            this.parcela.Width = 0;
            // 
            // diaVencimento
            // 
            this.diaVencimento.Text = "Dia Vencimento";
            this.diaVencimento.Width = 0;
            // 
            // obs
            // 
            this.obs.Text = "obs";
            this.obs.Width = 0;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(28, 163);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(311, 104);
            this.txtObs.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(180, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // mskDataVencimento
            // 
            this.mskDataVencimento.Location = new System.Drawing.Point(265, 67);
            this.mskDataVencimento.Mask = "99/99/9999";
            this.mskDataVencimento.Name = "mskDataVencimento";
            this.mskDataVencimento.Size = new System.Drawing.Size(73, 20);
            this.mskDataVencimento.TabIndex = 1;
            this.mskDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDataVencimento.Leave += new System.EventHandler(this.mskDataVencimento_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vencimento";
            // 
            // cmdPesquisaFatura
            // 
            this.cmdPesquisaFatura.Location = new System.Drawing.Point(305, 109);
            this.cmdPesquisaFatura.Name = "cmdPesquisaFatura";
            this.cmdPesquisaFatura.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaFatura.TabIndex = 5;
            this.cmdPesquisaFatura.Text = "P...";
            this.cmdPesquisaFatura.UseVisualStyleBackColor = true;
            this.cmdPesquisaFatura.Click += new System.EventHandler(this.cmdPesquisaFatura_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(179, 111);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(122, 20);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento";
            // 
            // pnlParcelas
            // 
            this.pnlParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParcelas.Controls.Add(this.label8);
            this.pnlParcelas.Controls.Add(this.txtParcela);
            this.pnlParcelas.Controls.Add(this.label7);
            this.pnlParcelas.Controls.Add(this.txtDiaVencimento);
            this.pnlParcelas.Controls.Add(this.ckbGerarParcelas);
            this.pnlParcelas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlParcelas.Location = new System.Drawing.Point(28, 52);
            this.pnlParcelas.Name = "pnlParcelas";
            this.pnlParcelas.Size = new System.Drawing.Size(144, 82);
            this.pnlParcelas.TabIndex = 50;
            this.pnlParcelas.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dia";
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(16, 49);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(45, 20);
            this.txtParcela.TabIndex = 3;
            this.txtParcela.Text = "1";
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Parcelas";
            // 
            // txtDiaVencimento
            // 
            this.txtDiaVencimento.Enabled = false;
            this.txtDiaVencimento.Location = new System.Drawing.Point(86, 49);
            this.txtDiaVencimento.Name = "txtDiaVencimento";
            this.txtDiaVencimento.Size = new System.Drawing.Size(35, 20);
            this.txtDiaVencimento.TabIndex = 4;
            this.txtDiaVencimento.Text = "0";
            this.txtDiaVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbGerarParcelas
            // 
            this.ckbGerarParcelas.AutoSize = true;
            this.ckbGerarParcelas.Location = new System.Drawing.Point(12, 7);
            this.ckbGerarParcelas.Name = "ckbGerarParcelas";
            this.ckbGerarParcelas.Size = new System.Drawing.Size(95, 17);
            this.ckbGerarParcelas.TabIndex = 2;
            this.ckbGerarParcelas.Text = "Gerar parcelas";
            this.ckbGerarParcelas.UseVisualStyleBackColor = true;
            this.ckbGerarParcelas.CheckedChanged += new System.EventHandler(this.ckbGerarParcelas_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblPagamentos);
            this.tabPage2.Controls.Add(this.cmdLimparBaixa);
            this.tabPage2.Controls.Add(this.cmdBaixar);
            this.tabPage2.Controls.Add(this.txtObsPagamentoBaixa);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.lblIdParcela);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.lstUltPagamento);
            this.tabPage2.Controls.Add(this.mskDataPagamentoBaixa);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtValorDescJurosBaixa);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtJurosBaixa);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtDescontoBaixa);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtValorPagoBaixa);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtValorBaixa);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.mskVencimentoBaixa);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmdPesquisaReceitaBaixa);
            this.tabPage2.Controls.Add(this.txtDocumentoBaixa);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baixa";
            // 
            // lblPagamentos
            // 
            this.lblPagamentos.AutoSize = true;
            this.lblPagamentos.Location = new System.Drawing.Point(336, 278);
            this.lblPagamentos.Name = "lblPagamentos";
            this.lblPagamentos.Size = new System.Drawing.Size(13, 13);
            this.lblPagamentos.TabIndex = 64;
            this.lblPagamentos.Text = "0";
            // 
            // cmdLimparBaixa
            // 
            this.cmdLimparBaixa.Location = new System.Drawing.Point(416, 302);
            this.cmdLimparBaixa.Name = "cmdLimparBaixa";
            this.cmdLimparBaixa.Size = new System.Drawing.Size(75, 23);
            this.cmdLimparBaixa.TabIndex = 63;
            this.cmdLimparBaixa.Text = "Limpar";
            this.cmdLimparBaixa.UseVisualStyleBackColor = true;
            this.cmdLimparBaixa.Click += new System.EventHandler(this.cmdLimparBaixa_Click);
            // 
            // cmdBaixar
            // 
            this.cmdBaixar.Location = new System.Drawing.Point(335, 302);
            this.cmdBaixar.Name = "cmdBaixar";
            this.cmdBaixar.Size = new System.Drawing.Size(75, 23);
            this.cmdBaixar.TabIndex = 62;
            this.cmdBaixar.Text = "Baixar";
            this.cmdBaixar.UseVisualStyleBackColor = true;
            this.cmdBaixar.Click += new System.EventHandler(this.cmdBaixar_Click);
            // 
            // txtObsPagamentoBaixa
            // 
            this.txtObsPagamentoBaixa.Location = new System.Drawing.Point(29, 256);
            this.txtObsPagamentoBaixa.Multiline = true;
            this.txtObsPagamentoBaixa.Name = "txtObsPagamentoBaixa";
            this.txtObsPagamentoBaixa.Size = new System.Drawing.Size(252, 46);
            this.txtObsPagamentoBaixa.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Obs. pagamento";
            // 
            // lblIdParcela
            // 
            this.lblIdParcela.AutoSize = true;
            this.lblIdParcela.Location = new System.Drawing.Point(30, 312);
            this.lblIdParcela.Name = "lblIdParcela";
            this.lblIdParcela.Size = new System.Drawing.Size(64, 13);
            this.lblIdParcela.TabIndex = 59;
            this.lblIdParcela.Text = "identificador";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(332, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Últimos pagamentos";
            // 
            // lstUltPagamento
            // 
            this.lstUltPagamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pagamento,
            this.valorr,
            this.valorPago,
            this.doc,
            this.venc,
            this.desconto,
            this.juros,
            this.valorDescJuros,
            this.obsPag});
            this.lstUltPagamento.FullRowSelect = true;
            this.lstUltPagamento.GridLines = true;
            this.lstUltPagamento.HideSelection = false;
            this.lstUltPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstUltPagamento.Location = new System.Drawing.Point(335, 51);
            this.lstUltPagamento.Name = "lstUltPagamento";
            this.lstUltPagamento.Size = new System.Drawing.Size(375, 225);
            this.lstUltPagamento.TabIndex = 57;
            this.lstUltPagamento.UseCompatibleStateImageBehavior = false;
            this.lstUltPagamento.View = System.Windows.Forms.View.Details;
            // 
            // pagamento
            // 
            this.pagamento.Text = "Pagamento";
            this.pagamento.Width = 100;
            // 
            // valorr
            // 
            this.valorr.Text = "Valor R$";
            this.valorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorr.Width = 80;
            // 
            // valorPago
            // 
            this.valorPago.Text = "Valor pago";
            this.valorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorPago.Width = 80;
            // 
            // doc
            // 
            this.doc.Text = "Documento";
            this.doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.doc.Width = 105;
            // 
            // venc
            // 
            this.venc.Text = "Vencimento";
            this.venc.Width = 0;
            // 
            // desconto
            // 
            this.desconto.Text = "Desconto";
            // 
            // juros
            // 
            this.juros.Text = "Juros";
            // 
            // valorDescJuros
            // 
            this.valorDescJuros.Text = "Valor desc/juros";
            // 
            // obsPag
            // 
            this.obsPag.Text = "Obs";
            // 
            // mskDataPagamentoBaixa
            // 
            this.mskDataPagamentoBaixa.Location = new System.Drawing.Point(36, 214);
            this.mskDataPagamentoBaixa.Mask = "99/99/9999";
            this.mskDataPagamentoBaixa.Name = "mskDataPagamentoBaixa";
            this.mskDataPagamentoBaixa.Size = new System.Drawing.Size(73, 20);
            this.mskDataPagamentoBaixa.TabIndex = 8;
            this.mskDataPagamentoBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Pagamento";
            // 
            // txtValorDescJurosBaixa
            // 
            this.txtValorDescJurosBaixa.Location = new System.Drawing.Point(34, 167);
            this.txtValorDescJurosBaixa.Name = "txtValorDescJurosBaixa";
            this.txtValorDescJurosBaixa.Size = new System.Drawing.Size(73, 20);
            this.txtValorDescJurosBaixa.TabIndex = 6;
            this.txtValorDescJurosBaixa.Text = "0,00";
            this.txtValorDescJurosBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "R$ Desc/Juros";
            // 
            // txtJurosBaixa
            // 
            this.txtJurosBaixa.Location = new System.Drawing.Point(119, 124);
            this.txtJurosBaixa.Name = "txtJurosBaixa";
            this.txtJurosBaixa.Size = new System.Drawing.Size(73, 20);
            this.txtJurosBaixa.TabIndex = 5;
            this.txtJurosBaixa.Text = "0,00";
            this.txtJurosBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJurosBaixa.Enter += new System.EventHandler(this.txtJurosBaixa_Enter);
            this.txtJurosBaixa.Leave += new System.EventHandler(this.txtJurosBaixa_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Juros";
            // 
            // txtDescontoBaixa
            // 
            this.txtDescontoBaixa.Location = new System.Drawing.Point(34, 123);
            this.txtDescontoBaixa.Name = "txtDescontoBaixa";
            this.txtDescontoBaixa.Size = new System.Drawing.Size(73, 20);
            this.txtDescontoBaixa.TabIndex = 4;
            this.txtDescontoBaixa.Text = "0,00";
            this.txtDescontoBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoBaixa.Enter += new System.EventHandler(this.txtDescontoBaixa_Enter);
            this.txtDescontoBaixa.Leave += new System.EventHandler(this.txtDescontoBaixa_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Desconto";
            // 
            // txtValorPagoBaixa
            // 
            this.txtValorPagoBaixa.Location = new System.Drawing.Point(119, 168);
            this.txtValorPagoBaixa.Name = "txtValorPagoBaixa";
            this.txtValorPagoBaixa.Size = new System.Drawing.Size(73, 20);
            this.txtValorPagoBaixa.TabIndex = 7;
            this.txtValorPagoBaixa.Text = "0,00";
            this.txtValorPagoBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPagoBaixa.Leave += new System.EventHandler(this.txtValorPagoBaixa_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Valor pago";
            // 
            // txtValorBaixa
            // 
            this.txtValorBaixa.Location = new System.Drawing.Point(119, 76);
            this.txtValorBaixa.Name = "txtValorBaixa";
            this.txtValorBaixa.Size = new System.Drawing.Size(73, 20);
            this.txtValorBaixa.TabIndex = 3;
            this.txtValorBaixa.Text = "0,00";
            this.txtValorBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Valor";
            // 
            // mskVencimentoBaixa
            // 
            this.mskVencimentoBaixa.Location = new System.Drawing.Point(34, 76);
            this.mskVencimentoBaixa.Mask = "99/99/9999";
            this.mskVencimentoBaixa.Name = "mskVencimentoBaixa";
            this.mskVencimentoBaixa.Size = new System.Drawing.Size(73, 20);
            this.mskVencimentoBaixa.TabIndex = 2;
            this.mskVencimentoBaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Vencimento";
            // 
            // cmdPesquisaReceitaBaixa
            // 
            this.cmdPesquisaReceitaBaixa.Location = new System.Drawing.Point(160, 30);
            this.cmdPesquisaReceitaBaixa.Name = "cmdPesquisaReceitaBaixa";
            this.cmdPesquisaReceitaBaixa.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaReceitaBaixa.TabIndex = 1;
            this.cmdPesquisaReceitaBaixa.Text = "P...";
            this.cmdPesquisaReceitaBaixa.UseVisualStyleBackColor = true;
            this.cmdPesquisaReceitaBaixa.Click += new System.EventHandler(this.cmdPesquisaReceitaBaixa_Click);
            // 
            // txtDocumentoBaixa
            // 
            this.txtDocumentoBaixa.Location = new System.Drawing.Point(34, 32);
            this.txtDocumentoBaixa.Name = "txtDocumentoBaixa";
            this.txtDocumentoBaixa.Size = new System.Drawing.Size(122, 20);
            this.txtDocumentoBaixa.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "CPF";
            // 
            // cmdPesquisaSocio
            // 
            this.cmdPesquisaSocio.Location = new System.Drawing.Point(177, 44);
            this.cmdPesquisaSocio.Name = "cmdPesquisaSocio";
            this.cmdPesquisaSocio.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaSocio.TabIndex = 2;
            this.cmdPesquisaSocio.Text = "P...";
            this.cmdPesquisaSocio.UseVisualStyleBackColor = true;
            this.cmdPesquisaSocio.Click += new System.EventHandler(this.cmdPesquisaSocio_Click);
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.Location = new System.Drawing.Point(284, 49);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(42, 13);
            this.lblIdSocio.TabIndex = 39;
            this.lblIdSocio.Text = "idSocio";
            this.lblIdSocio.Visible = false;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(78, 46);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(92, 20);
            this.mskCpf.TabIndex = 1;
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // frmTDM_Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 445);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblIdSocio);
            this.Controls.Add(this.cmdPesquisaSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLancamentos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTDM_Receitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTDM_Receitas_KeyDown);
            this.tbLancamentos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlParcelas.ResumeLayout(false);
            this.pnlParcelas.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabControl tbLancamentos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstMensaliddes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.MaskedTextBox mskDataVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPesquisaFatura;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPesquisaSocio;
        private System.Windows.Forms.ColumnHeader vencimento;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader atraso;
        private System.Windows.Forms.ColumnHeader documento;
        private System.Windows.Forms.TextBox txtDiaVencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.ColumnHeader parcela;
        private System.Windows.Forms.ColumnHeader diaVencimento;
        private System.Windows.Forms.ColumnHeader obs;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Panel pnlParcelas;
        private System.Windows.Forms.CheckBox ckbGerarParcelas;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdPesquisaReceitaBaixa;
        private System.Windows.Forms.TextBox txtDocumentoBaixa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJurosBaixa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescontoBaixa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorPagoBaixa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorBaixa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskVencimentoBaixa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView lstUltPagamento;
        private System.Windows.Forms.ColumnHeader pagamento;
        private System.Windows.Forms.ColumnHeader valorr;
        private System.Windows.Forms.ColumnHeader valorPago;
        private System.Windows.Forms.ColumnHeader doc;
        private System.Windows.Forms.MaskedTextBox mskDataPagamentoBaixa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorDescJurosBaixa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIdParcela;
        private System.Windows.Forms.TextBox txtObsPagamentoBaixa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button cmdLimparBaixa;
        private System.Windows.Forms.Button cmdBaixar;
        private System.Windows.Forms.ColumnHeader venc;
        private System.Windows.Forms.ColumnHeader desconto;
        private System.Windows.Forms.ColumnHeader juros;
        private System.Windows.Forms.ColumnHeader valorDescJuros;
        private System.Windows.Forms.ColumnHeader obsPag;
        private System.Windows.Forms.Label lblMensalidades;
        private System.Windows.Forms.Label lblPagamentos;
    }
}