
namespace Teste
{
    partial class frmTDM_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdConfigConexao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmdEntrar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlConexao = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.cmdConfigConexao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 71);
            this.panel1.TabIndex = 0;
            // 
            // cmdConfigConexao
            // 
            this.cmdConfigConexao.FlatAppearance.BorderSize = 0;
            this.cmdConfigConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfigConexao.Image = global::Teste.Properties.Resources.icons8_configurações_16;
            this.cmdConfigConexao.Location = new System.Drawing.Point(320, 3);
            this.cmdConfigConexao.Name = "cmdConfigConexao";
            this.cmdConfigConexao.Size = new System.Drawing.Size(27, 23);
            this.cmdConfigConexao.TabIndex = 3;
            this.cmdConfigConexao.UseVisualStyleBackColor = true;
            this.cmdConfigConexao.Visible = false;
            this.cmdConfigConexao.Click += new System.EventHandler(this.cmdConfigConexao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(82, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sistema 3 de Maio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste.Properties.Resources.logo3DeMaio;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(11, 180);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(326, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.cmdEntrar.FlatAppearance.BorderSize = 0;
            this.cmdEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrar.ForeColor = System.Drawing.Color.White;
            this.cmdEntrar.Location = new System.Drawing.Point(32, 246);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(284, 26);
            this.cmdEntrar.TabIndex = 6;
            this.cmdEntrar.Text = "Entrar";
            this.cmdEntrar.UseVisualStyleBackColor = false;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSair.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.cmdSair.FlatAppearance.BorderSize = 0;
            this.cmdSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.ForeColor = System.Drawing.Color.White;
            this.cmdSair.Location = new System.Drawing.Point(32, 278);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(284, 26);
            this.cmdSair.TabIndex = 7;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(11, 121);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(326, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // pnlConexao
            // 
            this.pnlConexao.Controls.Add(this.cmdGravar);
            this.pnlConexao.Controls.Add(this.txtPassword);
            this.pnlConexao.Controls.Add(this.label8);
            this.pnlConexao.Controls.Add(this.txtDataBase);
            this.pnlConexao.Controls.Add(this.label7);
            this.pnlConexao.Controls.Add(this.txtUser);
            this.pnlConexao.Controls.Add(this.label6);
            this.pnlConexao.Controls.Add(this.txtServer);
            this.pnlConexao.Controls.Add(this.label5);
            this.pnlConexao.Controls.Add(this.label4);
            this.pnlConexao.Location = new System.Drawing.Point(10, 77);
            this.pnlConexao.Name = "pnlConexao";
            this.pnlConexao.Size = new System.Drawing.Size(327, 266);
            this.pnlConexao.TabIndex = 8;
            this.pnlConexao.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Conexão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(43, 60);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(240, 20);
            this.txtServer.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(43, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 20);
            this.txtUser.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "User";
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(44, 143);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(240, 20);
            this.txtDataBase.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "DataBase";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(112, 224);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(75, 23);
            this.cmdGravar.TabIndex = 9;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // frmTDM_Login
            // 
            this.AcceptButton = this.cmdEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdSair;
            this.ClientSize = new System.Drawing.Size(350, 355);
            this.Controls.Add(this.pnlConexao);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTDM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTDM_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConexao.ResumeLayout(false);
            this.pnlConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button cmdEntrar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button cmdConfigConexao;
        private System.Windows.Forms.Panel pnlConexao;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
    }
}