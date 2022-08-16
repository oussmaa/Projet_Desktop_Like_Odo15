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
	public partial class GestionSaller : Form
	{
		public GestionSaller()
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
				string sql = "SELECT * FROM seller ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{



					ListViewItem list = new ListViewItem(reader["idseller"].ToString());

					list.SubItems.Add(reader["name"].ToString());
					list.SubItems.Add(reader["email"].ToString());
					list.SubItems.Add(reader["phone"].ToString());
					list.SubItems.Add(reader["adress"].ToString());
					list.SubItems.Add(reader["remark"].ToString());
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
		private void GestionSaller_Load(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (namee.Text != "" && adrr.Text != "" && em.Text != "" && remk.Text != "" && ph.Text != "")
			{
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string SQLcommand = "INSERT INTO seller(name, email, phone, adress,remark) VALUES(?name, ?email, ?phone, ?adress,?remark);";
				MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);
				bazaUkaz.Parameters.Add(new MySqlParameter("?name", namee.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?email", em.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?phone", ph.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?adress", adrr.Text));
				bazaUkaz.Parameters.Add(new MySqlParameter("?remark", remk.Text));
				bazaUkaz.ExecuteNonQuery();

				listView1.Items.Clear();
				LoadData();

				MessageBox.Show("Add Successfully", "Information");
				con.Close();
			}
			else
			{
				MessageBox.Show("Value is missed", "Information");

			}
		}
	}
}
