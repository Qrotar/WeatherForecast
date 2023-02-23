using System;
namespace WeatherForecast.Models
{
	public class WeatherTodayModel
	{
		public List<WeatherModel> Weather { get; set; }
		public MainModel Main { get; set; }
		public WindModel Wind { get; set; }
		public CloudsModel Clouds { get; set; }
		public int Dt { get; set; }
		public DateTime DateTime { get; set; }
		public SysModel Sys { get; set; }
		public string Name { get; set; }
	}
}

