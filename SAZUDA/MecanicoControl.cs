using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SAZUDA
{
    public partial class MecanicoControl : UserControl
    {
        private Timer timerAtualiza;
        public MecanicoControl()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            // Ao iniciar, os painéis de aceite e recusa ficam escondidos
            panelAceite.Visible = false;
            panelRecusa.Visible = false;
            CarregarDemandas();
            // Configura o Timer para atualizar a cada 5 segundos (5000 milissegundos)
            timerAtualiza = new Timer();
            timerAtualiza.Interval = 5000;
            timerAtualiza.Tick += TimerAtualiza_Tick;
            timerAtualiza.Start();
        }

        private void TimerAtualiza_Tick(object sender, EventArgs e)
        {
            CarregarDemandas();
        }

        // Configura o DataGridView (supondo que o nome no Designer seja dgvDemandas)
        private void ConfigurarDataGridView()
        {
            dgvDemandas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDemandas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDemandas.MultiSelect = false;
            dgvDemandas.AllowUserToAddRows = false;
            dgvDemandas.AllowUserToDeleteRows = false;
            dgvDemandas.AllowUserToResizeRows = false;
            dgvDemandas.RowHeadersVisible = false;
            dgvDemandas.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvDemandas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvDemandas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvDemandas.EnableHeadersVisualStyles = false;
            dgvDemandas.RowTemplate.Height = 30;
        }

        // Método para obter a conexão com o banco de dados
        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CadastroDB"]?.ConnectionString;
            return new SqlConnection(connectionString);
        }


        // Método para carregar as demandas no DataGridView com os novos campos
        private void CarregarDemandas()
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn == null) return; // Se a conexão for nula, sai do método

                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    car.ID AS DemandaID,
                    c.Nome AS NomeCliente,
                    car.Marca,
                    car.Modelo,
                    car.Placa,
                    car.Descricao,
                    car.Status,
                    car.Defeito,
                    car.Prazo,
                    car.Valor
                FROM Clientes c
                INNER JOIN Carros car ON c.ID = car.ClienteID
                WHERE (car.Status IS NULL OR car.Status = '' OR (car.Status <> 'Finalizado' AND car.Status <> 'Recusado'))
                ORDER BY car.ID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDemandas.DataSource = dt;
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Erro ao carregar demandas: " + ex.Message,
                                  //  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botão Aceitar – exibe o painel de aceite e oculta o de recusa
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para aceitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panelAceite.Visible = true;
            panelRecusa.Visible = false;
        }

        // Botão Recusar – exibe o painel de recusa e oculta o de aceite
        private void btnRecusar_Click(object sender, EventArgs e)
        {
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para recusar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panelRecusa.Visible = true;
            panelAceite.Visible = false;
        }

        // Botão Confirmar Aceite – atualiza o registro com os dados de aceite
        private void btnConfirmarAceite_Click(object sender, EventArgs e)
        {
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para confirmar o aceite.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int demandaId = Convert.ToInt32(dgvDemandas.SelectedRows[0].Cells["DemandaID"].Value);
            string defeito = txtDefeito.Text.Trim();
            string prazo = txtPrazoAceite.Text.Trim();
            string valor = txtValorAceite.Text.Trim();

            if (string.IsNullOrWhiteSpace(defeito) || string.IsNullOrWhiteSpace(prazo) || string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show("Preencha todos os campos de aceite (defeito, prazo e valor).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE Carros 
                        SET Status = 'Aceitado', Defeito = @Defeito, Prazo = @Prazo, Valor = @Valor 
                        WHERE ID = @DemandaID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Defeito", defeito);
                        cmd.Parameters.AddWithValue("@Prazo", prazo);
                        cmd.Parameters.AddWithValue("@Valor", valor);
                        cmd.Parameters.AddWithValue("@DemandaID", demandaId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Demanda atualizada com aceite!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelAceite.Visible = false;
                    CarregarDemandas(); // Atualiza a lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao confirmar o aceite: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botão Confirmar Recusa – atualiza o registro com os dados de recusa
        private void btnConfirmarRecusa_Click(object sender, EventArgs e)
        {
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para confirmar a recusa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int demandaId = Convert.ToInt32(dgvDemandas.SelectedRows[0].Cells["DemandaID"].Value);
            string motivo = txtMotivoRecusa.Text.Trim();

            if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show("Informe o motivo da recusa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE Carros 
                        SET Status = 'Recusado', Defeito = @Motivo, Prazo = NULL, Valor = NULL 
                        WHERE ID = @DemandaID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Motivo", motivo);
                        cmd.Parameters.AddWithValue("@DemandaID", demandaId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Demanda atualizada com recusa!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelRecusa.Visible = false;
                    CarregarDemandas(); // Atualiza a lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao confirmar a recusa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Exemplo de evento para atualizar a lista manualmente
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDemandas();
        }

        private void MecanicoControl_Load(object sender, EventArgs e)
        {
            // Configura o DataGridView (caso não esteja configurado via Designer)
            ConfigurarDataGridView();
            // Esconde os painéis de aceite e recusa inicialmente
            panelAceite.Visible = false;
            panelRecusa.Visible = false;
            CarregarDemandas();
        }

        // (Opcional) Caso deseje tratar cliques no DataGridView
        private void dgvDemandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pode implementar se necessário
        }

        private void txtDefeito_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para gerar o relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a linha selecionada
            DataGridViewRow row = dgvDemandas.SelectedRows[0];

            // Recupera os dados da demanda (assegure-se que os nomes das colunas correspondem ao que foi definido na consulta)
            string demandaID = row.Cells["DemandaID"].Value.ToString();
            string nomeCliente = row.Cells["NomeCliente"].Value.ToString();
            string marca = row.Cells["Marca"].Value.ToString();
            string modelo = row.Cells["Modelo"].Value.ToString();
            string placa = row.Cells["Placa"].Value.ToString();
            string descricao = row.Cells["Descricao"].Value.ToString();
            string status = row.Cells["Status"].Value?.ToString() ?? "";
            string defeito = row.Cells["Defeito"].Value?.ToString() ?? "";
            string prazo = row.Cells["Prazo"].Value?.ToString() ?? "";
            string valor = row.Cells["Valor"].Value?.ToString() ?? "";

            // Cria o conteúdo do relatório
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Relatório de Demanda - Oficina ALTP");
            sb.AppendLine("==================================");
            sb.AppendLine($"Demanda ID: {demandaID}");
            sb.AppendLine($"Nome do Cliente: {nomeCliente}");
            sb.AppendLine($"Marca: {marca}");
            sb.AppendLine($"Modelo: {modelo}");
            sb.AppendLine($"Placa: {placa}");
            sb.AppendLine($"Descrição da Demanda: {descricao}");
            sb.AppendLine("----------------------------------");
            sb.AppendLine($"Status: {status}");
            sb.AppendLine($"Defeito Detectado: {defeito}");
            sb.AppendLine($"Prazo: {prazo}");
            sb.AppendLine($"Valor: {valor}");
            sb.AppendLine("==================================");

            // Abre um SaveFileDialog para o usuário escolher onde salvar
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo de Texto (*.txt)|*.txt";
            sfd.Title = "Salvar Relatório de Demanda";
            sfd.FileName = $"Relatorio_Demanda_{demandaID}.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvDemandas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma demanda para finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int demandaId = Convert.ToInt32(dgvDemandas.SelectedRows[0].Cells["DemandaID"].Value);

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE Carros 
                SET Status = 'Finalizado' 
                WHERE ID = @DemandaID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DemandaID", demandaId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Demanda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDemandas(); // Atualiza a lista de demandas
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar a demanda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    // Consulta para buscar todas as demandas
                    string query = @"
                SELECT 
                    car.ID AS DemandaID,
                    c.Nome AS NomeCliente,
                    car.Marca,
                    car.Modelo,
                    car.Placa,
                    car.Descricao,
                    car.Status,
                    car.Defeito,
                    car.Prazo,
                    car.Valor
                FROM Clientes c
                INNER JOIN Carros car ON c.ID = car.ClienteID
                ORDER BY car.ID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma demanda registrada para gerar relatório.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Monta o conteúdo do relatório
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendLine("Relatório Geral de Demandas - Oficina ALTP");
                    sb.AppendLine("===========================================");
                    foreach (DataRow row in dt.Rows)
                    {
                        sb.AppendLine($"Demanda ID: {row["DemandaID"]}");
                        sb.AppendLine($"Nome do Cliente: {row["NomeCliente"]}");
                        sb.AppendLine($"Marca: {row["Marca"]}");
                        sb.AppendLine($"Modelo: {row["Modelo"]}");
                        sb.AppendLine($"Placa: {row["Placa"]}");
                        sb.AppendLine($"Descrição: {row["Descricao"]}");
                        sb.AppendLine($"Status: {row["Status"]}");
                        sb.AppendLine($"Defeito: {row["Defeito"]}");
                        sb.AppendLine($"Prazo: {row["Prazo"]}");
                        sb.AppendLine($"Valor: {row["Valor"]}");
                        sb.AppendLine("-------------------------------------------");
                    }

                    // Salva o relatório em um arquivo .txt
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Arquivo de Texto (*.txt)|*.txt";
                    sfd.Title = "Salvar Relatório Geral de Demandas";
                    sfd.FileName = "Relatorio_Geral_Demandas.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                        MessageBox.Show("Relatório geral gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar relatório geral: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelAceite_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
