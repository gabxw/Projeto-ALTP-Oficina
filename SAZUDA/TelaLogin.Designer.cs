namespace SAZUDA
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.IdUsuario = new System.Windows.Forms.TextBox();
            this.LinhaUsuario = new System.Windows.Forms.TextBox();
            this.IdSenha = new System.Windows.Forms.MaskedTextBox();
            this.LinhaSenha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.IdUsuario);
            this.panel1.Controls.Add(this.LinhaUsuario);
            this.panel1.Controls.Add(this.IdSenha);
            this.panel1.Controls.Add(this.LinhaSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 459);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "ALTP OFICINA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Deseja manter a sessão salva?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(71, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // IdUsuario
            // 
            this.IdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.IdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IdUsuario.Location = new System.Drawing.Point(44, 177);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(100, 19);
            this.IdUsuario.TabIndex = 5;
            this.IdUsuario.TextChanged += new System.EventHandler(this.IdUsuario_TextChanged);
            // 
            // LinhaUsuario
            // 
            this.LinhaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.LinhaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinhaUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinhaUsuario.Location = new System.Drawing.Point(44, 179);
            this.LinhaUsuario.Name = "LinhaUsuario";
            this.LinhaUsuario.Size = new System.Drawing.Size(100, 19);
            this.LinhaUsuario.TabIndex = 7;
            this.LinhaUsuario.Text = "_______________________";
            this.LinhaUsuario.TextChanged += new System.EventHandler(this.LinhaUsuario_TextChanged);
            // 
            // IdSenha
            // 
            this.IdSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.IdSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IdSenha.Location = new System.Drawing.Point(44, 238);
            this.IdSenha.Name = "IdSenha";
            this.IdSenha.Size = new System.Drawing.Size(100, 19);
            this.IdSenha.TabIndex = 4;
            this.IdSenha.UseSystemPasswordChar = true;
            this.IdSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IdSenha_TextChanged);
            // 
            // LinhaSenha
            // 
            this.LinhaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.LinhaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinhaSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinhaSenha.Location = new System.Drawing.Point(44, 240);
            this.LinhaSenha.Name = "LinhaSenha";
            this.LinhaSenha.Size = new System.Drawing.Size(100, 19);
            this.LinhaSenha.TabIndex = 8;
            this.LinhaSenha.Text = "_______________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SAZUDA.Properties.Resources.imagem_tela_de_login;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(287, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 459);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdUsuario;
        private System.Windows.Forms.MaskedTextBox IdSenha;
        private System.Windows.Forms.MaskedTextBox LinhaSenha;
        private System.Windows.Forms.TextBox LinhaUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}