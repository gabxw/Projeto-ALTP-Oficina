using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SAZUDA
{
    public partial class CadastroForm : Form
    {
        // Propriedades da classe para armazenar os dados
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

        private readonly string caminhoArquivo = "clientes.txt";

        public CadastroForm()
        {
            InitializeComponent();
            escoderControles();

            ConfigurarPlaceholder(txtNome, "Digite seu nome");
            ConfigurarPlaceholder(txtEmail, "Digite seu email");
            ConfigurarPlaceholder(txtSegundoEmail, "Digite o segundo email");
            ConfigurarPlaceholder(txtCidade, "Digite sua cidade");
            ConfigurarPlaceholder(txtEstado, "Digite seu estado");


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

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            // Cria o arquivo se não existir
            if (!File.Exists(caminhoArquivo))
                File.Create(caminhoArquivo).Close();
        }

        private void escoderControles()
        {
            pictureBox2.Visible = false;
            txtNome.Visible = false;
            txtEmail.Visible = false;
            txtSegundoEmail.Visible = false;
            txtCidade.Visible = false;
            txtEstado.Visible = false;
            mskCPF.Visible = false;
            mskTelefone.Visible = false;
            mskCEP.Visible = false;
            btnCadastrar.Visible = false;
        }

        private void MostrarControles()
        {
            pictureBox2.Visible = true;
            txtNome.Visible = true;
            txtEmail.Visible = true;
            txtSegundoEmail.Visible = true;
            txtCidade.Visible = true;
            txtEstado.Visible = true;
            mskCPF.Visible = true;
            mskTelefone.Visible = true;
            mskCEP.Visible = true;
            btnCadastrar.Visible = true;
        }

        // Eventos dos campos
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Email = txtEmail.Text;
        }

        private void txtSegundoEmail_TextChanged(object sender, EventArgs e)
        {
            SegundoEmail = txtSegundoEmail.Text;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            Cidade = txtCidade.Text;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            Estado = txtEstado.Text;
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            CEP = mskCEP.Text.Replace("-", ""); // Remove a máscara
        }

        private void mskTelefone_TextChanged(object sender, EventArgs e)
        {
            Telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""); // Remove a máscara
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            CPF = mskCPF.Text.Replace(".", "").Replace("-", ""); // Remove a máscara
        }

        // Validação dos campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessageBox.Show("O campo Nome é obrigatório!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                MessageBox.Show("Digite um Email válido!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(CPF) || !ValidadorCPF.Validar(CPF))
            {
                MessageBox.Show("O CPF informado é inválido!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Telefone))
            {
                MessageBox.Show("O campo Telefone é obrigatório!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(CEP))
            {
                MessageBox.Show("O campo CEP é obrigatório!");
                return false;
            }
            return true;
        }

        // Salvar os dados em arquivo
        private void SalvarDados()
        {
            string linha = $"{Nome},{Email},{SegundoEmail},{Cidade},{Estado},{CPF},{Telefone},{CEP}";
            File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
        }

        // Botão de cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                SalvarDados();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparCampos();
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

            Nome = Email = SegundoEmail = Cidade = Estado = CEP = Telefone = CPF = null;
        }

        private void lblCadastrarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome atual: {Nome ?? "Não preenchido"}");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblCadNovoCliente_Click(object sender, EventArgs e)
        {
            MostrarControles();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm(); // Criando uma instância do novo formulário
            mainform.Show(); // Exibindo a nova tela
            this.Hide();
        }
    }

    // Classe de validação de CPF 
    public class ValidadorCPF
    {
        public static bool Validar(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11 || EhSequenciaRepetida(cpf))
                return false;

            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cpfSemDigitos = cpf.Substring(0, 9);
            int digito1 = CalcularDigito(cpfSemDigitos, multiplicadoresPrimeiroDigito);
            int digito2 = CalcularDigito(cpfSemDigitos + digito1, multiplicadoresSegundoDigito);

            return cpf.EndsWith($"{digito1}{digito2}");
        }

        private static bool EhSequenciaRepetida(string cpf)
        {
            return cpf.All(c => c == cpf[0]);
        }

        private static int CalcularDigito(string baseCpf, int[] multiplicadores)
        {
            int soma = 0;
            for (int i = 0; i < multiplicadores.Length; i++)
            {
                soma += int.Parse(baseCpf[i].ToString()) * multiplicadores[i];
            }
            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}