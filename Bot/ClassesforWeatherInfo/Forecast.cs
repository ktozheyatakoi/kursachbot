using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherBot.ClassesforWeatherInfo
{
    public class Day
    {
        public double maxtemp_c { get; set; }
        public double avgtemp_c { get; set; }
        public string daily_chance_of_rain { get; set; }
        public Condition condition { get; set; }
    }

    public class Forecastday
    {
        public string date { get; set; }
        public Day day { get; set; }
    }

    public class Forecast
    {
        public IList<Forecastday> forecastday { get; set; }
    }

    public class WeatherForecast
    {
        public Location location { get; set; }

        public Forecast forecast { get; set; }
        public long aqi { get; set; }

    }
}

