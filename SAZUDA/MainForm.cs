/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 25/02/2025
 * Time: 08:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
		public MainForm()
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
        }

	}
}
