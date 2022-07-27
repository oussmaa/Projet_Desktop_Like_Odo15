using Connection;
using MySql.Data.MySqlClient;
using PFE.Admin;
using PFE.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
	public partial class Login : Form
	{
		connection con = new connection();
		string id, username, password, firstname, lastname, roles;
		public Login()
		{
			this.MaximumSize = new System.Drawing.Size(1200, 750);
			this.MinimumSize = new System.Drawing.Size(1200, 750);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}

		private void pass_TextChanged(object sender, EventArgs e)
		{
			pass.PasswordChar = '*';

		}

		private void login_form_Paint(object sender, PaintEventArgs e)
		{
			

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
      try
      {
        if (name.Text != "" && pass.Text != "")
        {
					MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
					con.Open();
					MySqlCommand cmd = new MySqlCommand("select * from users where name = '" + name.Text + "' AND password = '" + pass.Text + "'", con);
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						firstname = reader["roles"].ToString();
						if(firstname=="Admin")
						{
							MessageBox.Show("Successfully Sign In!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
							 DahboredAdmin dash=new DahboredAdmin();
							this.Hide();
							dash.Show();
						
						}
						else
						{
							MessageBox.Show("Successfully Sign In!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
							DahboredUser dash = new DahboredUser();
							this.Hide();
							dash.Show();
							
						}
						 
						
					}
					else
					{
						MessageBox.Show("Username And Password Not Match!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
 
					reader.Close();
					cmd.Dispose();
					con.Close(); // always close connection }
				}
        else
        {
          
          MessageBox.Show("Username or Password is empty", "Information");
        }
      }
      catch
      {
       
        MessageBox.Show("Connection Error", "Information");
      }
    }
  }
}
 