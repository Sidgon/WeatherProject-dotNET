using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeteoWebAPIService.Models
{
    public class MeteoWebAPIServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MeteoWebAPIServiceContext() : base("name=MeteoWebAPIServiceContext")
        {
        }

        public System.Data.Entity.DbSet<MeteoWebAPIService.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<MeteoWebAPIService.Models.WeatherData> WeatherDatas { get; set; }

        public System.Data.Entity.DbSet<MeteoWebAPIService.Models.WeatherForm> WeatherForms { get; set; }
    }
}
