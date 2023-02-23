using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherForecast.Models
{
	public class RainModel
	{
		[JsonProperty("3h")]
        public decimal Amount { get; set; }
	}
}

