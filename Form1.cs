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
		
		private PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); 
		
		string ajuda = "Como assim desejo? Um 'desejo' é um comando que sei executar. Além dos que eu já sei, posso aprender outros comandos. Para isso basta criar um arquivo .bat e colocá-lo na minha pasta de scripts, o nome dele será o comando. Simples, né?";

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
			textBox2.AppendText("Olá, eu sou a Taiga, um bot baseado em linhas de comando que pode realizar desejos. Qual é o seu desejo, mestre? \n");
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
					case "-s":
						string path = @"C:/Program Files/taiga/scripts";
						System.Diagnostics.Process.Start(path);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "-h":
						textBox2.AppendText(ajuda);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "-i":
						textBox2.AppendText(ajuda);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "-l":
						listaDir();
						textBox2.AppendText(textBox1.Text + "\n");
						break;
					case "-e":
						Application.Exit();
						break;
					case "-q":
						Application.Exit();
						break;
					default:
						exec(comando);
						textBox2.AppendText(textBox1.Text + "\n");
						break;
				}
			}
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show("-h ou -i : mostra o texto de ajuda \n -l : lista os comandos (diretório de scripts) \n -s : abre o diretório de scripts \n -q ou -e: sai do programa", "Lista de comandos");
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			PerformanceCounter cpuCounter;
			PerformanceCounter ramCounter;
			cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); 
			ramCounter = new PerformanceCounter("Memory", "Available MBytes");
			string cpuusage = cpuCounter.NextValue()+"%";
			string avilableram = ramCounter.NextValue()+"MB";
			label3.Text = this.theCPUCounter.NextValue().ToString();
			label4.Text = avilableram;
		}
	}
}
