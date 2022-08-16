
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Categoryy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lontt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.name = new System.Windows.Forms.TextBox();
			this.cat = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.category = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorr = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.namee,
            this.Categoryy,
            this.lontt});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(82, 195);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(636, 202);
			this.listView1.TabIndex = 33;
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
			// Categoryy
			// 
			this.Categoryy.Text = "Categoryy";
			this.Categoryy.Width = 124;
			// 
			// lontt
			// 
			this.lontt.Text = "Color";
			this.lontt.Width = 142;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(82, 54);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(100, 22);
			this.name.TabIndex = 32;
			// 
			// cat
			// 
			this.cat.Location = new System.Drawing.Point(223, 54);
			this.cat.Name = "cat";
			this.cat.Size = new System.Drawing.Size(100, 22);
			this.cat.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(604, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 34);
			this.button1.TabIndex = 29;
			this.button1.Text = "Add Label";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// category
			// 
			this.category.AutoSize = true;
			this.category.Location = new System.Drawing.Point(239, 24);
			this.category.Name = "category";
			this.category.Size = new System.Drawing.Size(63, 17);
			this.category.TabIndex = 36;
			this.category.Text = "category";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(409, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 35;
			this.label2.Text = "color";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 34;
			this.label1.Text = "Name";
			// 
			// colorr
			// 
			this.colorr.Location = new System.Drawing.Point(391, 54);
			this.colorr.Name = "colorr";
			this.colorr.Size = new System.Drawing.Size(119, 23);
			this.colorr.TabIndex = 37;
			this.colorr.Text = "Chose Color";
			this.colorr.UseVisualStyleBackColor = true;
			this.colorr.Click += new System.EventHandler(this.button2_Click);
			// 
			// GestionLabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.colorr);
			this.Controls.Add(this.category);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.name);
			this.Controls.Add(this.cat);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GestionLabel";
			this.Text = "GestionLabel";
			this.Load += new System.EventHandler(this.GestionLabel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader namee;
		private System.Windows.Forms.ColumnHeader Categoryy;
		private System.Windows.Forms.ColumnHeader lontt;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox cat;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label category;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button colorr;
	}
}