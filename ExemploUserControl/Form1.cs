using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploUserControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			for (int i = 0; i < 20; i++)
			{
				MeuUserControl c = new MeuUserControl();
				c.Mensagem = i.ToString();
				c.BotaoClicado += C_BotaoClicado;
				panel.Controls.Add(c);
			}
		}

		private void C_BotaoClicado(object sender, EventArgs e)
		{
			MeuUserControl c = (MeuUserControl)sender;
			//MessageBox.Show(c.Mensagem);
			panel.Controls.Remove(c);
		}

		private void meuUserControl1_BotaoClicado(object sender, EventArgs e)
		{
			MessageBox.Show("Funciona!");
		}
	}
}
