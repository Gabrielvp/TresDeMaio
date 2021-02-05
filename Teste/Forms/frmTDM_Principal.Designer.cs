
namespace Teste
{
    partial class frmTDM_Princiapal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDM_Princiapal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmdRelatorios = new System.Windows.Forms.Button();
            this.cmdReceitas = new System.Windows.Forms.Button();
            this.cmdConfiguracoes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRelatorios = new System.Windows.Forms.Panel();
            this.lblRelRecebido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRelAtrasados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRelAReceber = new System.Windows.Forms.Label();
            this.lblRelRelacaoSocios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRelatorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 58);
            this.panel1.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Warsaw", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1096, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 58);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Teste.Properties.Resources.logo3DeMaio;
            this.pictureBox2.Location = new System.Drawing.Point(19, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(91, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema 3 de Maio";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Warsaw", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1163, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 58);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.lblIdUser);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblIp);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.cmdRelatorios);
            this.panel2.Controls.Add(this.cmdReceitas);
            this.panel2.Controls.Add(this.cmdConfiguracoes);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 730);
            this.panel2.TabIndex = 7;
            // 
            // lblIdUser
            // 
            this.lblIdUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.ForeColor = System.Drawing.Color.White;
            this.lblIdUser.Location = new System.Drawing.Point(113, 686);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(35, 13);
            this.lblIdUser.TabIndex = 12;
            this.lblIdUser.Text = "label2";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(112, 709);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "label2";
            // 
            // lblIp
            // 
            this.lblIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIp.AutoSize = true;
            this.lblIp.ForeColor = System.Drawing.Color.White;
            this.lblIp.Location = new System.Drawing.Point(12, 709);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(35, 13);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "label2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 686);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "label2";
            // 
            // cmdRelatorios
            // 
            this.cmdRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdRelatorios.FlatAppearance.BorderSize = 0;
            this.cmdRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.cmdRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelatorios.ForeColor = System.Drawing.Color.White;
            this.cmdRelatorios.Image = global::Teste.Properties.Resources.icons8_documento_48_1_;
            this.cmdRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRelatorios.Location = new System.Drawing.Point(2, 366);
            this.cmdRelatorios.Name = "cmdRelatorios";
            this.cmdRelatorios.Size = new System.Drawing.Size(183, 63);
            this.cmdRelatorios.TabIndex = 3;
            this.cmdRelatorios.Text = "Relatórios";
            this.cmdRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRelatorios.UseVisualStyleBackColor = true;
            this.cmdRelatorios.Click += new System.EventHandler(this.cmdRelatorios_Click);
            // 
            // cmdReceitas
            // 
            this.cmdReceitas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdReceitas.FlatAppearance.BorderSize = 0;
            this.cmdReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.cmdReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReceitas.ForeColor = System.Drawing.Color.White;
            this.cmdReceitas.Image = global::Teste.Properties.Resources.icons8_saco_de_dinheiro_50;
            this.cmdReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReceitas.Location = new System.Drawing.Point(2, 264);
            this.cmdReceitas.Name = "cmdReceitas";
            this.cmdReceitas.Size = new System.Drawing.Size(183, 63);
            this.cmdReceitas.TabIndex = 2;
            this.cmdReceitas.Text = "Receitas";
            this.cmdReceitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdReceitas.UseVisualStyleBackColor = true;
            this.cmdReceitas.Click += new System.EventHandler(this.cmdReceitas_Click);
            // 
            // cmdConfiguracoes
            // 
            this.cmdConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdConfiguracoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdConfiguracoes.FlatAppearance.BorderSize = 0;
            this.cmdConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.cmdConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.cmdConfiguracoes.Image = global::Teste.Properties.Resources.icons8_configurações_48;
            this.cmdConfiguracoes.Location = new System.Drawing.Point(3, 612);
            this.cmdConfiguracoes.Name = "cmdConfiguracoes";
            this.cmdConfiguracoes.Size = new System.Drawing.Size(181, 63);
            this.cmdConfiguracoes.TabIndex = 1;
            this.cmdConfiguracoes.Text = "Config";
            this.cmdConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConfiguracoes.UseVisualStyleBackColor = true;
            this.cmdConfiguracoes.Click += new System.EventHandler(this.cmdConfiguracoes_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Teste.Properties.Resources.icons8_fundo_da_conferência_selecionado_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sócios";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Teste.Properties.Resources.logo3DeMaio21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRelatorios
            // 
            this.pnlRelatorios.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlRelatorios.Controls.Add(this.lblRelRecebido);
            this.pnlRelatorios.Controls.Add(this.label9);
            this.pnlRelatorios.Controls.Add(this.lblRelAtrasados);
            this.pnlRelatorios.Controls.Add(this.label7);
            this.pnlRelatorios.Controls.Add(this.lblRelAReceber);
            this.pnlRelatorios.Controls.Add(this.lblRelRelacaoSocios);
            this.pnlRelatorios.Controls.Add(this.label3);
            this.pnlRelatorios.Controls.Add(this.label5);
            this.pnlRelatorios.Location = new System.Drawing.Point(187, 424);
            this.pnlRelatorios.Name = "pnlRelatorios";
            this.pnlRelatorios.Size = new System.Drawing.Size(149, 240);
            this.pnlRelatorios.TabIndex = 8;
            this.pnlRelatorios.Visible = false;
            // 
            // lblRelRecebido
            // 
            this.lblRelRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelRecebido.ForeColor = System.Drawing.Color.White;
            this.lblRelRecebido.Location = new System.Drawing.Point(2, 122);
            this.lblRelRecebido.Name = "lblRelRecebido";
            this.lblRelRecebido.Size = new System.Drawing.Size(144, 16);
            this.lblRelRecebido.TabIndex = 6;
            this.lblRelRecebido.Text = "Recebido               >";
            this.lblRelRecebido.MouseEnter += new System.EventHandler(this.lblRelRecebido_MouseEnter);
            this.lblRelRecebido.MouseLeave += new System.EventHandler(this.lblRelRecebido_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-2, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "__________________";
            // 
            // lblRelAtrasados
            // 
            this.lblRelAtrasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelAtrasados.ForeColor = System.Drawing.Color.White;
            this.lblRelAtrasados.Location = new System.Drawing.Point(2, 88);
            this.lblRelAtrasados.Name = "lblRelAtrasados";
            this.lblRelAtrasados.Size = new System.Drawing.Size(144, 16);
            this.lblRelAtrasados.TabIndex = 4;
            this.lblRelAtrasados.Text = "Atrasados              >";
            this.lblRelAtrasados.MouseEnter += new System.EventHandler(this.lblRelAtrasados_MouseEnter);
            this.lblRelAtrasados.MouseLeave += new System.EventHandler(this.lblRelAtrasados_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "__________________";
            // 
            // lblRelAReceber
            // 
            this.lblRelAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelAReceber.ForeColor = System.Drawing.Color.White;
            this.lblRelAReceber.Location = new System.Drawing.Point(2, 52);
            this.lblRelAReceber.Name = "lblRelAReceber";
            this.lblRelAReceber.Size = new System.Drawing.Size(144, 16);
            this.lblRelAReceber.TabIndex = 2;
            this.lblRelAReceber.Text = " A Receber            >";
            this.lblRelAReceber.MouseEnter += new System.EventHandler(this.lblRelAReceber_MouseEnter);
            this.lblRelAReceber.MouseLeave += new System.EventHandler(this.lblRelAReceber_MouseLeave);
            // 
            // lblRelRelacaoSocios
            // 
            this.lblRelRelacaoSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelRelacaoSocios.ForeColor = System.Drawing.Color.White;
            this.lblRelRelacaoSocios.Location = new System.Drawing.Point(1, 14);
            this.lblRelRelacaoSocios.Name = "lblRelRelacaoSocios";
            this.lblRelRelacaoSocios.Size = new System.Drawing.Size(146, 16);
            this.lblRelRelacaoSocios.TabIndex = 0;
            this.lblRelRelacaoSocios.Text = " Relação Sócios   >";
            this.lblRelRelacaoSocios.Click += new System.EventHandler(this.lblRelRelacaoSocios_Click);
            this.lblRelRelacaoSocios.MouseEnter += new System.EventHandler(this.lblRelRelacaoSocios_MouseEnter);
            this.lblRelRelacaoSocios.MouseLeave += new System.EventHandler(this.lblRelRelacaoSocios_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "__________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "__________________";
            // 
            // frmTDM_Princiapal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 788);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRelatorios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTDM_Princiapal";
            this.Text = "S. R. 3 de Maio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRelatorios.ResumeLayout(false);
            this.pnlRelatorios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button cmdConfiguracoes;
        private System.Windows.Forms.Button cmdRelatorios;
        private System.Windows.Forms.Button cmdReceitas;
        private System.Windows.Forms.Panel pnlRelatorios;
        private System.Windows.Forms.Label lblRelAtrasados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRelAReceber;
        private System.Windows.Forms.Label lblRelRelacaoSocios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRelRecebido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblIdUser;
    }
}

