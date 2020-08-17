using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MVCWeatherAPILab.Models
{
    public class Time
    {
        public string LayoutKey { get; set; }
        public string[] StartPeriodName { get; set; }
        public DateTime[] StartValidTime { get; set; }
        public string[] TempLabel { get; set; }
    }
}
