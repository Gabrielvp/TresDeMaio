
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstMensalidde = new System.Windows.Forms.ListView();
            this.mes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atraso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPesquisaFatura = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.cmdPesquisaSocio = new System.Windows.Forms.Button();
            this.tbLancamentos.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tbLancamentos.Size = new System.Drawing.Size(754, 361);
            this.tbLancamentos.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lstMensalidde);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmdPesquisaFatura);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lançamento";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(111, 99);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Parcelas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mensalidades";
            // 
            // lstMensalidde
            // 
            this.lstMensalidde.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mes,
            this.valor,
            this.atraso,
            this.numero});
            this.lstMensalidde.FullRowSelect = true;
            this.lstMensalidde.GridLines = true;
            this.lstMensalidde.HideSelection = false;
            this.lstMensalidde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstMensalidde.Location = new System.Drawing.Point(368, 43);
            this.lstMensalidde.Name = "lstMensalidde";
            this.lstMensalidde.Size = new System.Drawing.Size(351, 225);
            this.lstMensalidde.TabIndex = 48;
            this.lstMensalidde.UseCompatibleStateImageBehavior = false;
            this.lstMensalidde.View = System.Windows.Forms.View.Details;
            // 
            // mes
            // 
            this.mes.Text = "Vencimento";
            this.mes.Width = 100;
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
            // numero
            // 
            this.numero.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Observação";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 164);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 104);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(24, 99);
            this.maskedTextBox1.Mask = "99/99/9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vencimento";
            // 
            // cmdPesquisaFatura
            // 
            this.cmdPesquisaFatura.Location = new System.Drawing.Point(136, 47);
            this.cmdPesquisaFatura.Name = "cmdPesquisaFatura";
            this.cmdPesquisaFatura.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaFatura.TabIndex = 2;
            this.cmdPesquisaFatura.Text = "P...";
            this.cmdPesquisaFatura.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(78, 45);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(143, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // cmdPesquisaSocio
            // 
            this.cmdPesquisaSocio.Location = new System.Drawing.Point(224, 44);
            this.cmdPesquisaSocio.Name = "cmdPesquisaSocio";
            this.cmdPesquisaSocio.Size = new System.Drawing.Size(32, 23);
            this.cmdPesquisaSocio.TabIndex = 2;
            this.cmdPesquisaSocio.Text = "P...";
            this.cmdPesquisaSocio.UseVisualStyleBackColor = true;
            this.cmdPesquisaSocio.Click += new System.EventHandler(this.cmdPesquisaSocio_Click);
            // 
            // frmTDM_Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 440);
            this.Controls.Add(this.cmdPesquisaSocio);
            this.Controls.Add(this.txtCpf);
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
            this.tbLancamentos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstMensalidde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPesquisaFatura;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button cmdPesquisaSocio;
        private System.Windows.Forms.ColumnHeader mes;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader atraso;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
    }
}