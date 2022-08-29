
namespace PFE.Users
{
	partial class GestionAdress
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lont = new System.Windows.Forms.TextBox();
			this.lat = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.latt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lontt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(233, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(533, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Longtitude";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(370, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Latitude";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(722, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 34);
			this.button1.TabIndex = 24;
			this.button1.Text = "Add Adress";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lont
			// 
			this.lont.Location = new System.Drawing.Point(536, 211);
			this.lont.Name = "lont";
			this.lont.Size = new System.Drawing.Size(100, 22);
			this.lont.TabIndex = 25;
			// 
			// lat
			// 
			this.lat.Location = new System.Drawing.Point(373, 211);
			this.lat.Name = "lat";
			this.lat.Size = new System.Drawing.Size(100, 22);
			this.lat.TabIndex = 26;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(227, 211);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(100, 22);
			this.name.TabIndex = 27;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.namee,
            this.latt,
            this.lontt});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(200, 265);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(636, 202);
			this.listView1.TabIndex = 28;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// id
			// 
			this.id.Text = "Id";
			this.id.Width = 113;
			// 
			// namee
			// 
			this.namee.Text = "Name";
			this.namee.Width = 113;
			// 
			// latt
			// 
			this.latt.Text = "Latitude";
			this.latt.Width = 124;
			// 
			// lontt
			// 
			this.lontt.Text = "Longtitude";
			this.lontt.Width = 142;
			// 
			// GestionAdress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1009, 627);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.name);
			this.Controls.Add(this.lat);
			this.Controls.Add(this.lont);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GestionAdress";
			this.Text = "GestionAdress";
			this.Load += new System.EventHandler(this.GestionAdress_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox lont;
		private System.Windows.Forms.TextBox lat;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader namee;
		private System.Windows.Forms.ColumnHeader latt;
		private System.Windows.Forms.ColumnHeader lontt;
	}
}