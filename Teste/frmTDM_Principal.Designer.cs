
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdRelatorios = new System.Windows.Forms.Button();
            this.cmdReceitas = new System.Windows.Forms.Button();
            this.cmdConfiguracoes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.Controls.Add(this.cmdRelatorios);
            this.panel2.Controls.Add(this.cmdReceitas);
            this.panel2.Controls.Add(this.cmdConfiguracoes);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 785);
            this.panel2.TabIndex = 7;
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
            this.cmdConfiguracoes.Location = new System.Drawing.Point(3, 710);
            this.cmdConfiguracoes.Name = "cmdConfiguracoes";
            this.cmdConfiguracoes.Size = new System.Drawing.Size(181, 63);
            this.cmdConfiguracoes.TabIndex = 1;
            this.cmdConfiguracoes.Text = "Config";
            this.cmdConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConfiguracoes.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Teste.Properties.Resources.logo3DeMaio21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 843);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTDM_Princiapal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 843);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

