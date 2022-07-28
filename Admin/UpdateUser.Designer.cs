
namespace PFE.Admin
{
	partial class UpdateUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
			this.roles = new System.Windows.Forms.ComboBox();
			this.Adduser = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.lastname = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// roles
			// 
			this.roles.FormattingEnabled = true;
			this.roles.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.roles.Location = new System.Drawing.Point(467, 315);
			this.roles.Name = "roles";
			this.roles.Size = new System.Drawing.Size(121, 24);
			this.roles.TabIndex = 18;
			// 
			// Adduser
			// 
			this.Adduser.BackColor = System.Drawing.Color.White;
			this.Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Adduser.ForeColor = System.Drawing.Color.Blue;
			this.Adduser.Location = new System.Drawing.Point(838, 311);
			this.Adduser.Name = "Adduser";
			this.Adduser.Size = new System.Drawing.Size(115, 32);
			this.Adduser.TabIndex = 17;
			this.Adduser.Text = "Update";
			this.Adduser.UseVisualStyleBackColor = false;
			this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(656, 317);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(123, 22);
			this.password.TabIndex = 16;
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(282, 317);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(132, 22);
			this.lastname.TabIndex = 15;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(114, 317);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(112, 22);
			this.name.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(277, 269);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 29);
			this.label4.TabIndex = 13;
			this.label4.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(484, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 29);
			this.label3.TabIndex = 12;
			this.label3.Text = "Roles";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(651, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 29);
			this.label2.TabIndex = 11;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(121, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 29);
			this.label1.TabIndex = 10;
			this.label1.Text = "Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(416, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 29);
			this.label5.TabIndex = 19;
			this.label5.Text = "UPDATE USER";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(982, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(46, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 120;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// UpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1056, 459);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.roles);
			this.Controls.Add(this.Adduser);
			this.Controls.Add(this.password);
			this.Controls.Add(this.lastname);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UpdateUser";
			this.Text = "UpdateUser";
			this.Load += new System.EventHandler(this.UpdateUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox roles;
		private System.Windows.Forms.Button Adduser;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox lastname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.TextBox name;
	}
}