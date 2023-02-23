﻿using System;
namespace WeatherForecast.Helper
{
	public class DateTimeConvert
	{
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
			return dateTime;
		}
	}
}
