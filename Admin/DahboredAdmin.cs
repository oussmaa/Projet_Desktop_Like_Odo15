using PFE.Users;
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

namespace PFE.Admin
{
	public partial class DahboredAdmin : Form
	{
		public static DahboredAdmin instance;
		public Label label;
		public PictureBox Image ;
		public string IdUsers;
		public string Roles;
 
		public DahboredAdmin(string image, string name,string id,string roles)
		{
			this.Roles = roles;
			this.MaximumSize = new System.Drawing.Size(1700, 1020);
			this.MinimumSize = new System.Drawing.Size(1700, 1020);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.IdUsers = id;


			InitializeComponent();
			this.Photo.ImageLocation = @"C:\Users\oussama.ghariani\Desktop\Study\PFE\bin\Debug\images\" + image;
			this.label2.Text = name;
 			instance = this;
			label = label2;
			this.Image = this.Photo;
			loadform(new Dashbored());
		}
		public void loadform(object Form)
		{
			if (this.mainpanel.Controls.Count > 0)
				this.mainpanel.Controls.RemoveAt(0);
			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.mainpanel.Controls.Add(f);
			this.mainpanel.Tag = f;
			f.Show();
		}
		private void DahboredAdmin_Load(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			loadform(new ListClient());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			loadform(new GestionUsers());
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		 
 

		}

		private void button6_Click_1(object sender, EventArgs e)
		{



			loadform(new Profile(this.IdUsers,Roles));
	 
			
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			 loadform(new Dashbored());
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void Photo_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					Photo.ImageLocation = dialog.FileName.ToString();
					MessageBox.Show(dialog.FileName.ToString());
					string path = Path.Combine(@"images\");
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					var filename = System.IO.Path.GetFileName(dialog.FileName);
					path = path + filename;
					File.Copy(dialog.FileName, path);
					MessageBox.Show(filename);
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			loadform(new Gestionattribute());
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
			Login login = new Login();
			login.Show();
		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			loadform(new GestionClient());
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{

		}
	}
}
