using System;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WeatherForecast.Models;



namespace WeatherForecast.Data
{
	public static class ApiData
	{
        public static async Task<WeatherForecastModel> GetWeatherForecast(string baseURL, string apiKey)
        {
            WeatherForecastModel weatherForecast = new WeatherForecastModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                string apiRequest = $"forecast?q=Karlstad,se&units=metric&appid={apiKey}";

                HttpResponseMessage getData = await client.GetAsync(apiRequest);

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    weatherForecast = JsonConvert.DeserializeObject<WeatherForecastModel>(results);

                    foreach (var date in weatherForecast.List)
                    {
                        date.DateTime = Helper.DateTimeConvert.UnixTimeStampToDateTime(date.Dt);
                    }

                    return weatherForecast;

                }
                else
                {
                    //Specificera exception ....
                    throw new Exception();
                }
            }
        }

        public static async Task<WeatherTodayModel> GetWeatherToday(string baseURL, string apiKey)
        {
            WeatherTodayModel weatherToday = new WeatherTodayModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                string apiRequest = $"weather?q=Karlstad,se&units=metric&appid={apiKey}";

                HttpResponseMessage getData = await client.GetAsync(apiRequest);

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    weatherToday = JsonConvert.DeserializeObject<WeatherTodayModel>(results);

                    weatherToday.DateTime = Helper.DateTimeConvert.UnixTimeStampToDateTime(weatherToday.Dt);
                    weatherToday.Sys.RiseTime = Helper.DateTimeConvert.UnixTimeStampToDateTime(weatherToday.Sys.Sunrise);
                    weatherToday.Sys.SetTime = Helper.DateTimeConvert.UnixTimeStampToDateTime(weatherToday.Sys.Sunset);

                    return weatherToday;

                }
                else
                {
                    //Specificera exception ....
                    throw new Exception();
                }
            }
        }




    }
}

