using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WeatherData
    {
        
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public int Suntime { get; set; }
        
        public int Temperatur { get; set; }
        
        public int RainPrecipation { get; set; }
        
        public int Wind { get; set; }
        
        public byte DayTime { get; set; }
        
        public int LocationID { get; set; }
        public Location Location { get; set; }
        
        public int WeatherFormID { get; set; }
        public WeatherForm WeatherFORM { get; set; }
      
    }
}
