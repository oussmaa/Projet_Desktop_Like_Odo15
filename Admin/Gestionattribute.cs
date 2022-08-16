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
	public partial class Gestionattribute : Form
	{
		public Gestionattribute()
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
				string sql = "SELECT * FROM supp_information ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{



					ListViewItem list = new ListViewItem(reader["idsupp_information"].ToString());

					list.SubItems.Add(reader["name"].ToString());
					list.SubItems.Add(reader["type"].ToString());


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
		private void Gestionattribute_Load(object sender, EventArgs e)
		{
			 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (name.Text != "" && type.Text != "" )
			{
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string typecolumn = " varchar(255) ";
				 if(type.Text=="Date")
				{
					typecolumn = " Date ";
				}
				 else if (type.Text == "INT")
				{
					typecolumn = " INT ";
				}
				 
					string SqL = "ALTER TABLE commercialpartner ADD " + name.Text +""+  typecolumn +"";
				string SQLcommand = "INSERT INTO supp_information(name, type) VALUES(?name, ?type);";
				MySqlCommand attrub = new MySqlCommand(SQLcommand, con);
				MySqlCommand altertable = new MySqlCommand(SqL, con);
				attrub.Parameters.Add(new MySqlParameter("?name", name.Text));
				attrub.Parameters.Add(new MySqlParameter("?type", type.Text));


				try
				{
					altertable.ExecuteNonQuery();
					attrub.ExecuteNonQuery();
					MessageBox.Show("Add Successfully", "Information");
					listView1.Items.Clear();
					LoadData();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			
				



				
				con.Close();
			}
			else
			{
				MessageBox.Show("Value is missed", "Information");

			}
		}

			private void label1_Click(object sender, EventArgs e)
		{

		}

		private void type_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
