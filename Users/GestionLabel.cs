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
	public partial class GestionLabel : Form
	{
		public string Color;
		public GestionLabel()
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
				string sql = "SELECT * FROM label ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{



					ListViewItem list = new ListViewItem(reader["idLabel"].ToString());
					list.SubItems.Add(reader["name"].ToString());
					list.SubItems.Add(reader["category"].ToString());
					list.SubItems.Add(reader["color"].ToString());

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
		private void GestionLabel_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
						if(colorDialog1.ShowDialog()==DialogResult.OK)
			{
				MessageBox.Show(colorDialog1.Color.Name.ToString());
				//this.label1.BackColor = colorDialog1.Color;
				this.Color = colorDialog1.Color.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string SqlCommandeLabel = "INSERT INTO label(name, category, color) VALUES(?name,?category,?color)";

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				MySqlCommand Bank = new MySqlCommand(SqlCommandeLabel, con);
				Bank.Parameters.Add(new MySqlParameter("?name", namee.Text));
				Bank.Parameters.Add(new MySqlParameter("?category", cat.Text));
				Bank.Parameters.Add(new MySqlParameter("?color", Color));

				Bank.ExecuteNonQuery();
				listView1.Items.Clear();
				LoadData();
				MessageBox.Show("Add Successfully", "Information");
				this.Color = "";
				//colorDialog1.Color = colorDialog1.Color.;
				this.name.Text = "";
				this.cat.Text = "";
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
	}
}
