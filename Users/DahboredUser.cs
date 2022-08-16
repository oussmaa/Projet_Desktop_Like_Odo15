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
	public partial class DahboredUser : Form
	{
		public static DahboredUser instance;
		public Label label;
		public PictureBox Image;
		public string IdUsers;
		public string Roles;


		public DahboredUser(string image, string name, string id,string roles)
		{
			this.Roles = roles;
			this.MaximumSize = new System.Drawing.Size(1700, 1100);
			this.MinimumSize = new System.Drawing.Size(1700, 1100);
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

		private void DahboredUser_Load(object sender, EventArgs e)
		{
 
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
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();

		}

		private void mainpanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			loadform(new GestionClient());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			loadform(new GestionSaller());

		}

		private void button1_Click(object sender, EventArgs e)
		{
			loadform(new GestionContact());
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			 loadform(new Profile(this.IdUsers,Roles));
		}

		private void button5_Click(object sender, EventArgs e)
		{
			loadform(new GestionBank());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			loadform(new GestionLabel());
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
			Login login = new Login();
			login.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			loadform(new GestionAdress());
		}
	}
}
