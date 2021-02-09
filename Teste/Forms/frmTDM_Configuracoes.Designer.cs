
namespace Teste.Forms
{
    partial class frmTDM_Configuracoes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstImportacao = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdImportar = new System.Windows.Forms.Button();
            this.cmdLer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCont);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lstImportacao);
            this.tabPage2.Controls.Add(this.cmdImportar);
            this.tabPage2.Controls.Add(this.cmdLer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Importações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(705, 18);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(13, 13);
            this.lblCont.TabIndex = 10;
            this.lblCont.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para importação dos dados, a planilha deve estar no seguinte caminho: C:\\Dados";
            // 
            // lstImportacao
            // 
            this.lstImportacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.titulo,
            this.situacao,
            this.pagamento,
            this.telefone,
            this.obs});
            this.lstImportacao.FullRowSelect = true;
            this.lstImportacao.GridLines = true;
            this.lstImportacao.HideSelection = false;
            this.lstImportacao.Location = new System.Drawing.Point(17, 55);
            this.lstImportacao.Name = "lstImportacao";
            this.lstImportacao.Size = new System.Drawing.Size(723, 497);
            this.lstImportacao.TabIndex = 8;
            this.lstImportacao.UseCompatibleStateImageBehavior = false;
            this.lstImportacao.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 200;
            // 
            // titulo
            // 
            this.titulo.Text = "Título";
            this.titulo.Width = 100;
            // 
            // situacao
            // 
            this.situacao.Text = "Situação";
            this.situacao.Width = 100;
            // 
            // pagamento
            // 
            this.pagamento.Text = "Pagamento";
            this.pagamento.Width = 80;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 80;
            // 
            // obs
            // 
            this.obs.Text = "Obs";
            this.obs.Width = 150;
            // 
            // cmdImportar
            // 
            this.cmdImportar.BackColor = System.Drawing.Color.Green;
            this.cmdImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImportar.ForeColor = System.Drawing.Color.White;
            this.cmdImportar.Location = new System.Drawing.Point(104, 18);
            this.cmdImportar.Name = "cmdImportar";
            this.cmdImportar.Size = new System.Drawing.Size(75, 23);
            this.cmdImportar.TabIndex = 7;
            this.cmdImportar.Text = "Importar";
            this.cmdImportar.UseVisualStyleBackColor = false;
            this.cmdImportar.Click += new System.EventHandler(this.cmdImportar_Click);
            // 
            // cmdLer
            // 
            this.cmdLer.BackColor = System.Drawing.Color.Green;
            this.cmdLer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLer.ForeColor = System.Drawing.Color.White;
            this.cmdLer.Location = new System.Drawing.Point(23, 18);
            this.cmdLer.Name = "cmdLer";
            this.cmdLer.Size = new System.Drawing.Size(75, 23);
            this.cmdLer.TabIndex = 6;
            this.cmdLer.Text = "Ler";
            this.cmdLer.UseVisualStyleBackColor = false;
            this.cmdLer.Click += new System.EventHandler(this.cmdLer_Click);
            // 
            // frmTDM_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 620);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTDM_Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstImportacao;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader titulo;
        private System.Windows.Forms.ColumnHeader situacao;
        private System.Windows.Forms.ColumnHeader pagamento;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader obs;
        private System.Windows.Forms.Button cmdImportar;
        private System.Windows.Forms.Button cmdLer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCont;
    }
}