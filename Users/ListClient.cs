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
	public partial class ListClient : Form
	{
		public List<string> listtColumnName = new List<string>();

		public ListClient()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			GetColumnAndData();
			GetValueDataClumn();
		}

		private void ListClient_Load(object sender, EventArgs e)
		{

		}
		public void GetValueDataClumn()
		{
			try
			{

				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT * FROM commercialpartner ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					ListViewItem list = new ListViewItem();
					foreach (string col in listtColumnName)
					{



						list.SubItems.Add(reader[col].ToString());



					}
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
		public void GetColumnAndData()
		{

			try
			{
				DataTable schema = null;
				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				string sql = "SELECT * FROM commercialpartner ";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					schema = reader.GetSchemaTable();


				}

				reader.Close();
				cmd.Dispose();
				con.Close();
				foreach (DataRow col in schema.Rows)
				{

					listView1.Columns.Add(col.Field<String>("ColumnName"));
					//MessageBox.Show(col.Field<String>("ColumnName"));
					listtColumnName.Add(col.Field<String>("ColumnName"));
				}
			}
			catch
			{

				MessageBox.Show("Connection Error", "Information");
			}

		}
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
