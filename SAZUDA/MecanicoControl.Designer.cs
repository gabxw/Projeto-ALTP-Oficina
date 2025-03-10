namespace SAZUDA
{
    partial class MecanicoControl
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
            this.dgvDemandas = new System.Windows.Forms.DataGridView();
            this.panelAceite = new System.Windows.Forms.Panel();
            this.txtValorAceite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrazoAceite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecusa = new System.Windows.Forms.Panel();
            this.btnConfirmarRecusa = new System.Windows.Forms.Button();
            this.txtMotivoRecusa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnRelatorioGeral = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnRecusar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnConfirmarAceite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).BeginInit();
            this.panelAceite.SuspendLayout();
            this.panelRecusa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDemandas
            // 
            this.dgvDemandas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDemandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandas.Location = new System.Drawing.Point(143, 90);
            this.dgvDemandas.Name = "dgvDemandas";
            this.dgvDemandas.Size = new System.Drawing.Size(900, 172);
            this.dgvDemandas.TabIndex = 0;
            this.dgvDemandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDemandas_CellContentClick);
            // 
            // panelAceite
            // 
            this.panelAceite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelAceite.Controls.Add(this.btnConfirmarAceite);
            this.panelAceite.Controls.Add(this.txtValorAceite);
            this.panelAceite.Controls.Add(this.label3);
            this.panelAceite.Controls.Add(this.txtPrazoAceite);
            this.panelAceite.Controls.Add(this.label2);
            this.panelAceite.Controls.Add(this.txtDefeito);
            this.panelAceite.Controls.Add(this.label1);
            this.panelAceite.Location = new System.Drawing.Point(287, 338);
            this.panelAceite.Name = "panelAceite";
            this.panelAceite.Size = new System.Drawing.Size(518, 139);
            this.panelAceite.TabIndex = 3;
            this.panelAceite.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAceite_Paint);
            // 
            // txtValorAceite
            // 
            this.txtValorAceite.Location = new System.Drawing.Point(91, 80);
            this.txtValorAceite.Name = "txtValorAceite";
            this.txtValorAceite.Size = new System.Drawing.Size(100, 20);
            this.txtValorAceite.TabIndex = 5;
            this.txtValorAceite.TextChanged += new System.EventHandler(this.txtValorAceite_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrazoAceite
            // 
            this.txtPrazoAceite.Location = new System.Drawing.Point(91, 53);
            this.txtPrazoAceite.Name = "txtPrazoAceite";
            this.txtPrazoAceite.Size = new System.Drawing.Size(94, 20);
            this.txtPrazoAceite.TabIndex = 3;
            this.txtPrazoAceite.TextChanged += new System.EventHandler(this.txtPrazoAceite_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prazo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDefeito
            // 
            this.txtDefeito.Location = new System.Drawing.Point(91, 20);
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(392, 20);
            this.txtDefeito.TabIndex = 1;
            this.txtDefeito.TextChanged += new System.EventHandler(this.txtDefeito_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnóstico:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelRecusa
            // 
            this.panelRecusa.Controls.Add(this.btnConfirmarRecusa);
            this.panelRecusa.Controls.Add(this.txtMotivoRecusa);
            this.panelRecusa.Controls.Add(this.label4);
            this.panelRecusa.Location = new System.Drawing.Point(206, 261);
            this.panelRecusa.Name = "panelRecusa";
            this.panelRecusa.Size = new System.Drawing.Size(518, 140);
            this.panelRecusa.TabIndex = 4;
            this.panelRecusa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecusa_Paint);
            // 
            // btnConfirmarRecusa
            // 
            this.btnConfirmarRecusa.Location = new System.Drawing.Point(396, 96);
            this.btnConfirmarRecusa.Name = "btnConfirmarRecusa";
            this.btnConfirmarRecusa.Size = new System.Drawing.Size(113, 23);
            this.btnConfirmarRecusa.TabIndex = 2;
            this.btnConfirmarRecusa.Text = "Confirmar Recusa";
            this.btnConfirmarRecusa.UseVisualStyleBackColor = true;
            this.btnConfirmarRecusa.Click += new System.EventHandler(this.btnConfirmarRecusa_Click);
            // 
            // txtMotivoRecusa
            // 
            this.txtMotivoRecusa.Location = new System.Drawing.Point(122, 20);
            this.txtMotivoRecusa.Multiline = true;
            this.txtMotivoRecusa.Name = "txtMotivoRecusa";
            this.txtMotivoRecusa.Size = new System.Drawing.Size(371, 56);
            this.txtMotivoRecusa.TabIndex = 1;
            this.txtMotivoRecusa.TextChanged += new System.EventHandler(this.txtMotivoRecusa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motivo da Recusa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(762, 301);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnRecusar);
            this.panel1.Controls.Add(this.btnAceitar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panelRecusa);
            this.panel1.Location = new System.Drawing.Point(81, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 470);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(469, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mêcanico";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(849, 561);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(96, 28);
            this.btnGerarRelatorio.TabIndex = 27;
            this.btnGerarRelatorio.Text = "relatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRelatorioGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioGeral.FlatAppearance.BorderSize = 0;
            this.btnRelatorioGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioGeral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioGeral.Location = new System.Drawing.Point(963, 561);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(156, 28);
            this.btnRelatorioGeral.TabIndex = 28;
            this.btnRelatorioGeral.Text = "relatorio geral";
            this.btnRelatorioGeral.UseVisualStyleBackColor = false;
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnAceitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceitar.FlatAppearance.BorderSize = 0;
            this.btnAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceitar.Location = new System.Drawing.Point(412, 204);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(77, 23);
            this.btnAceitar.TabIndex = 29;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = false;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnRecusar
            // 
            this.btnRecusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRecusar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecusar.FlatAppearance.BorderSize = 0;
            this.btnRecusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecusar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecusar.Location = new System.Drawing.Point(534, 204);
            this.btnRecusar.Name = "btnRecusar";
            this.btnRecusar.Size = new System.Drawing.Size(83, 23);
            this.btnRecusar.TabIndex = 30;
            this.btnRecusar.Text = "Recusar";
            this.btnRecusar.UseVisualStyleBackColor = false;
            this.btnRecusar.Click += new System.EventHandler(this.btnRecusar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(65)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.Location = new System.Drawing.Point(815, 204);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(147, 23);
            this.btnFinalizar.TabIndex = 31;
            this.btnFinalizar.Text = "Finalizar Demanda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnConfirmarAceite
            // 
            this.btnConfirmarAceite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnConfirmarAceite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarAceite.FlatAppearance.BorderSize = 0;
            this.btnConfirmarAceite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAceite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAceite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmarAceite.Location = new System.Drawing.Point(382, 95);
            this.btnConfirmarAceite.Name = "btnConfirmarAceite";
            this.btnConfirmarAceite.Size = new System.Drawing.Size(127, 23);
            this.btnConfirmarAceite.TabIndex = 32;
            this.btnConfirmarAceite.Text = "Confirmar Aceitar";
            this.btnConfirmarAceite.UseVisualStyleBackColor = false;
            this.btnConfirmarAceite.Click += new System.EventHandler(this.btnConfirmarAceite_Click);
            // 
            // MecanicoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRelatorioGeral);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelAceite);
            this.Controls.Add(this.dgvDemandas);
            this.Controls.Add(this.panel1);
            this.Name = "MecanicoControl";
            this.Size = new System.Drawing.Size(1153, 657);
            this.Load += new System.EventHandler(this.MecanicoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).EndInit();
            this.panelAceite.ResumeLayout(false);
            this.panelAceite.PerformLayout();
            this.panelRecusa.ResumeLayout(false);
            this.panelRecusa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemandas;
        private System.Windows.Forms.Panel panelAceite;
        private System.Windows.Forms.TextBox txtValorAceite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrazoAceite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRecusa;
        private System.Windows.Forms.Button btnConfirmarRecusa;
        private System.Windows.Forms.TextBox txtMotivoRecusa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnRelatorioGeral;
        private System.Windows.Forms.Button btnRecusar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnConfirmarAceite;
    }
}
