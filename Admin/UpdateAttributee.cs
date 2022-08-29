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
	public partial class UpdateAttributee : Form
	{
		string Id;
		public UpdateAttributee(Model.Attributee attributee)
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
			this.Id = "";
			this.Id = attributee.Name;
			this.name.Text = attributee.Name;
			this.type.Text = attributee.Type;
		}

		private void UpdateAttributee_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Adduser_Click(object sender, EventArgs e)
		{
			if (name.Text != "" && type.Text != ""  )
			{
				try
				{

			
				string query = "UPDATE supp_information SET name=@name,type=@type   WHERE name =@id";
				string query2 = "Alter table commercialpartner  Rename column " + this.Id +" to "+ name.Text+"";


				MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
				con.Open();
				MySqlCommand cmd = new MySqlCommand();
					MySqlCommand commerciall = new MySqlCommand(query2, con);
					cmd.CommandText = query;
				cmd.Parameters.AddWithValue("@name", name.Text);
				cmd.Parameters.AddWithValue("@type", type.Text);
				cmd.Parameters.AddWithValue("@id",Id);
				cmd.Connection = con;
				commerciall.ExecuteNonQuery();
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("UPDATE Successfully", "Information");
				this.Hide();
				Gestionattribute.instance.ListViewClear();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please write data");
			}
		}
	}
}
