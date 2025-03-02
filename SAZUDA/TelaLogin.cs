using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAZUDA
{
    public partial class TelaLogin : Form
    {

        public string Usuario { get; set; }
        public string Senha { get; set; }

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LinhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdUsuario_TextChanged(object sender, EventArgs e)
        {
            Usuario = IdUsuario.Text;
        }

        private void IdSenha_TextChanged(object sender, EventArgs e)
        {
            Senha = IdSenha.Text.Replace("*", "").Replace("_", "").Trim().Replace(" ", "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginTemporario = "13042006";
            string senhaTemporaria = "teste123";

            if (Usuario != loginTemporario && Senha != senhaTemporaria)
            {
                MessageBox.Show("O id ou a senha está incorreto!");
                
            }
            else
            {
                TelaHome telaHome = new TelaHome(this); // Passa a instância atual de TelaLogin
                telaHome.Show();
                this.Hide(); // Esconde TelaLogin
            }
        }
    }
}
