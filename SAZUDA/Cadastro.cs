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
            //Carro
            ConfigurarPlaceholder(TxtIdCliente, "Insira o código Id passado.");
            ConfigurarPlaceholder(TxtMarcaCarro, "Digite a marca do carro.");
            ConfigurarPlaceholder(TxtModeloCarro, "Digite o modelo do carro.");
            ConfigurarPlaceholder(TxtPlacaCarro, "Digite a placa do carro.");
            ConfigurarPlaceholder(TxtDescricaoProblema, "Digite o prolema do carro.");

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

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CPF = mskCPF.Text.Replace(".", "").Replace("-", "");    
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CEP = mskCEP.Text.Replace("-", "");
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
                    Random random = new Random();
                    int NumeroCliente = random.Next(1000, 1000000);

                    MessageBox.Show($"Cliente cadastrado com sucesso!\n O número de identificação do cliente: {NumeroCliente}");
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
            mskCEP.Clear();
            mskTelefone.Clear();
            mskCPF.Clear();
        }
        private void BtnCadastroCarro_Click(object sender, EventArgs e)
        {
            if (ValidarCamposCarro())
            {
                MessageBox.Show($"Carro cadastrado com sucesso!");
                LimparCampos();
            }
            
        }
    }
}
