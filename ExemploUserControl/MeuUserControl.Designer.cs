namespace ExemploUserControl
{
	partial class MeuUserControl
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
			this.btnAcao = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAcao
			// 
			this.btnAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAcao.Location = new System.Drawing.Point(331, 3);
			this.btnAcao.Name = "btnAcao";
			this.btnAcao.Size = new System.Drawing.Size(75, 26);
			this.btnAcao.TabIndex = 0;
			this.btnAcao.Text = "Ação";
			this.btnAcao.UseVisualStyleBackColor = true;
			this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(3, 31);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(0, 13);
			this.label.TabIndex = 1;
			// 
			// MeuUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Controls.Add(this.label);
			this.Controls.Add(this.btnAcao);
			this.Name = "MeuUserControl";
			this.Size = new System.Drawing.Size(409, 74);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAcao;
		private System.Windows.Forms.Label label;
	}
}
