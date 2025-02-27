using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAZUDA
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public string ID { get; set; }
        public string senha { get; set; }

<<<<<<< HEAD
			InitializeComponent();		
			
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
            CadastroForm cadastro = new CadastroForm(); // Criando uma instância do novo formulário
            cadastro.Show(); // Exibindo a nova tela
            this.Hide(); // Ocultando a tela de login
=======
        public MainForm()
        {
            InitializeComponent();
>>>>>>> 5f9756
        }

        void Label1Click(object sender, EventArgs e)
        {

        }

        void PictureBox1Click(object sender, EventArgs e)
        {

        }

        void TextBox1TextChanged(object sender, EventArgs e)
        {
            ID = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            senha = textBox2.Text;
        }

        void MainFormLoad(object sender, EventArgs e)
        {

        }

        void BtnLoginClick(object sender, EventArgs e)
        {
            if (ID != "13042006" || senha != "teste123")
            {
                MessageBox.Show("O id ou a senha está errado!");
            }
            else
            {
                CadastroForm cadastro = new CadastroForm(); // Criando uma instância do novo formulário
                cadastro.Show(); // Exibindo a nova tela
                this.Hide(); // Ocultando a tela de login
            }
        }
    }
}