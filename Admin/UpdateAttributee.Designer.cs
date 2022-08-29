
namespace PFE.Admin
{
	partial class UpdateAttributee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAttributee));
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.Adduser = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(359, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(267, 29);
			this.label5.TabIndex = 20;
			this.label5.Text = "UPDATE ATTRIBUTEE";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(423, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 29);
			this.label1.TabIndex = 24;
			this.label1.Text = "Type";
			// 
			// type
			// 
			this.type.FormattingEnabled = true;
			this.type.Items.AddRange(new object[] {
            "Date",
            "Text",
            "Radio",
            "Checkbox",
            "INT"});
			this.type.Location = new System.Drawing.Point(428, 226);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(161, 24);
			this.type.TabIndex = 23;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(138, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 29);
			this.label2.TabIndex = 22;
			this.label2.Text = "Name";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(143, 228);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(156, 22);
			this.name.TabIndex = 21;
			// 
			// Adduser
			// 
			this.Adduser.BackColor = System.Drawing.Color.White;
			this.Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Adduser.ForeColor = System.Drawing.Color.Blue;
			this.Adduser.Location = new System.Drawing.Point(737, 226);
			this.Adduser.Name = "Adduser";
			this.Adduser.Size = new System.Drawing.Size(115, 32);
			this.Adduser.TabIndex = 25;
			this.Adduser.Text = "Update";
			this.Adduser.UseVisualStyleBackColor = false;
			this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(944, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(46, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 121;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// UpdateAttributee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1002, 450);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.Adduser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.type);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UpdateAttributee";
			this.Text = "UpdateAttributee";
			this.Load += new System.EventHandler(this.UpdateAttributee_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox type;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Button Adduser;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}