using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static Lab2.Form1;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
	public partial class Form1 : Form
	{
		private HttpClient client;
		private WeatherHistory weatherhistory;
		public Form1()
		{
			InitializeComponent();
			weatherhistory = new WeatherHistory();
			client = new HttpClient();
		}
		string api_key = "a36c4942dc1564603b3dfbe5ccd2205d";
		string text_details, text_details2;
		string t_min, t_max, wnd, hm, pr;
		int hm2;
		//string name;
		//private void listBox_cities_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	name = listBox_cities.SelectedItem.ToString();
		//}
		private async void buttondownload_ClickAsync(object sender, EventArgs e)
		{
			// longitutde - dlugosc goeograficzna
			// latitude - szerokosc geogr

			string call, name2;

			if (listBox_cities.SelectedIndex != -1)
			{
				name2 = listBox_cities.SelectedItem.ToString();
				call = "http://api.openweathermap.org/data/2.5/weather?q=" + name2 + "&APPID=" + api_key + "&units=metric";
			}
			else
			{
				call = "http://api.openweathermap.org/data/2.5/weather?q=" + textBox_city.Text + "&APPID=" + api_key + "&units=metric";
			}
			//string call = "https://api.openweathermap.org/data/2.5/weather?lat=51.10&lon=17.03&appid=a36c4942dc1564603b3dfbe5ccd2205d";
			string response = await client.GetStringAsync(call);
			WeatherInfo.Root Info = JsonSerializer.Deserialize<WeatherInfo.Root>(response);

			pictureBox_icon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

			label_desc.Text = Info.weather[0].main + " (" + Info.weather[0].description + ")";
			panel_desc.Controls.Add(label_desc);

			label_temp.Text = Info.main.temp + " °C";
			panel_temp.Controls.Add(label_temp);

			label_fl.Text = Info.main.feels_like + " °C";
			panel_fl.Controls.Add(label_fl);

			label_date.Text = convertDayTime(Info.dt).ToString();
			panel_date.Controls.Add(label_date);

			//text_details = convertDayTime(Info.sys.sunrise).ToShortTimeString();
			text_details = convertDayTime(Info.sys.sunrise).ToShortTimeString();
			text_details2 = convertDayTime(Info.sys.sunset).ToShortTimeString();
			t_min = Info.main.temp_min.ToString();
			t_max = Info.main.temp_max.ToString();
			wnd = Info.wind.speed.ToString();
			hm = Info.main.humidity.ToString();
			hm2 = Info.main.humidity;
			pr = Info.main.pressure.ToString();

			if (listBox_cities.SelectedIndex != -1)
			{
				weatherhistory.WeatherInfos.Add(new WeatherInfo2() { name = listBox_cities.SelectedItem.ToString(), date = Info.dt, temp = Info.main.temp, feels_like = Info.main.feels_like });
			}
			else
			{
				weatherhistory.WeatherInfos.Add(new WeatherInfo2() { name = textBox_city.Text, date = Info.dt, temp = Info.main.temp, feels_like = Info.main.feels_like });
			}
			weatherhistory.SaveChanges();
		}

		private void button_details_Click(object sender, EventArgs e)
		{
			textBox1.Text = "Selected details:";
			if (checkBox_tempmin.Checked)
			{
				textBox1.Text += "\r\nMinimum temperature: " + t_min + "°C";
			}
			if (checkBox_tempmax.Checked)
			{
				textBox1.Text += "\r\nMaximum temperature: " + t_max + "°C";
			}
			if (checkBox_humidity.Checked)
			{
				textBox1.Text += "\r\nHumidity: " + hm + " %";
			}
			if (checkBox_wind.Checked)
			{
				textBox1.Text += "\r\nWind speed: " + wnd + " km/h";
			}
			if (checkBox_sunrise.Checked)
			{
				textBox1.Text += "\r\nSunrise: " + text_details;
			}
			if (checkBox_sunset.Checked)
			{
				textBox1.Text += "\r\nSunset: " + text_details2;
			}
			if (checkBox_pressure.Checked)
			{
				textBox1.Text += "\r\nPressure: " + pr + " hPa";
			}
			progressBar1.Value = hm2;
		}


		DateTime convertDayTime(long sec)
		{
			DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
			day = day.AddSeconds(sec).ToLocalTime();
			return day;
		}
		private void button_clear_Click(object sender, EventArgs e)
		{
			listBox_cities.ClearSelected();
		}

		private void button_history_Click(object sender, EventArgs e)
		{
			listBox_db.DataSource = weatherhistory.WeatherInfos.ToList<WeatherInfo2>();
		}
		private void button_more_Click(object sender, EventArgs e)
		{
			string name3;
			if (listBox_details.SelectedIndex != -1)
			{
				//DateTime a = new DateTime(2024, 03, 25, 0, 0, 0);
				name3 = listBox_details.SelectedItem.ToString();
				{
					if (name3 == "Temp > 10")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.Where(s => s.temp > 10).ToList<WeatherInfo2>();
					}
					else if (name3 == "City = Wroc³aw")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.Where(s => s.name == "Wroc³aw").ToList<WeatherInfo2>();
					}
					else if (name3 == "Temp < 5")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.Where(s => s.temp < 5).ToList<WeatherInfo2>();
					}
					else if (name3 == "Sort desc by temp")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.OrderBy(s => s.temp).Reverse().ToList<WeatherInfo2>();
					}
					else if (name3 == "Sort alphabetically")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.OrderBy(s => s.name).ToList<WeatherInfo2>();
					}
					else if (name3 == "Sort by newest")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.OrderBy(s => s.date).Reverse().ToList<WeatherInfo2>();
					}

					// ---------------------------------------------------------------------------------
					// do usuwania, trzeba dodaæ delete errors do listboxa

					/*else if(name3 == "delete errors")
					{
						var wth = weatherhistory.WeatherInfos.First(s => s.name == "czêstochowa");
						weatherhistory.WeatherInfos.Remove(wth);
						weatherhistory.SaveChanges();
						listBox_db.DataSource = weatherhistory.WeatherInfos.ToList<WeatherInfo2>();
					}*/

					// ---------------------------------------------------------------------------------
					// nie dzia³a

					/*else if( name3 == "Date = 25.03.2024")
					{
						listBox_db.DataSource = weatherhistory.WeatherInfos.Where(s => s.convertDayTime(date).ToString() = (2024, 03, 25));
					}*/
				}
			}
		}

		private void button_city_det_Click(object sender, EventArgs e)
		{
			string name4;
			name4 = textBox_city_det.Text;
			listBox_db.DataSource = weatherhistory.WeatherInfos.Where(s => s.name == $"{name4}").ToList<WeatherInfo2>();
		}

		private void button_clear2_Click(object sender, EventArgs e)
		{
			listBox_details.ClearSelected();
		}
	}

	class WeatherInfo
	{
		public class Coord
		{
			public double lat { get; set; }
			public double lon { get; set; }
		}

		public class Weather
		{
			public string main { get; set; }
			public string description { get; set; }
			public string icon { get; set; }
		}

		public class Main
		{
			public double temp { get; set; }
			public double feels_like { get; set; }
			public double temp_min { get; set; }
			public double temp_max { get; set; }
			public int pressure { get; set; }
			public int humidity { get; set; }
		}

		public class Wind
		{
			public double speed { get; set; }
		}

		public class Sys
		{
			public long sunrise { get; set; }
			public long sunset { get; set; }
		}

		public class Root
		{
			public Coord coord { get; set; }
			public List<Weather> weather { get; set; }
			public Main main { get; set; }
			public Wind wind { get; set; }
			public Sys sys { get; set; }
			public string name { get; set; }
			public long dt { get; set; }

		}
	}

	internal class WeatherHistory : DbContext
	{
		public DbSet<WeatherInfo2> WeatherInfos { get; set; }
		public WeatherHistory()
		{
			Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite(@" Data Source = Base.db");
		}
	}
	internal class WeatherInfo2()
	{
		public int id { get; set; }
		public required string name { get; set; }
		public required long date {  get; set; }
		public required double temp { get; set; }
		public required double feels_like { get; set; }
		public DateTime convertDayTime(long sec)
		{
			DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
			day = day.AddSeconds(sec).ToLocalTime();
			return day;
		}
		public override string ToString()
		{
			return $"city: {name} | date = {convertDayTime(date)} | temperature: {temp} | feels like = {feels_like}";
		}
	}
}
