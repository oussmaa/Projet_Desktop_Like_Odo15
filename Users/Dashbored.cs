using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
		public List<DateTime> ListDate = new List<DateTime>();
		public DateTime Date;
		public Dashbored()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			LoadDataUsers();
			LoadDataAdmin();
			LoadDateData();
		}

		private void Dashbored_Load(object sender, EventArgs e)
		{
			chart1.Series["Users"].Points.AddXY("User", CountUser);
			chart1.Series["Users"].Points.AddXY("Admin", CountAdmin);

			List<DateTime> listdate2 = new List<DateTime>();
			listdate2 = ListDate.GroupBy(add => add.Year).Select(x => x.First()).ToList();

			foreach (DateTime date in listdate2)
			{
		 
				Client.Series["Client"].Points.AddXY(date.Year, GetDataNb(date));

			}
		 
			

		}
		public int GetDataNb(DateTime date)
		{
			int s = 0;
			foreach (DateTime dat in ListDate)
			{
				if(dat.Year==date.Year)
				{
					s = s + 1;
				}
			 

			}
			return s;
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
		public void LoadDateData()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT create_date FROM commercialpartner ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					//DateTime date = DateTime.ParseExact(reader["create_date"].ToString(), "dd/MM/yyyy", null);

					var test = reader["create_date"].ToString();
					var b = test.Remove(test.Length - 9);

					DateTime date = DateTime.ParseExact(test.Remove(test.Length - 9), "dd/MM/yyyy", null);

					ListDate.Add(date);

				}

				reader.Close();
				cmd.Dispose();
				con.Close();

			}

			catch(Exception ex)
			{

				MessageBox.Show(ex.Message, "Information");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
