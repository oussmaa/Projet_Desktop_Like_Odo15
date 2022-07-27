
namespace PFE.Users
{
	partial class GestionLabel
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
			this.gestusers.Location = new System.Drawing.Point(263, 149);
			this.gestusers.Name = "gestusers";
			this.gestusers.Size = new System.Drawing.Size(101, 23);
			this.gestusers.TabIndex = 1;
			this.gestusers.Text = "gestionlabel";
			this.gestusers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.gestusers.UseVisualStyleBackColor = true;
			// 
			// GestionLabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gestusers);
			this.Name = "GestionLabel";
			this.Text = "GestionLabel";
			this.Load += new System.EventHandler(this.GestionLabel_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button gestusers;
	}
}