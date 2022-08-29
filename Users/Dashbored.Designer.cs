
namespace PFE.Users
{
	partial class Dashbored
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Client = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Client)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(95, 35);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			series1.Color = System.Drawing.Color.DodgerBlue;
			series1.Legend = "Legend1";
			series1.Name = "Users";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(810, 317);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "UserChart";
			title1.Name = "Users";
			title1.Text = "Users";
			this.chart1.Titles.Add(title1);
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// Client
			// 
			this.Client.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			chartArea2.Name = "ChartArea1";
			this.Client.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.Client.Legends.Add(legend2);
			this.Client.Location = new System.Drawing.Point(79, 417);
			this.Client.Name = "Client";
			this.Client.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Client";
			this.Client.Series.Add(series2);
			this.Client.Size = new System.Drawing.Size(837, 300);
			this.Client.TabIndex = 1;
			this.Client.Text = "Nomber de Client";
			this.Client.Click += new System.EventHandler(this.chart2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(383, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Number Of Clients By Date";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Dashbored
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(992, 859);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Client);
			this.Controls.Add(this.chart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dashbored";
			this.Text = "Dashbored";
			this.Load += new System.EventHandler(this.Dashbored_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Client)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Client;
		private System.Windows.Forms.Label label1;
	}
}