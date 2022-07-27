
namespace PFE.Admin
{
	partial class GestionUsers
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
			this.gestusers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gestusers
			// 
			this.gestusers.Location = new System.Drawing.Point(296, 153);
			this.gestusers.Name = "gestusers";
			this.gestusers.Size = new System.Drawing.Size(101, 23);
			this.gestusers.TabIndex = 0;
			this.gestusers.Text = "gestionusers";
			this.gestusers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.gestusers.UseVisualStyleBackColor = true;
			// 
			// GestionUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gestusers);
			this.Name = "GestionUsers";
			this.Text = "GestionUsers";
			this.Load += new System.EventHandler(this.GestionUsers_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button gestusers;
	}
}