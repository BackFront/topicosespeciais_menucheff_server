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
	public partial class Itens : UserControl
	{
		public event EventHandler btnAcao;

		public Itens()
		{
			InitializeComponent();
		}

		public string Mensagem
		{
			get
			{
				return nomeItem.Text;
			}
			set
			{
				nomeItem.Text = value;
			}
		}

		private void acao_Click(object sender, EventArgs e)
		{
			if (btnAcao != null)
				btnAcao(this, e);
		}
	}
}
