using System;
namespace WeatherForecast.Models
{
	public class MainModel
	{
		public decimal Temp { get; set; }
		public decimal Feels_like { get; set; }
		public decimal Temp_min { get; set; }
		public decimal Temp_max { get; set; }
		public int Pressure { get; set; }
		public int Humidity { get; set; }
	}
}

