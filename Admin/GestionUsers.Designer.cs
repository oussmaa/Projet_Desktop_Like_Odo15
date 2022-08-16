
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.lastname = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.Adduser = new System.Windows.Forms.Button();
			this.roles = new System.Windows.Forms.ComboBox();
			this.listView = new System.Windows.Forms.ListView();
			this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Last_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Passwordd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.delete = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(152, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(682, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(515, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Roles";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(308, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Last Name";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(145, 104);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(112, 22);
			this.name.TabIndex = 4;
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(313, 104);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(132, 22);
			this.lastname.TabIndex = 6;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(687, 104);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(123, 22);
			this.password.TabIndex = 7;
			this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
			// 
			// Adduser
			// 
			this.Adduser.BackColor = System.Drawing.Color.White;
			this.Adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Adduser.ForeColor = System.Drawing.Color.Blue;
			this.Adduser.Location = new System.Drawing.Point(869, 98);
			this.Adduser.Name = "Adduser";
			this.Adduser.Size = new System.Drawing.Size(115, 32);
			this.Adduser.TabIndex = 8;
			this.Adduser.Text = "Add User";
			this.Adduser.UseVisualStyleBackColor = false;
			this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
			// 
			// roles
			// 
			this.roles.FormattingEnabled = true;
			this.roles.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.roles.Location = new System.Drawing.Point(498, 102);
			this.roles.Name = "roles";
			this.roles.Size = new System.Drawing.Size(121, 24);
			this.roles.TabIndex = 9;
			this.roles.SelectedIndexChanged += new System.EventHandler(this.roles_SelectedIndexChanged);
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namee,
            this.Last_Name,
            this.Role,
            this.Passwordd,
            this.id});
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(108, 179);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(927, 381);
			this.listView.TabIndex = 10;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// Namee
			// 
			this.Namee.Text = "Name";
			this.Namee.Width = 213;
			// 
			// Last_Name
			// 
			this.Last_Name.Text = "Last Name";
			this.Last_Name.Width = 187;
			// 
			// Role
			// 
			this.Role.Text = "Roles";
			this.Role.Width = 75;
			// 
			// Passwordd
			// 
			this.Passwordd.Text = "Password";
			this.Passwordd.Width = 170;
			// 
			// id
			// 
			this.id.Text = "Id";
			this.id.Width = 134;
			// 
			// delete
			// 
			this.delete.BackColor = System.Drawing.Color.White;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.ForeColor = System.Drawing.Color.Blue;
			this.delete.Location = new System.Drawing.Point(92, 605);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(115, 32);
			this.delete.TabIndex = 11;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = false;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.Color.White;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.ForeColor = System.Drawing.Color.Blue;
			this.update.Location = new System.Drawing.Point(904, 596);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(115, 32);
			this.update.TabIndex = 12;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// GestionUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1128, 688);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.roles);
			this.Controls.Add(this.Adduser);
			this.Controls.Add(this.password);
			this.Controls.Add(this.lastname);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GestionUsers";
			this.Text = "GestionUsers";
			this.Load += new System.EventHandler(this.GestionUsers_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox lastname;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button Adduser;
		private System.Windows.Forms.ComboBox roles;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader Namee;
		private System.Windows.Forms.ColumnHeader Last_Name;
		private System.Windows.Forms.ColumnHeader Role;
		private System.Windows.Forms.ColumnHeader Passwordd;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.ColumnHeader id;
	}
}