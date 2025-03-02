using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAZUDA
{
    public partial class TelaHome: Form
    {
        public TelaHome()
        {
            InitializeComponent();
            CadastrarControl.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MoveSidePanel(Button btn)
        {
            SidePainel.Parent = BtnCadastrar.Parent;
            

            // Verifica se SidePainel e o botão estão dentro do mesmo container
            if (SidePainel.Parent == btn.Parent)
            {
                SidePainel.Top = btn.Top - 15; // Move dentro do mesmo painel
            }
            else
            {
                SidePainel.Top = btn.Top - btn.Parent.Top; // Ajusta caso estejam em containers diferentes
            }
        }

        

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BtnCadastrar);
            CadastrarControl.BringToFront();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BtnConsultar);
            consultar1.BringToFront();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin mainform = new TelaLogin(); // Criando uma instância do novo formulário
            mainform.Show(); // Exibindo a nova tela
            this.Hide();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BtnFornecedor);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(BtnCancelar);
        }

        private void CadastrarControl_Load(object sender, EventArgs e)
        {

        }

        private void consultar1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaLogin mainform = new TelaLogin(); // Criando uma instância do novo formulário
            mainform.Show(); // Exibindo a nova tela
            this.Hide();
        }
    }
}
