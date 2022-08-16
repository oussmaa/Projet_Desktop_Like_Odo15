
namespace PFE.Users
{
	partial class GestionSaller
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
			this.button1 = new System.Windows.Forms.Button();
			this.namee = new System.Windows.Forms.TextBox();
			this.ph = new System.Windows.Forms.TextBox();
			this.em = new System.Windows.Forms.TextBox();
			this.adrr = new System.Windows.Forms.TextBox();
			this.remk = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(654, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 23);
			this.button1.TabIndex = 23;
			this.button1.Text = "Add Saller";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// namee
			// 
			this.namee.Location = new System.Drawing.Point(57, 71);
			this.namee.Name = "namee";
			this.namee.Size = new System.Drawing.Size(100, 22);
			this.namee.TabIndex = 22;
			// 
			// ph
			// 
			this.ph.Location = new System.Drawing.Point(508, 71);
			this.ph.Name = "ph";
			this.ph.Size = new System.Drawing.Size(100, 22);
			this.ph.TabIndex = 21;
			// 
			// em
			// 
			this.em.Location = new System.Drawing.Point(353, 71);
			this.em.Name = "em";
			this.em.Size = new System.Drawing.Size(100, 22);
			this.em.TabIndex = 20;
			// 
			// adrr
			// 
			this.adrr.Location = new System.Drawing.Point(201, 71);
			this.adrr.Name = "adrr";
			this.adrr.Size = new System.Drawing.Size(100, 22);
			this.adrr.TabIndex = 19;
			// 
			// remk
			// 
			this.remk.Location = new System.Drawing.Point(668, 71);
			this.remk.Name = "remk";
			this.remk.Size = new System.Drawing.Size(100, 22);
			this.remk.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(82, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(222, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "Adress";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(375, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "E-mail";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(527, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "Phone";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(692, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Remark";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.email,
            this.phone,
            this.Adress,
            this.Remark});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(32, 181);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(736, 242);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// Id
			// 
			this.Id.Text = "Id";
			// 
			// Name
			// 
			this.Name.Text = "Name";
			// 
			// email
			// 
			this.email.Text = "E-mail";
			// 
			// phone
			// 
			this.phone.Text = "Phone";
			// 
			// Adress
			// 
			this.Adress.Text = "Adress";
			// 
			// Remark
			// 
			this.Remark.Text = "Remark";
			this.Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// GestionSaller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.namee);
			this.Controls.Add(this.ph);
			this.Controls.Add(this.em);
			this.Controls.Add(this.adrr);
			this.Controls.Add(this.remk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		//	this.Name = "GestionSaller";
			this.Text = "GestionSaller";
			this.Load += new System.EventHandler(this.GestionSaller_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox namee;
		private System.Windows.Forms.TextBox ph;
		private System.Windows.Forms.TextBox em;
		private System.Windows.Forms.TextBox adrr;
		private System.Windows.Forms.TextBox remk;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Id;
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ColumnHeader email;
		private System.Windows.Forms.ColumnHeader phone;
		private System.Windows.Forms.ColumnHeader Adress;
		private System.Windows.Forms.ColumnHeader Remark;
	}
}