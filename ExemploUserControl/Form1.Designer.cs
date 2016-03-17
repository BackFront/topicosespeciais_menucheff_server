namespace ExemploUserControl
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.meuUserControl1 = new ExemploUserControl.MeuUserControl();
			this.panel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// meuUserControl1
			// 
			this.meuUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.meuUserControl1.Location = new System.Drawing.Point(12, 12);
			this.meuUserControl1.Mensagem = "Oi!!!";
			this.meuUserControl1.Name = "meuUserControl1";
			this.meuUserControl1.Size = new System.Drawing.Size(409, 56);
			this.meuUserControl1.TabIndex = 0;
			this.meuUserControl1.BotaoClicado += new System.EventHandler(this.meuUserControl1_BotaoClicado);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.AutoScroll = true;
			this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panel.Location = new System.Drawing.Point(12, 74);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(453, 323);
			this.panel.TabIndex = 1;
			this.panel.WrapContents = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 409);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.meuUserControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private MeuUserControl meuUserControl1;
		private System.Windows.Forms.FlowLayoutPanel panel;
	}
}

