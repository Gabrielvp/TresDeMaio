﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPesquisaSocio = new System.Windows.Forms.Button();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.tbLancamentos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlParcelas.SuspendLayout();
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
            this.txtValor.Location = new System.Drawing.Point(28, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // mskDataVencimento
            // 
            this.mskDataVencimento.Location = new System.Drawing.Point(116, 67);
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
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vencimento";
            // 
            // cmdPesquisaFatura
            // 
            this.cmdPesquisaFatura.Location = new System.Drawing.Point(155, 109);
            this.cmdPesquisaFatura.Name = "cmdPesquisaFatura";
            this.cmdPesquisaFatura.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaFatura.TabIndex = 5;
            this.cmdPesquisaFatura.Text = "P...";
            this.cmdPesquisaFatura.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(27, 111);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(122, 20);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
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
            this.pnlParcelas.Location = new System.Drawing.Point(195, 58);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baixa";
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
    }
}