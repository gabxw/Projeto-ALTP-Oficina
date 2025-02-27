using System;
using System.Windows.Forms;

namespace SAZUDA
{
    public partial class CadastroForm : Form
    {
        // Propriedades da classe para armazenar os dados
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }

        public CadastroForm()
        {
            InitializeComponent();
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
        }

        private void lblCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();

            txtNome.Text = cadastro.Nome;

            cadastro.Show(); // Abre a tela de cadastro
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(txtNome));
        }
    }
}
