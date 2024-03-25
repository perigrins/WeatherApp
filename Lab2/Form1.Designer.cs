using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace Lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			textBox1 = new TextBox();
			buttondownload = new Button();
			listBox_cities = new ListBox();
			textBox_city = new TextBox();
			label_top = new Label();
			label_addons = new Label();
			label_history = new Label();
			button_details = new Button();
			label_current = new Label();
			label_feelslike = new Label();
			panel_desc = new Panel();
			panel_temp = new Panel();
			panel_fl = new Panel();
			label_desc = new Label();
			label_temp = new Label();
			label_fl = new Label();
			checkBox_tempmin = new CheckBox();
			checkBox_tempmax = new CheckBox();
			checkBox_humidity = new CheckBox();
			checkBox_wind = new CheckBox();
			checkBox_sunrise = new CheckBox();
			checkBox_sunset = new CheckBox();
			button_clear = new Button();
			button_history = new Button();
			panel_date = new Panel();
			label_date = new Label();
			progressBar1 = new ProgressBar();
			label_bar = new Label();
			listBox_db = new ListBox();
			listBox_details = new ListBox();
			button_more = new Button();
			pictureBox_icon = new PictureBox();
			textBox_city_det = new TextBox();
			button_city_det = new Button();
			checkBox_pressure = new CheckBox();
			button_clear2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox_icon).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.MistyRose;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 238);
			textBox1.ForeColor = Color.FromArgb(64, 0, 64);
			textBox1.Location = new Point(349, 871);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(521, 234);
			textBox1.TabIndex = 0;
			// 
			// buttondownload
			// 
			buttondownload.BackColor = Color.RosyBrown;
			buttondownload.FlatAppearance.BorderColor = Color.Lavender;
			buttondownload.FlatAppearance.BorderSize = 4;
			buttondownload.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			buttondownload.ForeColor = SystemColors.Control;
			buttondownload.Location = new Point(670, 187);
			buttondownload.Name = "buttondownload";
			buttondownload.Size = new Size(200, 121);
			buttondownload.TabIndex = 1;
			buttondownload.Text = "search!";
			buttondownload.UseVisualStyleBackColor = false;
			buttondownload.Click += buttondownload_ClickAsync;
			// 
			// listBox_cities
			// 
			listBox_cities.BackColor = Color.MistyRose;
			listBox_cities.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			listBox_cities.ForeColor = Color.FromArgb(64, 0, 64);
			listBox_cities.FormattingEnabled = true;
			listBox_cities.ItemHeight = 41;
			listBox_cities.Items.AddRange(new object[] { "Wrocław", "Częstochowa", "Warsaw", "Oslo", "New York", "Dublin", "Sydney", "Canberra", "Juba" });
			listBox_cities.Location = new Point(129, 274);
			listBox_cities.Name = "listBox_cities";
			listBox_cities.Size = new Size(467, 209);
			listBox_cities.TabIndex = 2;
			// 
			// textBox_city
			// 
			textBox_city.BackColor = Color.MistyRose;
			textBox_city.BorderStyle = BorderStyle.None;
			textBox_city.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
			textBox_city.Location = new Point(129, 187);
			textBox_city.Multiline = true;
			textBox_city.Name = "textBox_city";
			textBox_city.PlaceholderText = "insert a city name";
			textBox_city.Size = new Size(467, 57);
			textBox_city.TabIndex = 3;
			textBox_city.TextAlign = HorizontalAlignment.Center;
			textBox_city.UseWaitCursor = true;
			// 
			// label_top
			// 
			label_top.AutoSize = true;
			label_top.BackColor = Color.Transparent;
			label_top.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_top.ForeColor = SystemColors.Control;
			label_top.Location = new Point(129, 52);
			label_top.Name = "label_top";
			label_top.Size = new Size(467, 92);
			label_top.TabIndex = 4;
			label_top.Text = "Insert a city name or choose\nfrom the list below:";
			label_top.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label_addons
			// 
			label_addons.AutoSize = true;
			label_addons.BackColor = Color.Transparent;
			label_addons.Font = new Font("Segoe UI Semibold", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_addons.ForeColor = SystemColors.ButtonFace;
			label_addons.Location = new Point(130, 598);
			label_addons.Name = "label_addons";
			label_addons.Size = new Size(404, 230);
			label_addons.TabIndex = 5;
			label_addons.Text = "Click the 'details' button\nfor more information!\n\nCheck the desired details\nyou want to see";
			// 
			// label_history
			// 
			label_history.AutoSize = true;
			label_history.BackColor = Color.Transparent;
			label_history.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_history.ForeColor = Color.Thistle;
			label_history.Location = new Point(1105, 565);
			label_history.Name = "label_history";
			label_history.Size = new Size(389, 62);
			label_history.TabIndex = 6;
			label_history.Text = "Weather History";
			// 
			// button_details
			// 
			button_details.BackColor = Color.RosyBrown;
			button_details.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_details.ForeColor = SystemColors.Control;
			button_details.Location = new Point(670, 736);
			button_details.Name = "button_details";
			button_details.Size = new Size(200, 92);
			button_details.TabIndex = 8;
			button_details.Text = "details";
			button_details.UseVisualStyleBackColor = false;
			button_details.Click += button_details_Click;
			// 
			// label_current
			// 
			label_current.AutoSize = true;
			label_current.BackColor = Color.Transparent;
			label_current.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_current.ForeColor = SystemColors.Control;
			label_current.Location = new Point(1105, 82);
			label_current.Name = "label_current";
			label_current.Size = new Size(392, 62);
			label_current.TabIndex = 9;
			label_current.Text = "Current Weather";
			// 
			// label_feelslike
			// 
			label_feelslike.AutoSize = true;
			label_feelslike.BackColor = Color.Transparent;
			label_feelslike.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_feelslike.ForeColor = SystemColors.Control;
			label_feelslike.Location = new Point(1105, 326);
			label_feelslike.Name = "label_feelslike";
			label_feelslike.Size = new Size(184, 50);
			label_feelslike.TabIndex = 14;
			label_feelslike.Text = "Feels like:";
			// 
			// panel_desc
			// 
			panel_desc.BackColor = Color.Transparent;
			panel_desc.ForeColor = Color.Thistle;
			panel_desc.Location = new Point(1105, 177);
			panel_desc.Name = "panel_desc";
			panel_desc.Size = new Size(550, 70);
			panel_desc.TabIndex = 15;
			// 
			// panel_temp
			// 
			panel_temp.BackColor = Color.Transparent;
			panel_temp.ForeColor = Color.Thistle;
			panel_temp.Location = new Point(1105, 253);
			panel_temp.Name = "panel_temp";
			panel_temp.Size = new Size(550, 70);
			panel_temp.TabIndex = 16;
			// 
			// panel_fl
			// 
			panel_fl.BackColor = Color.Transparent;
			panel_fl.ForeColor = Color.Thistle;
			panel_fl.Location = new Point(1105, 395);
			panel_fl.Name = "panel_fl";
			panel_fl.Size = new Size(550, 70);
			panel_fl.TabIndex = 17;
			// 
			// label_desc
			// 
			label_desc.BackColor = Color.Transparent;
			label_desc.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_desc.Location = new Point(0, 0);
			label_desc.Name = "label_desc";
			label_desc.Size = new Size(550, 70);
			label_desc.TabIndex = 18;
			// 
			// label_temp
			// 
			label_temp.BackColor = Color.Transparent;
			label_temp.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_temp.Location = new Point(0, 0);
			label_temp.Name = "label_temp";
			label_temp.Size = new Size(550, 70);
			label_temp.TabIndex = 19;
			// 
			// label_fl
			// 
			label_fl.BackColor = Color.Transparent;
			label_fl.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_fl.Location = new Point(0, 0);
			label_fl.Name = "label_fl";
			label_fl.Size = new Size(550, 70);
			label_fl.TabIndex = 18;
			// 
			// checkBox_tempmin
			// 
			checkBox_tempmin.AutoSize = true;
			checkBox_tempmin.BackColor = Color.Transparent;
			checkBox_tempmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_tempmin.ForeColor = SystemColors.Control;
			checkBox_tempmin.Location = new Point(128, 871);
			checkBox_tempmin.Name = "checkBox_tempmin";
			checkBox_tempmin.Size = new Size(190, 45);
			checkBox_tempmin.TabIndex = 18;
			checkBox_tempmin.Text = "Min temp";
			checkBox_tempmin.UseVisualStyleBackColor = false;
			// 
			// checkBox_tempmax
			// 
			checkBox_tempmax.AutoSize = true;
			checkBox_tempmax.BackColor = Color.Transparent;
			checkBox_tempmax.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_tempmax.ForeColor = SystemColors.Control;
			checkBox_tempmax.Location = new Point(128, 922);
			checkBox_tempmax.Name = "checkBox_tempmax";
			checkBox_tempmax.Size = new Size(195, 45);
			checkBox_tempmax.TabIndex = 19;
			checkBox_tempmax.Text = "Max temp";
			checkBox_tempmax.UseVisualStyleBackColor = true;
			// 
			// checkBox_humidity
			// 
			checkBox_humidity.AutoSize = true;
			checkBox_humidity.BackColor = Color.Transparent;
			checkBox_humidity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_humidity.ForeColor = SystemColors.Control;
			checkBox_humidity.Location = new Point(128, 973);
			checkBox_humidity.Name = "checkBox_humidity";
			checkBox_humidity.Size = new Size(183, 45);
			checkBox_humidity.TabIndex = 20;
			checkBox_humidity.Text = "Humidity";
			checkBox_humidity.UseVisualStyleBackColor = true;
			// 
			// checkBox_wind
			// 
			checkBox_wind.AutoSize = true;
			checkBox_wind.BackColor = Color.Transparent;
			checkBox_wind.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_wind.ForeColor = SystemColors.Control;
			checkBox_wind.Location = new Point(128, 1024);
			checkBox_wind.Name = "checkBox_wind";
			checkBox_wind.Size = new Size(129, 45);
			checkBox_wind.TabIndex = 21;
			checkBox_wind.Text = "Wind";
			checkBox_wind.UseVisualStyleBackColor = true;
			// 
			// checkBox_sunrise
			// 
			checkBox_sunrise.AutoSize = true;
			checkBox_sunrise.BackColor = Color.Transparent;
			checkBox_sunrise.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_sunrise.ForeColor = SystemColors.Control;
			checkBox_sunrise.Location = new Point(128, 1075);
			checkBox_sunrise.Name = "checkBox_sunrise";
			checkBox_sunrise.Size = new Size(156, 45);
			checkBox_sunrise.TabIndex = 22;
			checkBox_sunrise.Text = "Sunrise";
			checkBox_sunrise.UseVisualStyleBackColor = true;
			// 
			// checkBox_sunset
			// 
			checkBox_sunset.AutoSize = true;
			checkBox_sunset.BackColor = Color.Transparent;
			checkBox_sunset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_sunset.ForeColor = SystemColors.Control;
			checkBox_sunset.Location = new Point(128, 1126);
			checkBox_sunset.Name = "checkBox_sunset";
			checkBox_sunset.Size = new Size(148, 45);
			checkBox_sunset.TabIndex = 23;
			checkBox_sunset.Text = "Sunset";
			checkBox_sunset.UseVisualStyleBackColor = true;
			// 
			// button_clear
			// 
			button_clear.BackColor = Color.RosyBrown;
			button_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_clear.ForeColor = SystemColors.Control;
			button_clear.Location = new Point(670, 365);
			button_clear.Name = "button_clear";
			button_clear.Size = new Size(200, 100);
			button_clear.TabIndex = 24;
			button_clear.Text = "clear selection";
			button_clear.UseVisualStyleBackColor = false;
			button_clear.Click += button_clear_Click;
			// 
			// button_history
			// 
			button_history.BackColor = Color.RosyBrown;
			button_history.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_history.ForeColor = SystemColors.Control;
			button_history.Location = new Point(1105, 663);
			button_history.Name = "button_history";
			button_history.Size = new Size(392, 62);
			button_history.TabIndex = 25;
			button_history.Text = "check all historical data";
			button_history.UseVisualStyleBackColor = false;
			button_history.Click += button_history_Click;
			// 
			// panel_date
			// 
			panel_date.BackColor = Color.Transparent;
			panel_date.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			panel_date.ForeColor = Color.Thistle;
			panel_date.Location = new Point(1800, 177);
			panel_date.Name = "panel_date";
			panel_date.Size = new Size(392, 70);
			panel_date.TabIndex = 26;
			// 
			// label_date
			// 
			label_date.BackColor = Color.Transparent;
			label_date.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_date.Location = new Point(0, 0);
			label_date.Name = "label_date";
			label_date.Size = new Size(392, 62);
			label_date.TabIndex = 27;
			// 
			// progressBar1
			// 
			progressBar1.BackColor = Color.MistyRose;
			progressBar1.ForeColor = Color.LightCoral;
			progressBar1.Location = new Point(349, 1268);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(521, 58);
			progressBar1.Style = ProgressBarStyle.Continuous;
			progressBar1.TabIndex = 28;
			// 
			// label_bar
			// 
			label_bar.AutoSize = true;
			label_bar.BackColor = Color.Transparent;
			label_bar.Font = new Font("Segoe UI Semibold", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_bar.ForeColor = SystemColors.Control;
			label_bar.Location = new Point(349, 1176);
			label_bar.Name = "label_bar";
			label_bar.Size = new Size(231, 46);
			label_bar.TabIndex = 29;
			label_bar.Text = "Humidity bar:";
			// 
			// listBox_db
			// 
			listBox_db.BackColor = Color.MistyRose;
			listBox_db.FormattingEnabled = true;
			listBox_db.ItemHeight = 41;
			listBox_db.Location = new Point(1105, 871);
			listBox_db.Name = "listBox_db";
			listBox_db.ScrollAlwaysVisible = true;
			listBox_db.Size = new Size(1304, 455);
			listBox_db.TabIndex = 30;
			// 
			// listBox_details
			// 
			listBox_details.FormattingEnabled = true;
			listBox_details.ItemHeight = 41;
			listBox_details.Items.AddRange(new object[] { "Temp > 10", "City = Wrocław", "Temp < 5", "Sort desc by temp", "Sort alphabetically", "Sort by newest" });
			listBox_details.Location = new Point(1574, 663);
			listBox_details.Name = "listBox_details";
			listBox_details.ScrollAlwaysVisible = true;
			listBox_details.Size = new Size(606, 127);
			listBox_details.TabIndex = 31;
			// 
			// button_more
			// 
			button_more.BackColor = Color.RosyBrown;
			button_more.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_more.ForeColor = SystemColors.Control;
			button_more.Location = new Point(2221, 663);
			button_more.Name = "button_more";
			button_more.Size = new Size(188, 127);
			button_more.TabIndex = 32;
			button_more.Text = "check more stats";
			button_more.UseVisualStyleBackColor = false;
			button_more.Click += button_more_Click;
			// 
			// pictureBox_icon
			// 
			pictureBox_icon.BackColor = Color.Transparent;
			pictureBox_icon.BackgroundImageLayout = ImageLayout.None;
			pictureBox_icon.Location = new Point(1800, 274);
			pictureBox_icon.Name = "pictureBox_icon";
			pictureBox_icon.Size = new Size(208, 156);
			pictureBox_icon.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox_icon.TabIndex = 33;
			pictureBox_icon.TabStop = false;
			// 
			// textBox_city_det
			// 
			textBox_city_det.BackColor = Color.MistyRose;
			textBox_city_det.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			textBox_city_det.Location = new Point(1574, 801);
			textBox_city_det.Name = "textBox_city_det";
			textBox_city_det.PlaceholderText = "insert a city name to get its historical data";
			textBox_city_det.Size = new Size(606, 47);
			textBox_city_det.TabIndex = 34;
			// 
			// button_city_det
			// 
			button_city_det.BackColor = Color.RosyBrown;
			button_city_det.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_city_det.ForeColor = SystemColors.Control;
			button_city_det.Location = new Point(2221, 796);
			button_city_det.Name = "button_city_det";
			button_city_det.Size = new Size(188, 52);
			button_city_det.TabIndex = 35;
			button_city_det.Text = "get data!";
			button_city_det.UseVisualStyleBackColor = false;
			button_city_det.Click += button_city_det_Click;
			// 
			// checkBox_pressure
			// 
			checkBox_pressure.AutoSize = true;
			checkBox_pressure.BackColor = Color.Transparent;
			checkBox_pressure.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			checkBox_pressure.ForeColor = SystemColors.Control;
			checkBox_pressure.Location = new Point(128, 1177);
			checkBox_pressure.Name = "checkBox_pressure";
			checkBox_pressure.Size = new Size(172, 45);
			checkBox_pressure.TabIndex = 36;
			checkBox_pressure.Text = "Pressure";
			checkBox_pressure.UseVisualStyleBackColor = false;
			// 
			// button_clear2
			// 
			button_clear2.BackColor = Color.RosyBrown;
			button_clear2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_clear2.ForeColor = SystemColors.Control;
			button_clear2.Location = new Point(1240, 731);
			button_clear2.Name = "button_clear2";
			button_clear2.Size = new Size(257, 59);
			button_clear2.TabIndex = 37;
			button_clear2.Text = "clear selection";
			button_clear2.UseVisualStyleBackColor = false;
			button_clear2.Click += button_clear2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(2502, 1415);
			Controls.Add(button_clear2);
			Controls.Add(checkBox_pressure);
			Controls.Add(button_city_det);
			Controls.Add(textBox_city_det);
			Controls.Add(pictureBox_icon);
			Controls.Add(button_more);
			Controls.Add(listBox_details);
			Controls.Add(listBox_db);
			Controls.Add(label_bar);
			Controls.Add(progressBar1);
			Controls.Add(panel_date);
			Controls.Add(button_history);
			Controls.Add(button_clear);
			Controls.Add(checkBox_sunset);
			Controls.Add(checkBox_sunrise);
			Controls.Add(checkBox_wind);
			Controls.Add(checkBox_humidity);
			Controls.Add(checkBox_tempmax);
			Controls.Add(checkBox_tempmin);
			Controls.Add(panel_fl);
			Controls.Add(panel_temp);
			Controls.Add(panel_desc);
			Controls.Add(label_feelslike);
			Controls.Add(label_current);
			Controls.Add(button_details);
			Controls.Add(label_history);
			Controls.Add(label_addons);
			Controls.Add(label_top);
			Controls.Add(textBox_city);
			Controls.Add(listBox_cities);
			Controls.Add(buttondownload);
			Controls.Add(textBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Weather App";
			((System.ComponentModel.ISupportInitialize)pictureBox_icon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button buttondownload;
		private ListBox listBox_cities;
		private TextBox textBox_city;
		private Label label_top;
		private Label label_addons;
		private Label label_history;
		private Button button_details;
		private Label label_current;
		private Label label_feelslike;
		private Panel panel_desc;
		private Panel panel_temp;
		private Panel panel_fl;
		private Label label_desc;
		private Label label_temp;
		private Label label_fl;
		private CheckBox checkBox_tempmin;
		private CheckBox checkBox_tempmax;
		private CheckBox checkBox_humidity;
		private CheckBox checkBox_wind;
		private CheckBox checkBox_sunrise;
		private CheckBox checkBox_sunset;
		private Button button_clear;
		private Button button_history;
		private Panel panel_date;
		private Label label_date;
		private ProgressBar progressBar1;
		private Label label_bar;
		private ListBox listBox_db;
		private ListBox listBox_details;
		private Button button_more;
		private PictureBox pictureBox_icon;
		private TextBox textBox_city_det;
		private Button button_city_det;
		private CheckBox checkBox_pressure;
		private Button button_clear2;
	}
}
