using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBot.ClassesforWeatherInfo
{
    public class Location
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    public class Condition
    {
        public string text { get; set; }
    }

    public class Current
    {
        public double temp_c { get; set; }
        public Condition condition { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public double pressure_mb { get; set; }
        public int humidity { get; set; }
        public int cloud { get; set; }
        public double feelslike_c { get; set; }
        public double vis_km { get; set; }
    }

    public class Weather
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public long aqi { get; set; }

    }
}
