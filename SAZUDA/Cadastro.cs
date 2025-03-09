using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SAZUDA
{
    public partial class CadastroControl : UserControl
    {
        // ==========================
        //        CLIENTE
        // ==========================
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SegundoEmail { get; set; }
        public string Endereco { get; set; }
        public string ProblemaRelatado { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }

        // ==========================
        //         CARRO
        // ==========================
        // Aqui 'ID' está sendo usado para armazenar o CPF do cliente
        // que você digita no campo TxtIdCliente.
        public string ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Descricao { get; set; }

        public CadastroControl()
        {
            InitializeComponent();

            // ----------------------------
            // PLACEHOLDERS (CLIENTE)
            // ----------------------------
            ConfigurarPlaceholder(txtNome, "Digite seu nome");
            ConfigurarPlaceholder(txtEmail, "Digite seu email");
            ConfigurarPlaceholder(txtSegundoEmail, "Digite o segundo email");
            ConfigurarPlaceholder(txtCidade, "Digite sua cidade");
            ConfigurarPlaceholder(txtEstado, "Digite seu estado");
            ConfigurarPlaceholder(txtCpfCliente, "Digite seu CPF");
            ConfigurarPlaceholder(txtTelefone, "Digite seu telefone");
            ConfigurarPlaceholder(txtCep, "Digite seu CEP");
            ConfigurarPlaceholder(linhaNome, "___________________________");
            ConfigurarPlaceholder(linhaEmail, "___________________________");
            ConfigurarPlaceholder(linhaEmailSec, "___________________________");
            ConfigurarPlaceholder(linhaCpf, "___________________________");
            ConfigurarPlaceholder(linhaCep, "___________________________");
            ConfigurarPlaceholder(linhaTelefone, "___________________________");
            ConfigurarPlaceholder(linhaCidade, "___________________________");
            ConfigurarPlaceholder(linhaEstado, "___________________________");

            // ----------------------------
            // PLACEHOLDERS (CARRO)
            // ----------------------------
            ConfigurarPlaceholder(TxtIdCliente, "Insira o cpf do cliente.");
            ConfigurarPlaceholder(TxtMarcaCarro, "Digite a marca do carro.");
            ConfigurarPlaceholder(TxtModeloCarro, "Digite o modelo do carro.");
            ConfigurarPlaceholder(TxtPlacaCarro, "Digite a placa do carro.");
            ConfigurarPlaceholder(TxtDescricaoProblema, "Digite o problema do carro.");
            ConfigurarPlaceholder(LinhaIdCarro, "___________________________");
            ConfigurarPlaceholder(linhaMarca, "___________________________");
            ConfigurarPlaceholder(linhaModelo, "___________________________");
            ConfigurarPlaceholder(linhaPlaca, "___________________________");
        }

        // ==========================
        //   OBTÉM CONEXÃO COM O BD
        // ==========================
        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CadastroDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        // ==========================
        //  CADASTRAR CLIENTE
        // ==========================
        private void CadastrarCliente()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Clientes 
                            (Nome, Email, SegundoEmail, Cidade, Estado, CPF, Telefone, CEP) 
                        VALUES 
                            (@Nome, @Email, @SegundoEmail, @Cidade, @Estado, @CPF, @Telefone, @CEP)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@SegundoEmail",
                            string.IsNullOrWhiteSpace(SegundoEmail) ? (object)DBNull.Value : SegundoEmail);
                        cmd.Parameters.AddWithValue("@Cidade", Cidade);
                        cmd.Parameters.AddWithValue("@Estado", Estado);
                        cmd.Parameters.AddWithValue("@CPF", CPF);
                        cmd.Parameters.AddWithValue("@Telefone", Telefone);
                        cmd.Parameters.AddWithValue("@CEP", CEP);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================
        //   CADASTRAR CARRO
        // ==========================
        private void CadastrarCarro()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1) Descobrir o ID (chave primária) do cliente a partir do CPF
                    string sqlBuscarCliente = "SELECT ID FROM Clientes WHERE CPF = @CPF";
                    int clienteId;

                    using (SqlCommand cmdBuscar = new SqlCommand(sqlBuscarCliente, conn))
                    {
                        cmdBuscar.Parameters.AddWithValue("@CPF", ID); // 'ID' = CPF do cliente
                        object resultado = cmdBuscar.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show("Cliente não encontrado. Verifique o CPF informado.",
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Sai sem inserir o carro
                        }
                        clienteId = Convert.ToInt32(resultado);
                    }

                    // 2) Inserir o carro com base no clienteId
                    string sqlInserirCarro = @"
                        INSERT INTO Carros (ClienteID, Marca, Modelo, Placa, Descricao)
                        VALUES (@ClienteID, @Marca, @Modelo, @Placa, @Descricao)";

                    using (SqlCommand cmdInserir = new SqlCommand(sqlInserirCarro, conn))
                    {
                        cmdInserir.Parameters.AddWithValue("@ClienteID", clienteId);
                        cmdInserir.Parameters.AddWithValue("@Marca", Marca);
                        cmdInserir.Parameters.AddWithValue("@Modelo", Modelo);
                        cmdInserir.Parameters.AddWithValue("@Placa", Placa);
                        cmdInserir.Parameters.AddWithValue("@Descricao", Descricao);

                        cmdInserir.ExecuteNonQuery();
                    }

                    MessageBox.Show("Carro cadastrado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar carro: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastroControl_Load(object sender, EventArgs e)
        {
            // Qualquer código adicional ao carregar o UserControl, se necessário
        }

        // ==========================
        //  PLACEHOLDER (TextBox)
        // ==========================
        private void ConfigurarPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        // ==========================
        //  EVENTOS DOS CAMPOS (Cliente)
        // ==========================
        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            Email = txtEmail.Text;
        }

        private void txtSegundoEmail_TextChanged_1(object sender, EventArgs e)
        {
            SegundoEmail = txtSegundoEmail.Text;
        }

        private void txtCpfCliente_TextChanged(object sender, EventArgs e)
        {
            string cleanCPF = txtCpfCliente.Text.Replace(".", "").Replace("-", "").Trim();
            if (cleanCPF.Length == 11 && cleanCPF.All(char.IsDigit))
                CPF = cleanCPF;
            else
                CPF = null;
        }

        private void txtCidade_TextChanged_1(object sender, EventArgs e)
        {
            Cidade = txtCidade.Text;
        }

        private void txtEstado_TextChanged_1(object sender, EventArgs e)
        {
            Estado = txtEstado.Text;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            Telefone = txtTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            CEP = txtCep.Text.Replace("-", "");
        }

        // ==========================
        //  EVENTOS DOS CAMPOS (Carro)
        // ==========================
        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {
            ID = TxtIdCliente.Text; // CPF do cliente
        }

        private void TxtMarcaCarro_TextChanged(object sender, EventArgs e)
        {
            Marca = TxtMarcaCarro.Text;
        }

        private void TxtModeloCarro_TextChanged(object sender, EventArgs e)
        {
            Modelo = TxtModeloCarro.Text;
        }

        private void TxtPlacaCarro_TextChanged(object sender, EventArgs e)
        {
            Placa = TxtPlacaCarro.Text;
        }

        private void TxtDescricaoProblema_TextChanged(object sender, EventArgs e)
        {
            Descricao = TxtDescricaoProblema.Text;
        }

        // ==========================
        //  VALIDAÇÃO DOS CAMPOS
        // ==========================
        private bool ValidarCamposCLiente()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessageBox.Show("O campo Nome é obrigatório!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                MessageBox.Show("Digite um Email válido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(CPF))
            {
                MessageBox.Show("O campo CPF é obrigatório!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Telefone))
            {
                MessageBox.Show("O campo Telefone é obrigatório!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(CEP))
            {
                MessageBox.Show("O campo CEP é obrigatório!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("O campo ID é obrigatório! (Insira o CPF do cliente)",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidarCamposCarro()
        {
            if (string.IsNullOrWhiteSpace(Descricao))
            {
                MessageBox.Show("O campo descrição é obrigatório!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // ==========================
        //  BOTÕES
        // ==========================
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposCLiente())
                {
                    CadastrarCliente();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao cadastrar o cliente: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCadastroCarro_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCarro())
            {
                CadastrarCarro();
                LimparCampos();
            }
        }

        // ==========================
        //  LIMPAR CAMPOS
        // ==========================
        private void LimparCampos()
        {
            // 1) Limpa os campos
            txtNome.Clear();
            txtEmail.Clear();
            txtSegundoEmail.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCpfCliente.Clear();

            TxtIdCliente.Clear();
            TxtMarcaCarro.Clear();
            TxtModeloCarro.Clear();
            TxtPlacaCarro.Clear();
            TxtDescricaoProblema.Clear();

            // 2) Reaplica os placeholders
            ReaplicarPlaceholders();
        }

        /// <summary>
        /// Reaplica o placeholder em todos os TextBox
        /// (mesmo método usado no construtor).
        /// </summary>
        private void ReaplicarPlaceholders()
        {
            ConfigurarPlaceholder(txtNome, "Digite seu nome");
            ConfigurarPlaceholder(txtEmail, "Digite seu email");
            ConfigurarPlaceholder(txtSegundoEmail, "Digite o segundo email");
            ConfigurarPlaceholder(txtCidade, "Digite sua cidade");
            ConfigurarPlaceholder(txtEstado, "Digite seu estado");
            ConfigurarPlaceholder(txtCpfCliente, "Digite seu CPF");
            ConfigurarPlaceholder(txtTelefone, "Digite seu telefone");
            ConfigurarPlaceholder(txtCep, "Digite seu CEP");
            ConfigurarPlaceholder(linhaNome, "___________________________");
            ConfigurarPlaceholder(linhaEmail, "___________________________");
            ConfigurarPlaceholder(linhaEmailSec, "___________________________");
            ConfigurarPlaceholder(linhaCpf, "___________________________");
            ConfigurarPlaceholder(linhaCep, "___________________________");
            ConfigurarPlaceholder(linhaTelefone, "___________________________");
            ConfigurarPlaceholder(linhaCidade, "___________________________");
            ConfigurarPlaceholder(linhaEstado, "___________________________");

            ConfigurarPlaceholder(TxtIdCliente, "Insira o cpf do cliente.");
            ConfigurarPlaceholder(TxtMarcaCarro, "Digite a marca do carro.");
            ConfigurarPlaceholder(TxtModeloCarro, "Digite o modelo do carro.");
            ConfigurarPlaceholder(TxtPlacaCarro, "Digite a placa do carro.");
            ConfigurarPlaceholder(TxtDescricaoProblema, "Digite o problema do carro.");
            ConfigurarPlaceholder(LinhaIdCarro, "___________________________");
            ConfigurarPlaceholder(linhaMarca, "___________________________");
            ConfigurarPlaceholder(linhaModelo, "___________________________");
            ConfigurarPlaceholder(linhaPlaca, "___________________________");
        }

        // ==========================
        //  EVENTOS EXTRAS
        // ==========================
        private void linhaNome_TextChanged(object sender, EventArgs e) { }
        private void linhaEmail_TextChanged(object sender, EventArgs e) { }
        private void linhaEmailSec_TextChanged(object sender, EventArgs e) { }
        private void linhaCpf_TextChanged(object sender, EventArgs e) { }
        private void linhaCep_TextChanged(object sender, EventArgs e) { }
        private void linhaTelefone_TextChanged(object sender, EventArgs e) { }
        private void linhaCidade_TextChanged(object sender, EventArgs e) { }
        private void linhaEstado_TextChanged(object sender, EventArgs e) { }
        private void LinhaIdCarro_TextChanged(object sender, EventArgs e) { }
        private void linhaMarca_TextChanged(object sender, EventArgs e) { }
        private void linhaModelo_TextChanged(object sender, EventArgs e) { }
        private void linhaPlaca_TextChanged(object sender, EventArgs e) { }
        private void TabCliente_Click(object sender, EventArgs e) { }
        private void tabCarro_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
