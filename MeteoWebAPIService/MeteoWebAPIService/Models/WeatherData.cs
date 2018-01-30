using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeteoWebAPIService.Models
{
    public class WeatherData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Suntime { get; set; }
        [Required]
        public int Temperatur { get; set; }
        [Required]
        public int RainPrecipation { get; set; }
        [Required]
        public int Wind { get; set; }
        [Required]
        public byte DayTime { get; set; }
        [Required]
        public int LocationID { get; set; }
        public Location Location { get; set; }
        [Required]
        public int WeatherFormID { get; set; }
        public WeatherForm WeatherFORM { get; set; }

    }
}