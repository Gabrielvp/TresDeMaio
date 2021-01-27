
namespace Teste.Forms
{
    partial class frmTDM_PesquisaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDM_PesquisaSocio));
            this.lstSocios = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdPesquisaFatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSocios
            // 
            this.lstSocios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Nome});
            this.lstSocios.FullRowSelect = true;
            this.lstSocios.GridLines = true;
            this.lstSocios.HideSelection = false;
            this.lstSocios.Location = new System.Drawing.Point(12, 83);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(269, 238);
            this.lstSocios.TabIndex = 0;
            this.lstSocios.UseCompatibleStateImageBehavior = false;
            this.lstSocios.View = System.Windows.Forms.View.Details;
            this.lstSocios.DoubleClick += new System.EventHandler(this.lstSocios_DoubleClick);
            // 
            // Titulo
            // 
            this.Titulo.Text = "Título";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cmdPesquisaFatura
            // 
            this.cmdPesquisaFatura.Location = new System.Drawing.Point(249, 38);
            this.cmdPesquisaFatura.Name = "cmdPesquisaFatura";
            this.cmdPesquisaFatura.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaFatura.TabIndex = 42;
            this.cmdPesquisaFatura.Text = "P...";
            this.cmdPesquisaFatura.UseVisualStyleBackColor = true;
            this.cmdPesquisaFatura.Click += new System.EventHandler(this.cmdPesquisaFatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // frmTDM_PesquisaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPesquisaFatura);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lstSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTDM_PesquisaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Sócio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSocios;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdPesquisaFatura;
        private System.Windows.Forms.Label label1;
    }
}