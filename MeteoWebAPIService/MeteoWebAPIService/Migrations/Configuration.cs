namespace MeteoWebAPIService.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeteoWebAPIService.Models.MeteoWebAPIServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MeteoWebAPIService.Models.MeteoWebAPIServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.WeatherForms.AddOrUpdate(w => w.Id,
               new WeatherForm() { Id = 1, Name = "bluesky" },
               new WeatherForm() { Id = 2, Name = "littlecloudy" },
               new WeatherForm() { Id = 3, Name = "fewrainy" },
               new WeatherForm() { Id = 4, Name = "littlestormy" },
               new WeatherForm() { Id = 5, Name = "littleSnow" },
               new WeatherForm() { Id = 6, Name = "cloudy" },
               new WeatherForm() { Id = 7, Name = "Rainy" },
               new WeatherForm() { Id = 8, Name = "Stormy" },
               new WeatherForm() { Id = 9, Name = "Snow" }

               );
            context.Locations.AddOrUpdate(l => l.Id,
              new Location() { Id = 1, Name = "Brig", Plz = 3900 },
              new Location() { Id = 2, Name = "Visp", Plz = 3930 },
               new Location() { Id = 3, Name = "Leuk", Plz = 3953 },
              new Location() { Id = 4, Name = "Sierre", Plz = 3960 }
              );
            context.WeatherDatas.AddOrUpdate(w => w.Id,
            //  //Tag 1
              new WeatherData() { Id = 1, Date = new DateTime(2017, 05, 26), Suntime=5, Temperatur = 0, RainPrecipation = 0, Wind = 30, DayTime = 1, WeatherFormID = 1, LocationID = 1 },
              new WeatherData() { Id = 2, Date = new DateTime(2017, 05, 26), Suntime = 5, Temperatur = 14, RainPrecipation = 0, Wind = 30, WeatherFormID = 1, LocationID = 1, DayTime = 2 },
              new WeatherData() { Id = 3, Date = new DateTime(2017, 05, 26), Suntime = 5, Temperatur = 14, RainPrecipation = 0, Wind = 30, WeatherFormID = 1, LocationID = 1, DayTime = 3 },
              new WeatherData() { Id = 4, Date = new DateTime(2017, 05, 26), Suntime = 5, Temperatur = 2, RainPrecipation = 0, Wind = 30, WeatherFormID = 1, LocationID = 1, DayTime = 4 }

              //new WeatherData() { Id = 5, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 01, 00), Sunset = new DateTime(2017, 05, 26, 20, 01, 00), Temperatur = 8, RainPrecipation = 1, Wind = 00, WeatherFormID = 2, LocationID = 2, DayTime = 1 },
              //new WeatherData() { Id = 6, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 01, 00), Sunset = new DateTime(2017, 05, 26, 20, 01, 00), Temperatur = 6, RainPrecipation = 1, Wind = 00, WeatherFormID = 2, LocationID = 2, DayTime = 2 },
              //new WeatherData() { Id = 7, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 01, 00), Sunset = new DateTime(2017, 05, 26, 20, 01, 00), Temperatur = 6, RainPrecipation = 1, Wind = 00, WeatherFormID = 2, LocationID = 2, DayTime = 3 },
              //new WeatherData() { Id = 8, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 01, 00), Sunset = new DateTime(2017, 05, 26, 20, 01, 00), Temperatur = 6, RainPrecipation = 1, Wind = 00, WeatherFormID = 2, LocationID = 2, DayTime = 4 },

              //new WeatherData() { Id = 9, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 02, 00), Sunset = new DateTime(2017, 05, 26, 20, 02, 00), Temperatur = 2, RainPrecipation = 10, Wind = 0, WeatherFormID = 8, LocationID = 3, DayTime = 1 },
              //new WeatherData() { Id = 10, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 02, 00), Sunset = new DateTime(2017, 05, 26, 20, 02, 00), Temperatur = -1, RainPrecipation = 10, Wind = 0, WeatherFormID = 5, LocationID = 3, DayTime = 2 },
              //new WeatherData() { Id = 11, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 02, 00), Sunset = new DateTime(2017, 05, 26, 20, 02, 00), Temperatur = 0, RainPrecipation = 10, Wind = 0, WeatherFormID = 9, LocationID = 3, DayTime = 3 },
              //new WeatherData() { Id = 12, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 05, 00), Sunset = new DateTime(2017, 05, 26, 20, 02, 00), Temperatur = 0, RainPrecipation = 10, Wind = 1, WeatherFormID = 9, LocationID = 3, DayTime = 4 },

              //new WeatherData() { Id = 13, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 05, 00), Sunset = new DateTime(2017, 05, 26, 20, 05, 00), Temperatur = 16, RainPrecipation = 5, Wind = 20, WeatherFormID = 3, LocationID = 4, DayTime = 1 },
              //new WeatherData() { Id = 14, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 05, 00), Sunset = new DateTime(2017, 05, 26, 20, 05, 00), Temperatur = 5, RainPrecipation = 5, Wind = 20, WeatherFormID = 3, LocationID = 4, DayTime = 2 },
              //new WeatherData() { Id = 15, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 05, 00), Sunset = new DateTime(2017, 05, 26, 20, 05, 00), Temperatur = 7, RainPrecipation = 2, Wind = 24, WeatherFormID = 2, LocationID = 4, DayTime = 3 },
              //new WeatherData() { Id = 16, Date = new DateTime(2017, 05, 26), Sunrise = new DateTime(2017, 05, 26, 05, 05, 00), Sunset = new DateTime(2017, 05, 26, 20, 05, 00), Temperatur = 13, RainPrecipation = 0, Wind = 26, WeatherFormID = 2, LocationID = 4, DayTime = 4 },


              // //Tag 2
              // new WeatherData() { Id = 17, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 00, 00), Temperatur = 0, RainPrecipation = 0, Wind = 15, WeatherFormID = 1, LocationID = 1, DayTime = 1 },
              // new WeatherData() { Id = 18, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 00, 00), Temperatur = 14, RainPrecipation = 0, Wind = 15, WeatherFormID = 1, LocationID = 1, DayTime = 2 },
              // new WeatherData() { Id = 19, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 00, 00), Temperatur = 26, RainPrecipation = 0, Wind = 25, WeatherFormID = 1, LocationID = 1, DayTime = 3 },
              // new WeatherData() { Id = 20, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 00, 00), Temperatur = 14, RainPrecipation = 0, Wind = 30, WeatherFormID = 1, LocationID = 1, DayTime = 4 },

              // new WeatherData() { Id = 21, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 01, 00), Temperatur = 1, RainPrecipation = 0, Wind = 26, WeatherFormID = 2, LocationID = 2, DayTime = 1 },
              // new WeatherData() { Id = 22, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 01, 00), Temperatur = 24, RainPrecipation = 0, Wind = 28, WeatherFormID = 1, LocationID = 2, DayTime = 2 },
              // new WeatherData() { Id = 23, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 01, 00), Temperatur = 11, RainPrecipation = 0, Wind = 27, WeatherFormID = 2, LocationID = 2, DayTime = 3 },
              // new WeatherData() { Id = 24, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 01, 00), Temperatur = 0, RainPrecipation = 0, Wind = 24, WeatherFormID = 4, LocationID = 2, DayTime = 4 },

              // new WeatherData() { Id = 25, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 02, 00), Temperatur = 2, RainPrecipation = 0, Wind = 00, WeatherFormID = 4, LocationID = 3, DayTime = 1 },
              // new WeatherData() { Id = 26, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 02, 00), Temperatur = 8, RainPrecipation = 0, Wind = 02, WeatherFormID = 4, LocationID = 3, DayTime = 2 },
              // new WeatherData() { Id = 27, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 02, 00), Temperatur = 11, RainPrecipation = 0, Wind = 17, WeatherFormID = 1, LocationID = 3, DayTime = 3 },
              // new WeatherData() { Id = 28, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 02, 00), Temperatur = 8, RainPrecipation = 0, Wind = 36, WeatherFormID = 1, LocationID = 3, DayTime = 4 },

              // new WeatherData() { Id = 29, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 05, 00), Temperatur = 16, RainPrecipation = 0, Wind = 25, WeatherFormID = 1, LocationID = 4, DayTime = 1 },
              // new WeatherData() { Id = 30, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 05, 00), Temperatur = 24, RainPrecipation = 2, Wind = 24, WeatherFormID = 1, LocationID = 4, DayTime = 2 },
              // new WeatherData() { Id = 31, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 05, 00), Temperatur = 25, RainPrecipation = 4, Wind = 23, WeatherFormID = 1, LocationID = 4, DayTime = 3 },
              // new WeatherData() { Id = 32, Date = new DateTime(2017, 05, 27), Sunrise = new DateTime(2017, 05, 27, 05, 00, 00), Sunset = new DateTime(2017, 05, 27, 20, 05, 00), Temperatur = 11, RainPrecipation = 6, Wind = 28, WeatherFormID = 1, LocationID = 4, DayTime = 4 }
              );
        }
    }
}
