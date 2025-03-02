using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace SAZUDA
{
    public partial class CadastroControl: UserControl
    {
        //Cliente

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

        //Carro
        public string ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Descricao { get; set; }


        public CadastroControl()
        {
            InitializeComponent();

            //Cliente
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
            //Carro
            ConfigurarPlaceholder(TxtIdCliente, "Insira o cpf do cliente.");
            ConfigurarPlaceholder(TxtMarcaCarro, "Digite a marca do carro.");
            ConfigurarPlaceholder(TxtModeloCarro, "Digite o modelo do carro.");
            ConfigurarPlaceholder(TxtPlacaCarro, "Digite a placa do carro.");
            ConfigurarPlaceholder(TxtDescricaoProblema, "Digite o prolema do carro.");
            ConfigurarPlaceholder(LinhaIdCarro, "___________________________");
            ConfigurarPlaceholder(linhaMarca, "___________________________");
            ConfigurarPlaceholder(linhaModelo, "___________________________");
            ConfigurarPlaceholder(linhaPlaca, "___________________________");


        }
        private void CadastroControl_Load(object sender, EventArgs e)
        {
            
        }


        private void ConfigurarPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText; // Cor cinza para o texto placeholder

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText; // Cor preta para texto do usuário
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText; // Cor cinza para placeholder
                }
            };
        }

        //Cliente
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
            if (cleanCPF.Length == 11 && cleanCPF.All(char.IsDigit)) // Verifica se tem 11 dígitos e só números
            {
                CPF = cleanCPF; // Atualiza a propriedade CPF com o valor limpo
            }
            else
            {
                CPF = null;
            }
        }


        private void txtCidade_TextChanged_1(object sender, EventArgs e)
        {
            Cidade = txtCidade.Text;
        }

        private void txtEstado_TextChanged_1(object sender, EventArgs e)
        {
            Estado = txtEstado.Text;
        }


        //Carro
        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {
            ID = TxtIdCliente.Text;
        }

        private void TxtModeloCarro_TextChanged(object sender, EventArgs e)
        {
            Modelo = TxtModeloCarro.Text;
        }

        private void TxtMarcaCarro_TextChanged(object sender, EventArgs e)
        {
            Marca = TxtMarcaCarro.Text;
        }

        private void TxtPlacaCarro_TextChanged(object sender, EventArgs e)
        {
            Placa = TxtPlacaCarro.Text;
        }

        private void TxtDescricaoProblema_TextChanged(object sender, EventArgs e)
        {
            Descricao = TxtDescricaoProblema.Text;
        }


        // Validação dos campos Cliente
        private bool ValidarCamposCLiente()
        {

            {
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    MessageBox.Show("O campo Nome é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
                {
                    MessageBox.Show("Digite um Email válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(CPF))
                {
                    MessageBox.Show("O campo CPF é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(Telefone))
                {
                    MessageBox.Show("O campo Telefone é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(CEP))
                {
                    MessageBox.Show("O campo CEP é obrigatório!");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("O campo ID é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;            
            }
            
        }

        // Validação dos campos Carro
        public bool ValidarCamposCarro()
        {

            if (string.IsNullOrWhiteSpace(Descricao))
            {
                MessageBox.Show("O campo descrição é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 

            return true;
        }


        // Botão de cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposCLiente())
                {
                    MessageBox.Show($"Cliente cadastrado com sucesso!\nUse o cpf do cliente como identificação para cadastrar um novo carro!");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao cadastrar o cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpar os campos
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSegundoEmail.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCpfCliente.Clear();
        }
        private void BtnCadastroCarro_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCarro())
            {
                MessageBox.Show($"Carro cadastrado com sucesso!");
                LimparCampos();
            }
            
        }

        private void linhaNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void linhaEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabCliente_Click(object sender, EventArgs e)
        {

        }

        private void linhaCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void linhaCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void linhaEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinhaIdCarro_TextChanged(object sender, EventArgs e)
        {

        }
        private void linhaModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            Telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
        }

        private void linhaTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            CEP = txtCep.Text.Replace("-", "");
        }

        private void linhaCep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
