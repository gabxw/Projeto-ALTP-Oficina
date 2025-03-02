namespace SAZUDA
{
    partial class CadastroControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtSegundoEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCliente = new System.Windows.Forms.TabPage();
            this.tabCarro = new System.Windows.Forms.TabPage();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.BtnCadastroCarro = new System.Windows.Forms.Button();
            this.TxtModeloCarro = new System.Windows.Forms.TextBox();
            this.TxtPlacaCarro = new System.Windows.Forms.TextBox();
            this.TxtMarcaCarro = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabCliente.SuspendLayout();
            this.tabCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastroCliente.Location = new System.Drawing.Point(314, 350);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(139, 48);
            this.btnCadastroCliente.TabIndex = 17;
            this.btnCadastroCliente.Text = "Cadastrar";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.SystemColors.Window;
            this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCPF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mskCPF.Location = new System.Drawing.Point(189, 228);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(165, 22);
            this.mskCPF.TabIndex = 16;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mskTelefone.Location = new System.Drawing.Point(406, 108);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(164, 22);
            this.mskTelefone.TabIndex = 15;
            this.mskTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefone_MaskInputRejected);
            // 
            // mskCEP
            // 
            this.mskCEP.BackColor = System.Drawing.SystemColors.Window;
            this.mskCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCEP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mskCEP.Location = new System.Drawing.Point(406, 148);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(164, 22);
            this.mskCEP.TabIndex = 14;
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCEP_MaskInputRejected);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtEstado.Location = new System.Drawing.Point(406, 228);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(164, 22);
            this.txtEstado.TabIndex = 13;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged_1);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtCidade.Location = new System.Drawing.Point(406, 188);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 22);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged_1);
            // 
            // txtSegundoEmail
            // 
            this.txtSegundoEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtSegundoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtSegundoEmail.Location = new System.Drawing.Point(189, 188);
            this.txtSegundoEmail.Name = "txtSegundoEmail";
            this.txtSegundoEmail.Size = new System.Drawing.Size(165, 22);
            this.txtSegundoEmail.TabIndex = 11;
            this.txtSegundoEmail.TextChanged += new System.EventHandler(this.txtSegundoEmail_TextChanged_1);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtEmail.Location = new System.Drawing.Point(189, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 22);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(189, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 22);
            this.txtNome.TabIndex = 9;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCliente);
            this.tabControl1.Controls.Add(this.tabCarro);
            this.tabControl1.Location = new System.Drawing.Point(164, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 496);
            this.tabControl1.TabIndex = 18;
            // 
            // TabCliente
            // 
            this.TabCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabCliente.Controls.Add(this.txtNome);
            this.TabCliente.Controls.Add(this.btnCadastroCliente);
            this.TabCliente.Controls.Add(this.txtEmail);
            this.TabCliente.Controls.Add(this.mskCPF);
            this.TabCliente.Controls.Add(this.txtSegundoEmail);
            this.TabCliente.Controls.Add(this.mskTelefone);
            this.TabCliente.Controls.Add(this.txtCidade);
            this.TabCliente.Controls.Add(this.mskCEP);
            this.TabCliente.Controls.Add(this.txtEstado);
            this.TabCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCliente.Location = new System.Drawing.Point(4, 22);
            this.TabCliente.Name = "TabCliente";
            this.TabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.TabCliente.Size = new System.Drawing.Size(769, 470);
            this.TabCliente.TabIndex = 1;
            this.TabCliente.Text = "Cliente";
            // 
            // tabCarro
            // 
            this.tabCarro.BackColor = System.Drawing.Color.Transparent;
            this.tabCarro.Controls.Add(this.TxtIdCliente);
            this.tabCarro.Controls.Add(this.BtnCadastroCarro);
            this.tabCarro.Controls.Add(this.TxtModeloCarro);
            this.tabCarro.Controls.Add(this.TxtPlacaCarro);
            this.tabCarro.Controls.Add(this.TxtMarcaCarro);
            this.tabCarro.Controls.Add(this.TxtDescricaoProblema);
            this.tabCarro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCarro.Location = new System.Drawing.Point(4, 22);
            this.tabCarro.Name = "tabCarro";
            this.tabCarro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarro.Size = new System.Drawing.Size(769, 470);
            this.tabCarro.TabIndex = 0;
            this.tabCarro.Text = "Carro";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtIdCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtIdCliente.Location = new System.Drawing.Point(204, 105);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(165, 22);
            this.TxtIdCliente.TabIndex = 18;
            this.TxtIdCliente.TextChanged += new System.EventHandler(this.TxtIdCliente_TextChanged);
            // 
            // BtnCadastroCarro
            // 
            this.BtnCadastroCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BtnCadastroCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastroCarro.FlatAppearance.BorderSize = 0;
            this.BtnCadastroCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroCarro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroCarro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCadastroCarro.Location = new System.Drawing.Point(314, 350);
            this.BtnCadastroCarro.Name = "BtnCadastroCarro";
            this.BtnCadastroCarro.Size = new System.Drawing.Size(139, 48);
            this.BtnCadastroCarro.TabIndex = 26;
            this.BtnCadastroCarro.Text = "Cadastrar";
            this.BtnCadastroCarro.UseVisualStyleBackColor = false;
            this.BtnCadastroCarro.Click += new System.EventHandler(this.BtnCadastroCarro_Click);
            // 
            // TxtModeloCarro
            // 
            this.TxtModeloCarro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtModeloCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModeloCarro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModeloCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtModeloCarro.Location = new System.Drawing.Point(204, 145);
            this.TxtModeloCarro.Name = "TxtModeloCarro";
            this.TxtModeloCarro.Size = new System.Drawing.Size(165, 22);
            this.TxtModeloCarro.TabIndex = 19;
            this.TxtModeloCarro.TextChanged += new System.EventHandler(this.TxtModeloCarro_TextChanged);
            // 
            // TxtPlacaCarro
            // 
            this.TxtPlacaCarro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPlacaCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPlacaCarro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlacaCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtPlacaCarro.Location = new System.Drawing.Point(405, 145);
            this.TxtPlacaCarro.Name = "TxtPlacaCarro";
            this.TxtPlacaCarro.Size = new System.Drawing.Size(165, 22);
            this.TxtPlacaCarro.TabIndex = 20;
            this.TxtPlacaCarro.TextChanged += new System.EventHandler(this.TxtPlacaCarro_TextChanged);
            // 
            // TxtMarcaCarro
            // 
            this.TxtMarcaCarro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMarcaCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMarcaCarro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtMarcaCarro.Location = new System.Drawing.Point(406, 105);
            this.TxtMarcaCarro.Name = "TxtMarcaCarro";
            this.TxtMarcaCarro.Size = new System.Drawing.Size(164, 22);
            this.TxtMarcaCarro.TabIndex = 21;
            this.TxtMarcaCarro.TextChanged += new System.EventHandler(this.TxtMarcaCarro_TextChanged);
            // 
            // TxtDescricaoProblema
            // 
            this.TxtDescricaoProblema.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescricaoProblema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescricaoProblema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoProblema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtDescricaoProblema.Location = new System.Drawing.Point(205, 209);
            this.TxtDescricaoProblema.Multiline = true;
            this.TxtDescricaoProblema.Name = "TxtDescricaoProblema";
            this.TxtDescricaoProblema.Size = new System.Drawing.Size(365, 62);
            this.TxtDescricaoProblema.TabIndex = 22;
            this.TxtDescricaoProblema.TextChanged += new System.EventHandler(this.TxtDescricaoProblema_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastrar";
            // 
            // CadastroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Name = "CadastroControl";
            this.Size = new System.Drawing.Size(1153, 637);
            this.Load += new System.EventHandler(this.CadastroControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabCliente.ResumeLayout(false);
            this.TabCliente.PerformLayout();
            this.tabCarro.ResumeLayout(false);
            this.tabCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtSegundoEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCliente;
        private System.Windows.Forms.TabPage tabCarro;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Button BtnCadastroCarro;
        private System.Windows.Forms.TextBox TxtModeloCarro;
        private System.Windows.Forms.TextBox TxtPlacaCarro;
        private System.Windows.Forms.TextBox TxtMarcaCarro;
        private System.Windows.Forms.TextBox TxtDescricaoProblema;
        private System.Windows.Forms.Label label1;
    }
}
