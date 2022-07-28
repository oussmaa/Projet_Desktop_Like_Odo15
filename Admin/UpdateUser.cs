using MySql.Data.MySqlClient;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.Admin
{
	public partial class UpdateUser : Form
	{
		string Id;
		public UpdateUser(User user)
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;


	

			InitializeComponent();
			this.Id = "";
			this.Id = user.Id;
			this.name.Text = user.Name;
			this.lastname.Text = user.LasteName;
			this.roles.Text = user.Roles;
			this.password.Text = user.Password; 
		}

		private void UpdateUser_Load(object sender, EventArgs e)
		{

		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Hide();

		}

		private void Adduser_Click(object sender, EventArgs e)
		{
			if (name.Text != "" && lastname.Text != "" && roles.Text != "" && password.Text != "")
			{
			 string query = "UPDATE users SET name=@name,lastname=@lastname, roles =@roles ,password =@password  WHERE idusers =@id";
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = query;
				cmd.Parameters.AddWithValue("@name", name.Text);
				cmd.Parameters.AddWithValue("@lastname", lastname.Text);
				cmd.Parameters.AddWithValue("@roles", roles.Text);
				cmd.Parameters.AddWithValue("@password", password.Text);
				cmd.Parameters.AddWithValue("@id",this.Id );
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("UPDATE Successfully", "Information");
				this.Hide();
				GestionUsers.instance.ListViewClear();

			}
			else
			{
				MessageBox.Show("Value is missed", "Information");

			}
		}
	}
}
