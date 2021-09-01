using System;
using System.Collections.Generic;

namespace WeatherWebAPI
{
    public class WeatherForecastCollection
    {
        List<WeatherForecast> _list = new();

        public void Create(DateTime date, int temperature)
        {
            _list.Add(new(date, temperature));
        }

        public List<WeatherForecast> Read()
        {
            return _list;
        }

        public List<WeatherForecast> Read(DateTime fromTime, DateTime toTime )
        {
            List<WeatherForecast> outList = new();

            foreach (var weather in _list)
            {
                if (weather.Date >= fromTime && weather.Date <= toTime)
                {
                    outList.Add(weather);
                }
            }
            return outList;
        }

        public void Update(DateTime date, int temperature)
        {
            foreach (var weather in _list)
            {
                if (weather.Date == date)
                {
                    weather.TemperatureC = temperature;
                }
            }
        }

        public void Delete(DateTime date)
        {
            for (int i = _list.Count - 1; i >= 0; i--)
            {
                if (_list[i].Date == date)
                {
                    _list.RemoveAt(i);
                }
            }
        }

        public void Delete(DateTime fromTime, DateTime toTime)
        {
            for (int i = _list.Count - 1; i >= 0; i--)
            {
                if (_list[i].Date >= fromTime && _list[i].Date <= toTime)
                {
                    _list.RemoveAt(i);
                }
            }
        }

    }
}