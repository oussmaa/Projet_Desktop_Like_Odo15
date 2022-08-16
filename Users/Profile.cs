using MySql.Data.MySqlClient;
using PFE.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.Users
{
	public partial class Profile : Form
	{
		public string Id;
		public string Roles;
		public string Image;

		public Profile(string id,string Roles)
		{
			this.Roles = Roles;
			this.Id = id;
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;

			InitializeComponent();
			GetUserById();
			this.imageprofile.ImageLocation = @"C:\Users\oussama.ghariani\Desktop\Study\PFE\bin\Debug\images\" + Image;

		}

		private void Profile_Load(object sender, EventArgs e)
		{
			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
		public void GetUserById()
		{
			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
			string sql = "SELECT * FROM users where idusers=" + Id + "";
			MySqlCommand cmd = new MySqlCommand(sql, con);
			try
			{
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					this.Image = reader["Image"].ToString();



				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
	

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			try
			{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
					imageprofile.ImageLocation = dialog.FileName.ToString();
				 
					string path = Path.Combine(@"images\");
					if(!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}

					var filename = System.IO.Path.GetFileName(dialog.FileName);
					path = path + filename;
					File.Copy(dialog.FileName, path, true);
					 if(Roles=="Admin")
					{
						DahboredAdmin.instance.Image.ImageLocation = @"C:\Users\oussama.ghariani\Desktop\Study\PFE\bin\Debug\images\" + filename;

					}
					else
					{
						DahboredUser.instance.Image.ImageLocation = @"C:\Users\oussama.ghariani\Desktop\Study\PFE\bin\Debug\images\" + filename;

					}



					string query = "UPDATE users SET   image =@image  WHERE idusers =@id";
					MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
					con.Open();
					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandText = query;
					cmd.Parameters.AddWithValue("@image", filename);

					cmd.Parameters.AddWithValue("@id", this.Id);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					if(name.Text!="")
					{
						if (Roles == "Admin")
						{
							DahboredAdmin.instance.label.Text = name.Text;

						}
						else
						{
							DahboredUser.instance.label.Text = name.Text;

						}
					}
		
					MessageBox.Show("UPDATE Successfully", "Information");
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Information");
			}
			}

		private void prof_Click(object sender, EventArgs e)
		{
		 
			if (name.Text != "" && lastname.Text != ""   && password.Text != "")
			{
				string query = "UPDATE users SET name=@name,lastname=@lastname, password =@password  WHERE idusers =@id";
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = query;
				cmd.Parameters.AddWithValue("@name", name.Text);
				cmd.Parameters.AddWithValue("@lastname", lastname.Text);
 				cmd.Parameters.AddWithValue("@password", password.Text);
				cmd.Parameters.AddWithValue("@id", this.Id);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				if (Roles == "Admin")
				{
					DahboredAdmin.instance.label.Text = name.Text;

				}
				else
				{
					DahboredUser.instance.label.Text = name.Text;

				}
				MessageBox.Show("UPDATE Successfully", "Information");
				 


			}
			else
			{
				MessageBox.Show("Value is missed", "Information");

			}
		}
	}
}
