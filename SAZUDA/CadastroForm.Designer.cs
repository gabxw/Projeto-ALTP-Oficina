namespace SAZUDA
{
    partial class CadastroForm
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCadastrarCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(543, 355);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "button1";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastrarCliente
            // 
            this.lblCadastrarCliente.AutoSize = true;
            this.lblCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.lblCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCadastrarCliente.Location = new System.Drawing.Point(36, 159);
            this.lblCadastrarCliente.Name = "lblCadastrarCliente";
            this.lblCadastrarCliente.Size = new System.Drawing.Size(111, 16);
            this.lblCadastrarCliente.TabIndex = 1;
            this.lblCadastrarCliente.Text = " Cadastrar cliente";
            this.lblCadastrarCliente.Click += new System.EventHandler(this.lblCadastrarCliente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(543, 246);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAZUDA.Properties.Resources.planodefundoCerto3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1098, 622);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCadastrarCliente);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastrarCliente;
        private System.Windows.Forms.TextBox txtNome;
    }
}