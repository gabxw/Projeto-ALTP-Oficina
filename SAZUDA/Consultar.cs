using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAZUDA
{
    public partial class Consultar : UserControl
    {
        public Consultar()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        // Método para configurar o DataGridView
        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 30;
        }

        // Método para obter a conexão com o banco de dados
        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CadastroDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        // Método para carregar as demandas no DataGridView com os novos campos
        private void CarregarDemandas()
        {
            using (SqlConnection conn = GetConnection())
            {
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
                        ORDER BY car.ID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar demandas: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento do botão para consultar as demandas
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarDemandas();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pode ser deixado vazio ou implementado conforme necessário
        }

        private void Consultar_Load_1(object sender, EventArgs e)
        {

        }

    }
}
