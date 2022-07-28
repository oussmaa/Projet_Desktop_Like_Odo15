using MySql.Data.MySqlClient;
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
	public partial class GestionUsers : Form
	{
		public static GestionUsers instance;
		public GestionUsers()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
	 
			InitializeComponent();
			instance = this;

			GetData();
		}

		private void GestionUsers_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		public void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		public void ListViewClear()
		{
			listView.Items.Clear();
			GetData();
			 
		}
		private void Adduser_Click(object sender, EventArgs e)
		{
			if(name.Text!= "" && lastname.Text!= "" && roles.Text!= "" && password.Text!= "")
			{
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string SQLcommand = "INSERT INTO Users(name, lastname, roles, password) VALUES(?un, ?fn, ?ln, ?pw);";
				MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);
				bazaUkaz.Parameters.Add(new MySqlParameter("?un", name.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?fn", lastname.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?ln", roles.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?pw", password.Text));
 

				bazaUkaz.ExecuteNonQuery();

				listView.Items.Clear();
				GetData();

				MessageBox.Show("Add Successfully", "Information");
				con.Close();
			}
			else
			{
				MessageBox.Show("Value is missed", "Information");

			}

		}

		private void delete_Click(object sender, EventArgs e)
		{
			if(listView.SelectedItems.Count > 0)
			{
				
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string SQLcommand = "DELETE FROM users WHERE idusers= " + listView.SelectedItems[0].SubItems[4].Text + "";
				MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);
				listView.Items.Remove(listView.SelectedItems[0]);
				bazaUkaz.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("DELETE Successfully", "Information");

			}
			else
			{
				MessageBox.Show("Please select user", "Information");

			}

		}

		private void password_TextChanged(object sender, EventArgs e)
		{
			password.PasswordChar = '*';
		}
		public void GetData()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT * FROM users ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();
				
				while (reader.Read()) 
				{
			 


				 ListViewItem list = new ListViewItem(reader["name"].ToString());

					list.SubItems.Add(reader["lastname"].ToString());
					list.SubItems.Add(reader["roles"].ToString());
					list.SubItems.Add(reader["password"].ToString());
					list.SubItems.Add(reader["idusers"].ToString());

					listView.Items.Add(list); 

				}

				reader.Close();
				cmd.Dispose();
				con.Close(); 
			}

			catch
			{

				MessageBox.Show("Connection Error", "Information");
			}

		}
		private void update_Click(object sender, EventArgs e)
		{
			if (listView.SelectedItems.Count > 0)
			{



				
				Form F = new UpdateUser(new Model.User(listView.SelectedItems[0].SubItems[0].Text, listView.SelectedItems[0].SubItems[1].Text, listView.SelectedItems[0].SubItems[2].Text, listView.SelectedItems[0].SubItems[3].Text, listView.SelectedItems[0].SubItems[4].Text));
				 F.Show();
			}
			else
			{
				MessageBox.Show("Please select user", "Information");

			}

		}
	}
}
