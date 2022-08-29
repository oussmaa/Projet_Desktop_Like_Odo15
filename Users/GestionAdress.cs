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

namespace PFE.Users
{
	public partial class GestionAdress : Form
	{
		public List<Adress> listtAdress = new List<Adress>();
		public GestionAdress()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			LoadData();
		}
		public void LoadData()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT * FROM adress ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Adress add = new Adress(reader["idadress"].ToString(), reader["name"].ToString(), reader["latitude"].ToString(), reader["longtitude"].ToString());
 
					listtAdress.Add(add);


				}
				List<Adress> listtAdress2 = new List<Adress>();
				listtAdress2 = listtAdress.GroupBy(add => add.Name).Select(x => x.First()).ToList();

				foreach (Adress add in listtAdress2)
				{
					ListViewItem list = new ListViewItem(add.Id);
					list.SubItems.Add(add.Name);
					list.SubItems.Add(add.latitude);
					list.SubItems.Add(add.longtitude);

					listView1.Items.Add(list);
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

		private void GestionAdress_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string SqlCommandeAdress = "INSERT INTO adress(name, latitude, longtitude) VALUES(?name,?latitude,?longtitude)";

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				MySqlCommand Bank = new MySqlCommand(SqlCommandeAdress, con);
				Bank.Parameters.Add(new MySqlParameter("?name", namee.Text));
				Bank.Parameters.Add(new MySqlParameter("?latitude", lat.Text));
				Bank.Parameters.Add(new MySqlParameter("?longtitude", lont.Text));

				Bank.ExecuteNonQuery();
				listView1.Items.Clear();
				LoadData();
				MessageBox.Show("Add Successfully", "Information");
				this.lont.Text = "";
				this.name.Text = "";
				this.lat.Text = "";
				con.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
	}
}
