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
	public partial class Cozinha : Form
	{
		public Cozinha()
		{
			InitializeComponent();			
			for(int i=0; i<10; ++i)
			{
				Itens pedido = new Itens();
				pedido.Mensagem = "oi - "+i;
				pedido.btnAcao += removerItem;
				panel.Controls.Add(pedido);
			}
		}

		private void removerItem(object sender, EventArgs e)
		{
			Itens pedidoAcao = (Itens)sender;
			panel.Controls.Remove(pedidoAcao);
		}
	}
}
