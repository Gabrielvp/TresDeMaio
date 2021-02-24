
namespace Teste.Forms
{
    partial class frmTDM_PesquisaFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDM_PesquisaFatura));
            this.lstFaturas = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Atraso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDtFim = new System.Windows.Forms.MaskedTextBox();
            this.mskDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFaturas
            // 
            this.lstFaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Valor,
            this.Vencimento,
            this.Atraso,
            this.id});
            this.lstFaturas.FullRowSelect = true;
            this.lstFaturas.GridLines = true;
            this.lstFaturas.HideSelection = false;
            this.lstFaturas.Location = new System.Drawing.Point(12, 83);
            this.lstFaturas.Name = "lstFaturas";
            this.lstFaturas.Size = new System.Drawing.Size(368, 238);
            this.lstFaturas.TabIndex = 0;
            this.lstFaturas.UseCompatibleStateImageBehavior = false;
            this.lstFaturas.View = System.Windows.Forms.View.Details;
            this.lstFaturas.DoubleClick += new System.EventHandler(this.lstFaturas_DoubleClick);
            // 
            // Titulo
            // 
            this.Titulo.Text = "Documento";
            this.Titulo.Width = 100;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Valor.Width = 100;
            // 
            // Vencimento
            // 
            this.Vencimento.Text = "Vencimento";
            this.Vencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vencimento.Width = 100;
            // 
            // Atraso
            // 
            this.Atraso.Text = "Atraso";
            this.Atraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskDtFim);
            this.groupBox1.Controls.Add(this.mskDtInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vencimento";
            // 
            // cmdPesquisa
            // 
            this.cmdPesquisa.Location = new System.Drawing.Point(180, 35);
            this.cmdPesquisa.Name = "cmdPesquisa";
            this.cmdPesquisa.Size = new System.Drawing.Size(31, 23);
            this.cmdPesquisa.TabIndex = 4;
            this.cmdPesquisa.Text = "P...";
            this.cmdPesquisa.UseVisualStyleBackColor = true;
            this.cmdPesquisa.Click += new System.EventHandler(this.cmdPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Início";
            // 
            // mskDtFim
            // 
            this.mskDtFim.Location = new System.Drawing.Point(103, 37);
            this.mskDtFim.Mask = "99/99/9999";
            this.mskDtFim.Name = "mskDtFim";
            this.mskDtFim.Size = new System.Drawing.Size(66, 20);
            this.mskDtFim.TabIndex = 1;
            // 
            // mskDtInicio
            // 
            this.mskDtInicio.Location = new System.Drawing.Point(21, 37);
            this.mskDtInicio.Mask = "99/99/9999";
            this.mskDtInicio.Name = "mskDtInicio";
            this.mskDtInicio.Size = new System.Drawing.Size(67, 20);
            this.mskDtInicio.TabIndex = 0;
            // 
            // frmTDM_PesquisaFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFaturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTDM_PesquisaFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa documento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFaturas;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Vencimento;
        private System.Windows.Forms.ColumnHeader Atraso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDtFim;
        private System.Windows.Forms.MaskedTextBox mskDtInicio;
        private System.Windows.Forms.ColumnHeader id;
    }
}