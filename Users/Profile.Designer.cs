
namespace PFE.Users
{
	partial class Profile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
			this.imageprofile = new System.Windows.Forms.PictureBox();
			this.prof = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.lastname = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imageprofile)).BeginInit();
			this.SuspendLayout();
			// 
			// imageprofile
			// 
			this.imageprofile.Image = ((System.Drawing.Image)(resources.GetObject("imageprofile.Image")));
			this.imageprofile.Location = new System.Drawing.Point(42, 123);
			this.imageprofile.Margin = new System.Windows.Forms.Padding(4);
			this.imageprofile.Name = "imageprofile";
			this.imageprofile.Size = new System.Drawing.Size(150, 105);
			this.imageprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageprofile.TabIndex = 123;
			this.imageprofile.TabStop = false;
			this.imageprofile.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// prof
			// 
			this.prof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.prof.Location = new System.Drawing.Point(632, 321);
			this.prof.Name = "prof";
			this.prof.Size = new System.Drawing.Size(113, 34);
			this.prof.TabIndex = 1;
			this.prof.Text = "Update";
			this.prof.UseVisualStyleBackColor = true;
			this.prof.Click += new System.EventHandler(this.prof_Click);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(588, 185);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(123, 22);
			this.password.TabIndex = 132;
			this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(396, 185);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(132, 22);
			this.lastname.TabIndex = 131;
			this.lastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(237, 185);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(112, 22);
			this.name.TabIndex = 130;
			this.name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(401, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 29);
			this.label4.TabIndex = 129;
			this.label4.Text = "Last Name";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(583, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 29);
			this.label3.TabIndex = 128;
			this.label3.Text = "Password";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(249, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 29);
			this.label5.TabIndex = 127;
			this.label5.Text = "Name";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.password);
			this.Controls.Add(this.lastname);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.imageprofile);
			this.Controls.Add(this.prof);
			this.ForeColor = System.Drawing.Color.Navy;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Profile";
			this.Text = "Profile";
			this.Load += new System.EventHandler(this.Profile_Load);
			((System.ComponentModel.ISupportInitialize)(this.imageprofile)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imageprofile;
		private System.Windows.Forms.Button prof;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox lastname;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
	}
}