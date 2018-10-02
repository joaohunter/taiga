using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taiga
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}		
		public void listaDir(){
			DirectoryInfo d = new DirectoryInfo(@"C:/Program Files/taiga/scripts/");//Assuming Test is your Folder
			FileInfo[] Files = d.GetFiles("*.bat"); //Getting Text files
			foreach (FileInfo file in Files)
			{
				textBox2.AppendText(file.Name + "\n");
			}
			
		}
		public void exec(string comando){
			try
			{
				System.Diagnostics.Process.Start("C:/Program Files/taiga/scripts/" + comando + ".bat");
				textBox2.AppendText("Desejo realizado!");
			}
			catch (Exception)
			{
				textBox2.AppendText("Não posso fazer isso!");
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			textBox2.AppendText("Olá, eu sou a Taiga, o bot baseado em linhas de comando da HS. Posso realizar desejos infinitos. Qual é o seu desejo, mestre? \n");
		}

		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter){
				e.Handled = true;
				string comando = textBox1.Text;
				System.Diagnostics.Debug.WriteLine(comando);
				textBox2.AppendText(textBox1.Text + "\n");
				textBox1.Text = null;
				textBox1.Focus();
				switch (comando)
				{
					case "open-dir":
						string path = @"C:/Program Files/taiga/scripts";
						System.Diagnostics.Process.Start(path);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "help":
						Console.WriteLine("Case 1");
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "list-cmd":
						listaDir();
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "exit":
						Application.Exit();
						break;
					case "quit":
						Application.Exit();
						break;
					default:
						exec(comando);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
				}
			}
		}

	}
}
