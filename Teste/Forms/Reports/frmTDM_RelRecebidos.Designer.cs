
namespace Teste.Forms.Reports
{
    partial class frmTDM_RelRecebidos
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
            this.cmdPesquisaSocio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDtVencimento = new System.Windows.Forms.RadioButton();
            this.rbtnDtPagamento = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFim = new System.Windows.Forms.MaskedTextBox();
            this.mskInicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPesquisaSocio
            // 
            this.cmdPesquisaSocio.Location = new System.Drawing.Point(282, 87);
            this.cmdPesquisaSocio.Name = "cmdPesquisaSocio";
            this.cmdPesquisaSocio.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaSocio.TabIndex = 18;
            this.cmdPesquisaSocio.Text = "P...";
            this.cmdPesquisaSocio.UseVisualStyleBackColor = true;
            this.cmdPesquisaSocio.Click += new System.EventHandler(this.cmdPesquisaSocio_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(23, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(167, 20);
            this.txtTitulo.TabIndex = 15;
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave_1);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(242, 253);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 22;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click_1);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(152, 253);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisar.TabIndex = 20;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDtVencimento);
            this.groupBox1.Controls.Add(this.rbtnDtPagamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskFim);
            this.groupBox1.Controls.Add(this.mskInicio);
            this.groupBox1.Location = new System.Drawing.Point(23, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 118);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // rbtnDtVencimento
            // 
            this.rbtnDtVencimento.AutoSize = true;
            this.rbtnDtVencimento.Location = new System.Drawing.Point(145, 32);
            this.rbtnDtVencimento.Name = "rbtnDtVencimento";
            this.rbtnDtVencimento.Size = new System.Drawing.Size(98, 17);
            this.rbtnDtVencimento.TabIndex = 6;
            this.rbtnDtVencimento.Text = "Dt. Vencimento";
            this.rbtnDtVencimento.UseVisualStyleBackColor = true;
            // 
            // rbtnDtPagamento
            // 
            this.rbtnDtPagamento.AutoSize = true;
            this.rbtnDtPagamento.Checked = true;
            this.rbtnDtPagamento.Location = new System.Drawing.Point(37, 32);
            this.rbtnDtPagamento.Name = "rbtnDtPagamento";
            this.rbtnDtPagamento.Size = new System.Drawing.Size(96, 17);
            this.rbtnDtPagamento.TabIndex = 5;
            this.rbtnDtPagamento.TabStop = true;
            this.rbtnDtPagamento.Text = "Dt. Pagamento";
            this.rbtnDtPagamento.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Início";
            // 
            // mskFim
            // 
            this.mskFim.Location = new System.Drawing.Point(145, 82);
            this.mskFim.Mask = "99/99/9999";
            this.mskFim.Name = "mskFim";
            this.mskFim.Size = new System.Drawing.Size(73, 20);
            this.mskFim.TabIndex = 4;
            // 
            // mskInicio
            // 
            this.mskInicio.Location = new System.Drawing.Point(35, 82);
            this.mskInicio.Mask = "99/99/9999";
            this.mskInicio.Name = "mskInicio";
            this.mskInicio.Size = new System.Drawing.Size(73, 20);
            this.mskInicio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 17;
            // 
            // frmTDM_RelRecebidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 295);
            this.Controls.Add(this.cmdPesquisaSocio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTDM_RelRecebidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos recebidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPesquisaSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFim;
        private System.Windows.Forms.MaskedTextBox mskInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbtnDtVencimento;
        private System.Windows.Forms.RadioButton rbtnDtPagamento;
    }
}