namespace ExemploUserControl
{
	partial class Itens
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.acao = new System.Windows.Forms.Button();
			this.nomeItem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// acao
			// 
			this.acao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.acao.Location = new System.Drawing.Point(427, 19);
			this.acao.Name = "acao";
			this.acao.Size = new System.Drawing.Size(95, 27);
			this.acao.TabIndex = 0;
			this.acao.Text = "Pronto";
			this.acao.UseVisualStyleBackColor = true;
			this.acao.Click += new System.EventHandler(this.acao_Click);
			// 
			// nomeItem
			// 
			this.nomeItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.nomeItem.AutoSize = true;
			this.nomeItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.nomeItem.Location = new System.Drawing.Point(19, 19);
			this.nomeItem.Name = "nomeItem";
			this.nomeItem.Size = new System.Drawing.Size(0, 13);
			this.nomeItem.TabIndex = 1;
			// 
			// Itens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.Controls.Add(this.nomeItem);
			this.Controls.Add(this.acao);
			this.Name = "Itens";
			this.Size = new System.Drawing.Size(537, 64);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button acao;
		private System.Windows.Forms.Label nomeItem;
	}
}
