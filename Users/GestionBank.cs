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
	public partial class GestionBank : Form
	{
		public GestionBank()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			LoadData();
		}

		private void GestionBank_Load(object sender, EventArgs e)
		{

		}
		public void LoadData()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT * FROM bank_account ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{



					ListViewItem list = new ListViewItem(reader["idbank_account"].ToString());

					list.SubItems.Add(reader["name_bank"].ToString());
					list.SubItems.Add(reader["number"].ToString());

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

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string SqlCommandeBank = "INSERT INTO bank_account(number, name_bank) VALUES(?number,?name_bank)";

			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
			MySqlCommand Bank = new MySqlCommand(SqlCommandeBank, con);
			Bank.Parameters.Add(new MySqlParameter("?name_bank", namee.Text));
			Bank.Parameters.Add(new MySqlParameter("?number", num.Text));
			Bank.ExecuteNonQuery();
			listView1.Items.Clear();
			LoadData();
			MessageBox.Show("Add Successfully", "Information");
			this.num.Text = "";
			this.namee.Text = "";
			con.Close();
		}
	}
}
