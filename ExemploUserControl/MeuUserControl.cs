using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploUserControl
{
	public partial class MeuUserControl : UserControl
	{
		public event EventHandler BotaoClicado;

		public MeuUserControl()
		{
			InitializeComponent();
		}

		public void MeuMetodo()
		{
			label.Text = DateTime.Now.ToString();
		}

		public string Mensagem
		{
			get
			{
				return label.Text;
			}
			set
			{
				label.Text = value;
            }
		}

		private void btnAcao_Click(object sender, EventArgs e)
		{
			if (BotaoClicado != null)
				BotaoClicado(this, e);
        }
	}
}
