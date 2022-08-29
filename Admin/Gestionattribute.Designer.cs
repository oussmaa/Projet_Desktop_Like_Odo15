
namespace PFE.Admin
{
	partial class Gestionattribute
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
			this.name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Typpe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.update = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(760, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(195, 184);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(156, 22);
			this.name.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(190, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name";
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
			this.type.Location = new System.Drawing.Point(480, 182);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(161, 24);
			this.type.TabIndex = 4;
			this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(475, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Type";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Namee,
            this.Typpe});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(116, 289);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(834, 275);
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// id
			// 
			this.id.Text = "Id";
			this.id.Width = 164;
			// 
			// Namee
			// 
			this.Namee.Text = "Name";
			this.Namee.Width = 240;
			// 
			// Typpe
			// 
			this.Typpe.Text = "Type";
			this.Typpe.Width = 270;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(418, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(241, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Gestion Of Attribute";
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.Color.White;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.ForeColor = System.Drawing.Color.Blue;
			this.update.Location = new System.Drawing.Point(835, 603);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(115, 32);
			this.update.TabIndex = 13;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// Gestionattribute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1082, 719);
			this.Controls.Add(this.update);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.type);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Gestionattribute";
			this.Text = "Gestionattribute";
			this.Load += new System.EventHandler(this.Gestionattribute_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox type;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader Namee;
		private System.Windows.Forms.ColumnHeader Typpe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button update;
	}
}