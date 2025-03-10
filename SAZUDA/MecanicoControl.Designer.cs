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
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnRecusar = new System.Windows.Forms.Button();
            this.panelAceite = new System.Windows.Forms.Panel();
            this.btnConfirmarAceite = new System.Windows.Forms.Button();
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRelatorioGeral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).BeginInit();
            this.panelAceite.SuspendLayout();
            this.panelRecusa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDemandas
            // 
            this.dgvDemandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandas.Location = new System.Drawing.Point(150, 45);
            this.dgvDemandas.Name = "dgvDemandas";
            this.dgvDemandas.Size = new System.Drawing.Size(900, 172);
            this.dgvDemandas.TabIndex = 0;
            this.dgvDemandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDemandas_CellContentClick);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(514, 235);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 1;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnRecusar
            // 
            this.btnRecusar.Location = new System.Drawing.Point(642, 235);
            this.btnRecusar.Name = "btnRecusar";
            this.btnRecusar.Size = new System.Drawing.Size(75, 23);
            this.btnRecusar.TabIndex = 2;
            this.btnRecusar.Text = "Recusar";
            this.btnRecusar.UseVisualStyleBackColor = true;
            this.btnRecusar.Click += new System.EventHandler(this.btnRecusar_Click);
            // 
            // panelAceite
            // 
            this.panelAceite.Controls.Add(this.btnConfirmarAceite);
            this.panelAceite.Controls.Add(this.txtValorAceite);
            this.panelAceite.Controls.Add(this.label3);
            this.panelAceite.Controls.Add(this.txtPrazoAceite);
            this.panelAceite.Controls.Add(this.label2);
            this.panelAceite.Controls.Add(this.txtDefeito);
            this.panelAceite.Controls.Add(this.label1);
            this.panelAceite.Location = new System.Drawing.Point(294, 293);
            this.panelAceite.Name = "panelAceite";
            this.panelAceite.Size = new System.Drawing.Size(518, 139);
            this.panelAceite.TabIndex = 3;
            this.panelAceite.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAceite_Paint);
            // 
            // btnConfirmarAceite
            // 
            this.btnConfirmarAceite.Location = new System.Drawing.Point(396, 98);
            this.btnConfirmarAceite.Name = "btnConfirmarAceite";
            this.btnConfirmarAceite.Size = new System.Drawing.Size(97, 23);
            this.btnConfirmarAceite.TabIndex = 6;
            this.btnConfirmarAceite.Text = "Confirmar Aceitar";
            this.btnConfirmarAceite.UseVisualStyleBackColor = true;
            this.btnConfirmarAceite.Click += new System.EventHandler(this.btnConfirmarAceite_Click);
            // 
            // txtValorAceite
            // 
            this.txtValorAceite.Location = new System.Drawing.Point(91, 80);
            this.txtValorAceite.Name = "txtValorAceite";
            this.txtValorAceite.Size = new System.Drawing.Size(100, 20);
            this.txtValorAceite.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // txtPrazoAceite
            // 
            this.txtPrazoAceite.Location = new System.Drawing.Point(91, 53);
            this.txtPrazoAceite.Name = "txtPrazoAceite";
            this.txtPrazoAceite.Size = new System.Drawing.Size(94, 20);
            this.txtPrazoAceite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prazo:";
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
            // 
            // panelRecusa
            // 
            this.panelRecusa.Controls.Add(this.btnConfirmarRecusa);
            this.panelRecusa.Controls.Add(this.txtMotivoRecusa);
            this.panelRecusa.Controls.Add(this.label4);
            this.panelRecusa.Location = new System.Drawing.Point(294, 515);
            this.panelRecusa.Name = "panelRecusa";
            this.panelRecusa.Size = new System.Drawing.Size(524, 122);
            this.panelRecusa.TabIndex = 4;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motivo da Recusa:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(843, 360);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(942, 535);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelatorio.TabIndex = 5;
            this.btnGerarRelatorio.Text = "Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(934, 235);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(116, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Demanda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Location = new System.Drawing.Point(942, 578);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(108, 23);
            this.btnRelatorioGeral.TabIndex = 7;
            this.btnRelatorioGeral.Text = "Relatório Geral";
            this.btnRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // MecanicoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRelatorioGeral);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelRecusa);
            this.Controls.Add(this.panelAceite);
            this.Controls.Add(this.btnRecusar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.dgvDemandas);
            this.Name = "MecanicoControl";
            this.Size = new System.Drawing.Size(1153, 657);
            this.Load += new System.EventHandler(this.MecanicoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).EndInit();
            this.panelAceite.ResumeLayout(false);
            this.panelAceite.PerformLayout();
            this.panelRecusa.ResumeLayout(false);
            this.panelRecusa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemandas;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnRecusar;
        private System.Windows.Forms.Panel panelAceite;
        private System.Windows.Forms.TextBox txtValorAceite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrazoAceite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarAceite;
        private System.Windows.Forms.Panel panelRecusa;
        private System.Windows.Forms.Button btnConfirmarRecusa;
        private System.Windows.Forms.TextBox txtMotivoRecusa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnRelatorioGeral;
    }
}
