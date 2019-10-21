using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    public class WeatherHistory
    {
        [Key]
        public Guid WeatherHystoryId { get; set; }
        public DateTime WeatherDateTime { get; set; }
        public City City { get; set; }
        public Weather Weather { get; set; }
    }
}