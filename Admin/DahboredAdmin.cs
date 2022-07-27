using PFE.Users;
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
	public partial class DahboredAdmin : Form
	{
		public DahboredAdmin()
		{
			this.MaximumSize = new System.Drawing.Size(1700, 1100);
			this.MinimumSize = new System.Drawing.Size(1700, 1100);
			this.StartPosition = FormStartPosition.CenterScreen;
 


			InitializeComponent();
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
			loadform(new GestionClient());
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
			loadform(new Profile());
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
	}
}
