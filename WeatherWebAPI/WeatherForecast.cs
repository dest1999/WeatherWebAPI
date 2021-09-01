using System;

namespace WeatherWebAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        
        public WeatherForecast()
        {
        }

        public WeatherForecast(DateTime dateTime, int temperature)
        {
            Date = dateTime;
            TemperatureC = temperature;
        }

    }
}
