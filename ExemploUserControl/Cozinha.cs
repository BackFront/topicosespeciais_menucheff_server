using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUDP;

namespace ExemploUserControl
{
	public partial class Cozinha : Form
	{
		private UDPSocket socket;
		private Dictionary<int, string> item = new Dictionary<int, string>();
		private Balcao balcao;

		public Cozinha()
		{
			InitializeComponent();
			socket = new UDPSocket(receive, 6200);

			item.Add(10, "Vodka");
			item.Add(50, "Cerveja");
			item.Add(80, "Tequila");
			item.Add(55, "Sakeh");
			item.Add(18, "Frango a Passarinho");
			item.Add(12, "Bolovo");
			item.Add(15, "Torresmo");
			item.Add(90, "Caipirinha");
			item.Add(20, "Brie");
			item.Add(23, "Lasanha");
			item.Add(4, "Suco");
			item.Add(5, "Sorvete");
			item.Add(100, "Bala de Hortelã");
			item.Add(98, "Café");
			item.Add(102, "Temaki");
			item.Add(110, "Yakult");
			item.Add(120, "Fritas");
			item.Add(115, "Rabada");
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			balcao = new Balcao();

			balcao.Show();
		}

		private void removerItem(object sender, EventArgs e)
		{
			Itens pedidoAcao = (Itens)sender;
			pedidoAcao.btnAcao -= removerItem;
			panel.Controls.Remove(pedidoAcao);
			balcao.recebeItem(pedidoAcao);
			pedidoAcao.btnAcao += removerItemDeVez;
		}

		private void removerItemDeVez(object sender, EventArgs e)
		{
			Itens pedidoAcao = (Itens)sender;
			pedidoAcao.Parent.Controls.Remove(pedidoAcao);

		}


		public void receive(byte[] buffer, int size, string ip, int port)
		{
			var j = 2;
			for (int i = 0; i < buffer[1]; i++)
			{
				try
				{
					Itens pedido = new Itens();
					pedido.Mensagem = "Pedido da mesa " + buffer[0] + " Item : " + item[buffer[j]];
					pedido.btnAcao += removerItem;
					panel.Controls.Add(pedido);
					
				}
				catch (Exception ex)
				{
					MessageBox.Show("Item inesistente");
				}
				j++;
			}
		}





	}
}
