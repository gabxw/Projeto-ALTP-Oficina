using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SAZUDA
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class TelaLogin : Form
    {
        public string ID { get; set; }
        public string senha { get; set; }

        public TelaLogin()
        {
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
            if (ID == "13042006" || senha == "teste123")
            {

               
                this.Hide(); // Ocultando a tela de login
                
            }
            else
            {
                MessageBox.Show("O id ou a senha está errado!");
            }
        }
    }
}