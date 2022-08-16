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

namespace PFE.Users
{
	public partial class Dashbored : Form
	{
		public Int32 CountUser;
		public Int32 CountAdmin;

		public Dashbored()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			LoadDataUsers();
			LoadDataAdmin();
		}

		private void Dashbored_Load(object sender, EventArgs e)
		{
			chart1.Series["Users"].Points.AddXY("User", CountUser);
			chart1.Series["Users"].Points.AddXY("Admin", CountAdmin);
 
		}
		public void LoadDataAdmin()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT count(*) FROM users where roles='Admin'";
				MySqlCommand cmd = new MySqlCommand(sql, con);


				CountAdmin = Convert.ToInt32(cmd.ExecuteScalar());


				cmd.Dispose();
				con.Close();
			}

			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		public void LoadDataUsers()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT count(*) FROM users where roles='User'";
				MySqlCommand cmd = new MySqlCommand(sql, con);


				CountUser = Convert.ToInt32(cmd.ExecuteScalar());


				cmd.Dispose();
				con.Close();
			}

			catch(Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void chart2_Click(object sender, EventArgs e)
		{

		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}
	}
}
