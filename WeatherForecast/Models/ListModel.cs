using System;

namespace WeatherForecast.Models
{
	public class ListModel
	{
        public int Dt { get; set; }
        public MainModel? Main { get; set; }
        public List<WeatherModel>? Weather { get; set; }
        public CloudsModel? Clouds { get; set; }
        public WindModel? Wind { get; set; }
        //public RainModel? Rain { get; set; }
        public SysModel? Sys { get; set; }

        public DateTime DateTime { get; set; }
    }
}

