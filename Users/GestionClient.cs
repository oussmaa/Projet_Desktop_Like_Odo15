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
	public partial class GestionClient : Form
	{
		Panel panel ;
		public List<string> listtstring = new List<string>();
		public List<string> listtColumnName = new List<string>();
		public List<Adress> listtAdress = new List<Adress>();

		public List<Labele> listabel = new List<Labele>();

		public List<Attributee> listt = new List<Attributee>();
		public long idContact { get; set; }
		public long idSeler { get; set; }
		public long idBank { get; set; }
		public long idAdress { get; set; }
		public long idLabel { get; set; }
		public GestionClient()
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;

			InitializeComponent();

			//this.paneldynamique.Controls.Add(new DateTimePicker());
			 panelcontact.Visible = true;
		 	panel2seller.Visible = true;
			bankacount.Visible = false;
			soci.Checked = true;
			GetAttrubu();
			GetColumnAndData();
			//GetValueDataClumn();
			LoadData();
			LoadDataAdress();
		}
		public void LoadDataAdress()
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



 
					Adress adress = new Adress(reader["idadress"].ToString(), reader["name"].ToString(), reader["latitude"].ToString(), reader["longtitude"].ToString());


					listtAdress.Add(adress);
				}

				reader.Close();
				cmd.Dispose();
				con.Close();
				foreach (Adress adress in listtAdress)
				{
					this.adress.Items.Add(adress.Name);


				}
			}

			catch
			{

				MessageBox.Show("Connection Error", "Information");
			}
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


					Labele label = new Labele(reader["idLabel"].ToString(), reader["name"].ToString(), reader["category"].ToString(), reader["color"].ToString());


					listabel.Add(label);

				}

				reader.Close();
				cmd.Dispose();
				con.Close();
				
			foreach (Labele labele in listabel)
				{
					this.label.Items.Add(labele.name);


				}
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
					 
					//listView1.Columns.Add(col.Field<String>("ColumnName"));
					//MessageBox.Show(col.Field<String>("ColumnName"));
					listtColumnName.Add(col.Field<String>("ColumnName"));
				}
			}
			catch
			{

				MessageBox.Show("Connection Error", "Information");
			}
		
			}
			
		private void GestionClient_Load(object sender, EventArgs e)
		{
						
		}
		public void GetAttrubu()
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

					listt.Add(new Attributee(int.Parse(reader["idsupp_information"].ToString()), reader["name"].ToString(), reader["type"].ToString()));



				}

				reader.Close();
				cmd.Dispose();
				con.Close();
			}
			catch
			{

				MessageBox.Show("Connection Error", "Information");
			}


			int i = 11;
			int j = 26;
			int k = 70;
			Panel pan = new Panel();
			this.panel = pan;
			pan.Location = new Point(61, 440);
			pan.Size = new Size(1131, 216);
			this.AutoScrollMinSize = new Size(0, 1000);

			this.AutoScroll = true;
			this.VerticalScroll.Enabled = false;
			this.VerticalScroll.Visible = false;
			this.Controls.Add(pan);

			foreach (Attributee line in listt)
			{
				 if (line.Type == "Date")
				{
					System.Windows.Forms.DateTimePicker date = new System.Windows.Forms.DateTimePicker();
					Label Label = new System.Windows.Forms.Label();
					//Label.ForeColor = Color.Blue;
					Label.ForeColor = Color.DarkRed;
					Label.Location = new Point(i, j);
					//i = i + 100;
					date.Location = new Point(k, j);
					date.Size = new Size(128, 29);
					date.Name = line.Name;

					Label.Text = line.Name;

					Label.Size = new Size(128, 29);

					pan.Controls.Add(date);
					pan.Controls.Add(Label);

					//j = j + 230;
					k = k + 200;
					i = i + 200;
					if (k > 700)
					{ j = j + 30;
						i = 11;
						k = 70;

					}

				
					 


				}
				  else  if(line.Type== "Radio")
				{
					System.Windows.Forms.RadioButton radio = new System.Windows.Forms.RadioButton();
					Label Label = new System.Windows.Forms.Label();
					Label.ForeColor = Color.DarkRed;
					Label.Location = new Point(i, j);

					//Label.ForeColor = Color.Blue;
					radio.Location = new Point(k, j);
					radio.Size = new Size(128, 29);
					radio.Name = line.Name;
					Label.Text = line.Name;
					Label.Size = new Size(128, 29);
					pan.Controls.Add(radio);
					pan.Controls.Add(Label);
					k = k + 200;
					i = i + 200;
					if (k > 700)
					{
						j = j + 30;
						i = 11;
						k = 70;

					}
				}
			 	else if(line.Type== "Checkbox")
				{
					System.Windows.Forms.CheckBox check = new System.Windows.Forms.CheckBox();
					Label Label = new System.Windows.Forms.Label();
					Label.ForeColor = Color.DarkRed;

					//Label.ForeColor = Color.Blue;
					check.Name = line.Name;
					check.Location = new Point(k, j);
					check.Size = new Size(128, 29);
				
					Label.Text = line.Name;
					Label.Location = new Point(i, j);
					Label.Size = new Size(128, 29);
					pan.Controls.Add(check);
					pan.Controls.Add(Label);
					k = k + 200;
					i = i + 200;
					if (k > 700)
					{
						j = j + 30;
						i = 11;
						k = 70;

					}
				}  
				 else { 

				TextBox dynamicTextBox = new System.Windows.Forms.TextBox();
				Label Label = new System.Windows.Forms.Label();
					Label.ForeColor = Color.DarkRed;
					//Label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

					Label.Text = line.Name;
					Label.Location = new Point(i, j);
					Label.Size = new Size(128, 29);
				 dynamicTextBox.Name = line.Name;
				dynamicTextBox.Text = "";
				dynamicTextBox.Location= new Point(k, j);
				dynamicTextBox.Size = new Size(128, 29);
				pan.Controls.Add(dynamicTextBox);
				pan.Controls.Add(Label);
					k = k + 200;
					i = i + 200;
					if (k > 700)
					{
						j = j + 30;
						i = 11;
						k = 70;

					}

				}   
			 
			}
		}

		private void Pan_ControlRemoved(object sender, ControlEventArgs e)
		{
		  
		}

		private void Pan_ControlAdded(object sender, ControlEventArgs e)
		{
			 
		}

		private void name_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			 
			panelcontact.Visible = false;
			panel2seller.Visible = false;
			bankacount.Visible = true;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

 

		private void remark_contact_TextChanged(object sender, EventArgs e)
		{

		}

		private void label25_Click(object sender, EventArgs e)
		{

		}

		private void paneldynamique_Paint(object sender, PaintEventArgs e)
		{

		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void soci_CheckedChanged(object sender, EventArgs e)
		{
			panelcontact.Visible = true;
			panel2seller.Visible = true;
			bankacount.Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			listtstring.Clear();

			foreach (Attributee line in listt)
			{
				foreach (var c in this.panel.Controls)

				{
					if (line.Type == "Date")
					{
						if (c is DateTimePicker t && t.Name.Equals(line.Name))

							listtstring.Add(t.Value.Date.ToString("dd.MM.yyyy"));


					}
					else if (line.Type == "Text" )
					{
						if (c is TextBox t && t.Name.Equals(line.Name))
							listtstring.Add(t.Text);


					}
					else if (line.Type == "INT")
					{
						if (c is TextBox t && t.Name.Equals(line.Name))
							listtstring.Add(t.Text +'!');


					}
					else if (line.Type == "Radio")
					{
						if (c is RadioButton t && t.Name.Equals(line.Name))
							listtstring.Add(t.Checked.ToString());

					}
					else if (line.Type == "Checkbox")
					{

						if (c is CheckBox t && t.Name.Equals(line.Name))
							listtstring.Add(t.Checked.ToString());

					}


				}
			}

			if (soci.Checked == true)
			{
				if (name_contact.Text != "" && adress_contact.Text != "" && email_contact.Text != "" && phone_contact.Text != "" && remark_contact.Text != "" && name_seller.Text != "" && adress_seller.Text != "" && email_seller.Text != "" && phone_seller.Text != "" && remark_seller.Text != "" && name.Text != "" && reference.Text != "" && create_date.Text != "" && cheksocity.Text != "" && phone.Text != "" && email.Text != "" && postal_code.Text != "" && website.Text != "" && fax.Text != "" && picture.Text != "" && job.Text != "" && note.Text != "" && !listtstring.Contains(""))
				{
					string sqlinsertinto = "";

					foreach (Attributee line in listt)
					{

						sqlinsertinto = sqlinsertinto + line.Name + ',';



					}
					string sqlinsertvalue = "";
					for (int i = 0; i < listtstring.Count; i++)
					{
						sqlinsertvalue = sqlinsertvalue + '?' + i + ',';
					}
					MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
					con.Open();
					string SqlCommandeContact = "INSERT INTO contact(name, adress, email,phone,remark) VALUES(?name,?adress,?email,?phone,?remark)";
					string SqlCommandeSeler = "INSERT INTO seller(name, adress, email,phone,remark) VALUES(?name,?adress,?email,?phone,?remark)";

					string SQLcommand = "INSERT INTO commercialpartner(name, refrence, create_date, chec_socity,phone,email,idcategory,idbank_account,postalcode,idLabel,website,fax,picture,idadress,JobPosition,note,idseller,idcontact," + sqlinsertinto.Remove(sqlinsertinto.Length - 1) + ") VALUES(?na, ?ref, ?crdate,?chek, ?ph,?em,?idcat,?idbank,?postcode,?idlabel,?website,?fax,?picture,?idadress,?jobpostion,?note,?idseller,?idcontact," + sqlinsertvalue.Remove(sqlinsertvalue.Length - 1) + ");";

					string SqlCommandeAdress = "INSERT INTO adress(name, latitude, longtitude) VALUES(?name,?latitude,?longtitude)";
					string SqlCommandeLabel = "INSERT INTO label(name, category, color) VALUES(?name,?category,?color)";

					MySqlCommand Adress = new MySqlCommand(SqlCommandeAdress, con);

					Adress.Parameters.Add(new MySqlParameter("?name", adress.Text));
					Adress.Parameters.Add(new MySqlParameter("?latitude", "21"));
					Adress.Parameters.Add(new MySqlParameter("?longtitude", "20"));

					try
					{

						Adress.ExecuteNonQuery();
						idAdress = Adress.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
					MySqlCommand Label = new MySqlCommand(SqlCommandeLabel, con);


					Label.Parameters.Add(new MySqlParameter("?name", label.Text));
					Label.Parameters.Add(new MySqlParameter("?category", "Societe"));
					Label.Parameters.Add(new MySqlParameter("?color", "Red"));

					try
					{

						Label.ExecuteNonQuery();
						idLabel = Label.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}

					//MessageBox.Show(SQLcommand);
					MySqlCommand Contact = new MySqlCommand(SqlCommandeContact, con);
					Contact.Parameters.Add(new MySqlParameter("?name", name_contact.Text));
					Contact.Parameters.Add(new MySqlParameter("?adress", adress_contact.Text));
					Contact.Parameters.Add(new MySqlParameter("?email", email_contact));
					Contact.Parameters.Add(new MySqlParameter("?phone", phone_contact.Text));
					Contact.Parameters.Add(new MySqlParameter("?remark", remark_contact.Text));
					try
					{

						Contact.ExecuteNonQuery();
						idContact = Contact.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}


					MySqlCommand Seler = new MySqlCommand(SqlCommandeSeler, con);
					Seler.Parameters.Add(new MySqlParameter("?name", name_seller.Text));
					Seler.Parameters.Add(new MySqlParameter("?adress", adress_seller.Text));
					Seler.Parameters.Add(new MySqlParameter("?email", email_seller.Text));
					Seler.Parameters.Add(new MySqlParameter("?phone", phone_seller.Text));
					Seler.Parameters.Add(new MySqlParameter("?remark", remark_seller.Text));

					try
					{


						Seler.ExecuteNonQuery();
						idSeler = Contact.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
					MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);

					bazaUkaz.Parameters.Add(new MySqlParameter("?na", name.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?ref", reference.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?crdate", DateTime.Parse(create_date.Text)));
					bazaUkaz.Parameters.Add(new MySqlParameter("?chek", cheksocity.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?ph", phone.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?em", email.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idcat", 5));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idbank", 5));
					bazaUkaz.Parameters.Add(new MySqlParameter("?postcode", postal_code.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idlabel", idLabel));
					bazaUkaz.Parameters.Add(new MySqlParameter("?website", website.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?fax", fax.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?picture", picture.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idadress", idAdress));
					bazaUkaz.Parameters.Add(new MySqlParameter("?jobpostion", job.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?note", note.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idseller", idSeler));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idcontact", idContact));

					for (int i = 0; i < listtstring.Count; i++)
					{
						if (listtstring[i].ToString().Contains("."))
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, Convert.ToDateTime(listtstring[i].ToString())));

						}
						else if (listtstring[i].ToString().Contains("!"))
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, Convert.ToInt32(listtstring[i].ToString().Substring(0, listtstring[i].ToString().Length - 1))));

						}
						else
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, listtstring[i].ToString()));

						}
					}
					try
					{

						bazaUkaz.ExecuteNonQuery();
						long id = bazaUkaz.LastInsertedId;
						MessageBox.Show("Add successful");
 
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Please Write Data ");
				}

			}
			else if (personne.Checked == true)
			{
				if (number_bank.Text != "" && name_banque.Text != "" && name.Text != "" && reference.Text != "" && create_date.Text != "" && cheksocity.Text != "" && phone.Text != "" && email.Text != "" && postal_code.Text != "" && website.Text != "" && fax.Text != "" && picture.Text != "" && job.Text != "" && note.Text != "" && !listtstring.Contains(""))
				{
					string sqlinsertinto = "";

					foreach (Attributee line in listt)
					{

						sqlinsertinto = sqlinsertinto + line.Name + ',';



					}
					string sqlinsertvalue = "";
					for (int i = 0; i < listtstring.Count; i++)
					{
						sqlinsertvalue = sqlinsertvalue + '?' + i + ',';
					}
					MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
					con.Open();
					string SqlCommandeBank = "INSERT INTO bank_account(number, name_bank) VALUES(?number,?name_bank)";

					string SQLcommand = "INSERT INTO commercialpartner(name, refrence, create_date, chec_socity,phone,email,idcategory,idbank_account,postalcode,idLabel,website,fax,picture,idadress,JobPosition,note,idseller,idcontact," + sqlinsertinto.Remove(sqlinsertinto.Length - 1) + ") VALUES(?na, ?ref, ?crdate,?chek, ?ph,?em,?idcat,?idbank,?postcode,?idlabel,?website,?fax,?picture,?idadress,?jobpostion,?note,?idseller,?idcontact," + sqlinsertvalue.Remove(sqlinsertvalue.Length - 1) + ");";

					string SqlCommandeAdress = "INSERT INTO adress(name, latitude, longtitude) VALUES(?name,?latitude,?longtitude)";
					string SqlCommandeLabel = "INSERT INTO label(name, category, color) VALUES(?name,?category,?color)";

					MySqlCommand Adress = new MySqlCommand(SqlCommandeAdress, con);

					Adress.Parameters.Add(new MySqlParameter("?name", adress.Text));
					Adress.Parameters.Add(new MySqlParameter("?latitude", "21"));
					Adress.Parameters.Add(new MySqlParameter("?longtitude", "20"));

					try
					{

						Adress.ExecuteNonQuery();
						idAdress = Adress.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
					MySqlCommand Label = new MySqlCommand(SqlCommandeLabel, con);


					Label.Parameters.Add(new MySqlParameter("?name", label.Text));
					Label.Parameters.Add(new MySqlParameter("?category", "Societe"));
					Label.Parameters.Add(new MySqlParameter("?color", "Red"));

					try
					{

						Label.ExecuteNonQuery();
						idLabel = Label.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}

					//MessageBox.Show(SQLcommand);
					MySqlCommand Bank = new MySqlCommand(SqlCommandeBank, con);
					Bank.Parameters.Add(new MySqlParameter("?name_bank", name_banque.Text));
					Bank.Parameters.Add(new MySqlParameter("?number", number_bank.Text));


					try
					{

						Bank.ExecuteNonQuery();
						idBank = Bank.LastInsertedId;
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}


					MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);

					bazaUkaz.Parameters.Add(new MySqlParameter("?na", name.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?ref", reference.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?crdate", DateTime.Parse(create_date.Text)));
					bazaUkaz.Parameters.Add(new MySqlParameter("?chek", cheksocity.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?ph", phone.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?em", email.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idcat", 5));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idbank", idBank));
					bazaUkaz.Parameters.Add(new MySqlParameter("?postcode", postal_code.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idlabel", idLabel));
					bazaUkaz.Parameters.Add(new MySqlParameter("?website", website.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?fax", fax.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?picture", picture.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idadress", idAdress));
					bazaUkaz.Parameters.Add(new MySqlParameter("?jobpostion", job.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?note", note.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idseller", idSeler));
					bazaUkaz.Parameters.Add(new MySqlParameter("?idcontact", idContact));

					for (int i = 0; i < listtstring.Count; i++)
					{
						if (listtstring[i].ToString().Contains("."))
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, Convert.ToDateTime(listtstring[i].ToString())));

						}
						else if(listtstring[i].ToString().Contains("!"))
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, Convert.ToInt32(listtstring[i].ToString().Substring(0, listtstring[i].ToString().Length-1))));

						}
						else
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("?" + i, listtstring[i].ToString()));

						}
					}
					try
					{

						bazaUkaz.ExecuteNonQuery();
						long id = bazaUkaz.LastInsertedId;
						MessageBox.Show("Add successful");
 
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
				}

				else
				{
					MessageBox.Show("Please Write Data ");
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//	var firstSelectedItem = listView1.SelectedItems[0];
 

 
 
		}//MessageBox.Show(firstSelectedItem);

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void label27_Click(object sender, EventArgs e)
		{

		}

		private void label24_Click(object sender, EventArgs e)
		{

		}

		private void label23_Click(object sender, EventArgs e)
		{

		}

		private void label_ValueMemberChanged(object sender, EventArgs e)
		{

		}

		private void label_TextChanged_1(object sender, EventArgs e)
		{
			/*foreach (Labele labele in listabel)
			{
				if (labele.name == label.Text)
				{
					this.label.Text = labele.name;
					this.label.ForeColor = Color.Red;

				}
				else
				{
					this.label.ForeColor = Color.Black;
				}
			}*/
		}







		//MessageBox.Show(sqlinsertinto);
		//MessageBox.Show(sqlinsertvalue);



	}
}
 