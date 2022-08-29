using MySql.Data.MySqlClient;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.Users
{


	public partial class DetailleClient : Form
	{
	

		Panel panel;
		public List<string> listtstring = new List<string>();
		public ListViewItem List;
		public string Perosnne;
		public string FileName;
		public List<Attributee> listt = new List<Attributee>();
		public string idContact { get; set; }
		public string idCategorie { get; set; }

		public string idSeler { get; set; }
		public string idComer { get; set; }

		public string idBank { get; set; }
		public string idAdress { get; set; }
		public string idLabel { get; set; }
		public List<string> ListValueAtriibut = new List<string>();
		public DetailleClient(ListViewItem any)
		{
			this.MaximumSize = new System.Drawing.Size(1270, 820);
			this.MinimumSize = new System.Drawing.Size(1270, 820);
			this.StartPosition = FormStartPosition.CenterScreen;
			List = any;
			InitializeComponent();
			FileName = any.SubItems[13].Text;


			name.Text = any.SubItems[2].Text;
			cheksocity.Text = any.SubItems[5].Text;
			fax.Text = any.SubItems[12].Text;
			create_date.Text = any.SubItems[4].Text;
			job.Text = any.SubItems[15].Text;
			note.Text = any.SubItems[16].Text;
		  email.Text = any.SubItems[7].Text;
			postal_code.Text = any.SubItems[9].Text;
			label.Text = any.SubItems[17].Text;
			payement_condition_customer.Text = any.SubItems[2].Text;
		 
			phone.Text = any.SubItems[6].Text;
			reference.Text = any.SubItems[3].Text;
			website.Text = any.SubItems[11].Text;
			idBank = any.SubItems[8].Text;
			idAdress = any.SubItems[14].Text;
			idLabel = any.SubItems[10].Text;
			idComer= any.SubItems[1].Text;
			GetBankData(any.SubItems[8].Text);

			GetLabel(any.SubItems[10].Text);
			GetAdress(any.SubItems[14].Text);
			picture.ImageLocation = @"C:\Users\oussama.ghariani\Desktop\Study\PFE\bin\Debug\images\" + any.SubItems[13].Text;
			GetAttrubu();
	
	
			GetValueAtributColumn();
		}
		public void GetLabel(string id)
		{
			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
			string sql = "SELECT * FROM label where idLabel=" + id + "";
			MySqlCommand cmd = new MySqlCommand(sql, con);
			try
			{
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					label.Text = reader["name"].ToString();




				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void GetAdress(string id)
		{
			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
			string sql = "SELECT * FROM adress where idadress=" + id + "";
			MySqlCommand cmd = new MySqlCommand(sql, con);
			try
			{
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					adress.Text = reader["name"].ToString();
 



				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void GetValueAtributColumn()
		{
			int i = 18;
				foreach (Attributee line in listt)
				{
					foreach (var c in this.panel.Controls)

					{
						if (line.Type == "Date")
						{
						if (c is DateTimePicker t && t.Name.Equals(line.Name))

							if (List.SubItems[i].Text == "")
							{
								

							}
							else
							{
								t.Value = Convert.ToDateTime(List.SubItems[i].Text);

							}




					}
						 if (line.Type == "Text")
						{
							if (c is TextBox t && t.Name.Equals(line.Name))
								 t.Text= List.SubItems[i].Text;


						}
						 else if (line.Type == "INT")
						{
							if (c is TextBox t && t.Name.Equals(line.Name))
							t.Text= List.SubItems[i].Text;
							 

						}
						 
						else if (line.Type == "Radio")
						{
							if (c is RadioButton t && t.Name.Equals(line.Name))
							if(List.SubItems[i].Text=="")
							{
								t.Checked = false;

							}
							else
							{
								t.Checked = Convert.ToBoolean(List.SubItems[i].Text);

							}

					}
						else if (line.Type == "Checkbox")
						{

							if (c is CheckBox t && t.Name.Equals(line.Name))
							if (List.SubItems[i].Text == "")
							{
								t.Checked = false;

							}
							else
							{
								t.Checked = Convert.ToBoolean(List.SubItems[i].Text);

							}


					}



				}
				i++;
			}
		}
		public void GetBankData(string id)
		{
			MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
			con.Open();
			string sql = "SELECT * FROM bank_account where idbank_account=" + id + "";
			MySqlCommand cmd = new MySqlCommand(sql, con);
			try
			{
				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					name_banque.Text = reader["name_bank"].ToString();
					number_bank.Text = reader["number"].ToString();



				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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
					{
						j = j + 30;
						i = 11;
						k = 70;

					}





				}
				else if (line.Type == "Radio")
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
				else if (line.Type == "Checkbox")
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
				else
				{

					TextBox dynamicTextBox = new System.Windows.Forms.TextBox();
					Label Label = new System.Windows.Forms.Label();
					Label.ForeColor = Color.DarkRed;
					//Label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

					Label.Text = line.Name;
					Label.Location = new Point(i, j);
					Label.Size = new Size(128, 29);
					dynamicTextBox.Name = line.Name;
					dynamicTextBox.Text = "";
					dynamicTextBox.Location = new Point(k, j);
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
		private void DetailleClient_Load(object sender, EventArgs e)
		{

		}
 
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void picture_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					picture.ImageLocation = dialog.FileName.ToString();

					string path = Path.Combine(@"images\");
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}

					var filename = System.IO.Path.GetFileName(dialog.FileName);
					path = path + filename;
					File.Copy(dialog.FileName, path, true);
					FileName = filename;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Information");
			}
		}

		private void bankacount_Paint(object sender, PaintEventArgs e)
		{

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
					else if (line.Type == "Text")
					{
						if (c is TextBox t && t.Name.Equals(line.Name))
							listtstring.Add(t.Text);


					}
					else if (line.Type == "INT")
					{
						if (c is TextBox t && t.Name.Equals(line.Name))
							listtstring.Add(t.Text + '!');


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
 
				if (number_bank.Text != "" && name_banque.Text != "" && name.Text != "" && reference.Text != "" && create_date.Text != "" && cheksocity.Text != "" && phone.Text != "" && email.Text != "" && postal_code.Text != "" && website.Text != "" && fax.Text != ""  && job.Text != "" && note.Text != "")
				{
					string sqlinsertinto = "";

					for (int i = 0; i <listt.Count;i++)
					{

						sqlinsertinto = sqlinsertinto + listt[i].Name + "=@"+i+',';



					}
					string sqlinsertvalue = "";
					for (int i = 0; i < listtstring.Count; i++)
					{
						sqlinsertvalue = sqlinsertvalue + '?' + i + ',';
					}
					MySqlConnection con = new MySqlConnection("datasource= localhost; database=test;port=3306; username = root; password= 123456789CA*"); //open connection
					con.Open();
 
					string SqlCommandeBank = "UPDATE bank_account set number=@number, name_bank=@name_bank  where idbank_account = " + idBank+"";

					string SQLcommand = "UPDATE commercialpartner set name=@name, refrence=@refrence, create_date=@create_date, chec_socity=@chec_socity,phone=@phone,email=@email,idbank_account=@idbank_account,postalcode=@postalcode,idLabel=@idLabel,website=@website,fax=@fax,picture=@picture,idadress=@idadress,JobPosition=@JobPosition,note=@note,Payment=@Payment," + sqlinsertinto.Remove(sqlinsertinto.Length - 1)+ " where idCommercialPartner="+idComer+"";

					string SqlCommandeAdress = "UPDATE adress set name=@name, latitude=@latitude, longtitude=@longtitude  where idadress =" + idAdress+"";
					string SqlCommandeLabel = "UPDATE label set  name=@name, category=@category, color=@color  where idLabel=" + idLabel+"";
		 
					MySqlCommand Adress = new MySqlCommand(SqlCommandeAdress, con);

					Adress.Parameters.Add(new MySqlParameter("@name", adress.Text));
					Adress.Parameters.Add(new MySqlParameter("@latitude", "21"));
					Adress.Parameters.Add(new MySqlParameter("@longtitude", "20"));

					try
					{

						Adress.ExecuteNonQuery();
						 
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}
					MySqlCommand Label = new MySqlCommand(SqlCommandeLabel, con);


					Label.Parameters.Add(new MySqlParameter("@name", label.Text));
					Label.Parameters.Add(new MySqlParameter("@category", "Societe"));
					Label.Parameters.Add(new MySqlParameter("@color", "Red"));

					try
					{

						Label.ExecuteNonQuery();
						 
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}

					//MessageBox.Show(SQLcommand);
					MySqlCommand Bank = new MySqlCommand(SqlCommandeBank, con);
					Bank.Parameters.Add(new MySqlParameter("@name_bank", name_banque.Text));
					Bank.Parameters.Add(new MySqlParameter("@number", number_bank.Text));


					try
					{

						Bank.ExecuteNonQuery();
						 
					}
					catch (Exception Ex)
					{
						MessageBox.Show(Ex.Message);
					}


					MySqlCommand bazaUkaz = new MySqlCommand(SQLcommand, con);

					bazaUkaz.Parameters.Add(new MySqlParameter("@name", name.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@refrence", reference.Text));
					try
					{
						bazaUkaz.Parameters.Add(new MySqlParameter("?@create_date", DateTime.Parse(create_date.Text)));
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
 
					bazaUkaz.Parameters.Add(new MySqlParameter("@chec_socity", cheksocity.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@phone", phone.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@email", email.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@idbank_account", idBank));
					bazaUkaz.Parameters.Add(new MySqlParameter("@postalcode", postal_code.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@idLabel", idLabel));
					bazaUkaz.Parameters.Add(new MySqlParameter("@website", website.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@fax", fax.Text));
					if (FileName == "")
					{
						bazaUkaz.Parameters.Add(new MySqlParameter("@picture", "img.png"));

					}
					else
					{
						bazaUkaz.Parameters.Add(new MySqlParameter("@picture", FileName));

					}

					bazaUkaz.Parameters.Add(new MySqlParameter("@idadress", idAdress));
					bazaUkaz.Parameters.Add(new MySqlParameter("@JobPosition", job.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@note", note.Text));
					bazaUkaz.Parameters.Add(new MySqlParameter("@Payment", payement_condition_customer.Text));
 
					for (int i = 0; i < listtstring.Count; i++)
					{
						if (listtstring[i].ToString().Contains("."))
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("@" + i, Convert.ToDateTime(listtstring[i].ToString())));

						}
						else if (listtstring[i].ToString().Contains("!"))
						{
							try
							{
								if (listtstring[i].ToString().Substring(0, listtstring[i].ToString().Length - 1) != "")
								{
									bazaUkaz.Parameters.Add(new MySqlParameter("@" + i, Convert.ToInt32(listtstring[i].ToString().Substring(0, listtstring[i].ToString().Length - 1))));

								}
								else
								{
									bazaUkaz.Parameters.Add(new MySqlParameter("@" + i, null));

								}

							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
						else
						{
							bazaUkaz.Parameters.Add(new MySqlParameter("@" + i, listtstring[i].ToString()));

						}
					}
					try
					{

						bazaUkaz.ExecuteNonQuery();
						long id = bazaUkaz.LastInsertedId;
						MessageBox.Show("Update successful");
						this.Hide();
						ListClient.instance.GetValueDataClumn();
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

		private void adress_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
	 
	}

