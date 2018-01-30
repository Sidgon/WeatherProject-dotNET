using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WeatherDataEF
    {
       
        string baseuri = "http://localhost:5850/api/WeatherDataEF/";

        public WeatherData RandomLocDatetime(int locID, DateTime date, int time)
        {
            Random random = new Random();
            WeatherData weatherdata = new WeatherData();
            weatherdata.Date = date;
            weatherdata.LocationID = locID;
            weatherdata.DayTime = (byte) time;
            weatherdata.WeatherFormID = random.Next(1, 10);

            switch (weatherdata.WeatherFormID)
            {
                case 1:
                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = 1;
                        weatherdata.Temperatur = 5;
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 0;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 6;
                        weatherdata.Temperatur = random.Next(20, 24);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 0;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(5, 6);
                        weatherdata.Temperatur = random.Next(16, 20);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 0;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(5, 20);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 0;
                    }
                    break;
                case 2:
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 1;
                        weatherdata.Temperatur = 3;
                        weatherdata.RainPrecipation = 1;
                        weatherdata.Wind = 1;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 4;
                        weatherdata.Temperatur = random.Next(14, 16);
                        weatherdata.RainPrecipation = 2;
                        weatherdata.Wind = 2;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(3, 5);
                        weatherdata.Temperatur = random.Next(16, 20);
                        weatherdata.RainPrecipation = 3;
                        weatherdata.Wind = 2;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(5, 27);
                        weatherdata.RainPrecipation = 2;
                        weatherdata.Wind = 2;
                    }
                    break;
                case 3:

                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = 2;
                        weatherdata.RainPrecipation = 8;
                        weatherdata.Wind = 12;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = random.Next(2, 6);
                        weatherdata.Temperatur = random.Next(16, 18);
                        weatherdata.RainPrecipation = 10;
                        weatherdata.Wind = 10;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(2, 6);
                        weatherdata.Temperatur = random.Next(16, 18);
                        weatherdata.RainPrecipation = 10;
                        weatherdata.Wind = 10;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(2, 5);
                        weatherdata.RainPrecipation = 6;
                        weatherdata.Wind = 7;
                    }
                    break;
                case 4:
                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = 1;
                        weatherdata.Temperatur = 5;
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 20;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 6;
                        weatherdata.Temperatur = random.Next(20, 24);
                        weatherdata.RainPrecipation = 4;
                        weatherdata.Wind = 25;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(5, 6);
                        weatherdata.Temperatur = random.Next(16, 20);
                        weatherdata.RainPrecipation = 4;
                        weatherdata.Wind = 27;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(5, 10);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 18;
                    }
                    break;
                case 5:
                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = random.Next(-1, 2);
                        weatherdata.Temperatur = 5;
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 3;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 2;
                        weatherdata.Temperatur = random.Next(20, 24);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 2;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(1, 6);
                        weatherdata.Temperatur = random.Next(16, 20);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 1;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(0, 2);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 1;
                    }
                    break;
                case 6:

                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = random.Next(5, 8);
                        weatherdata.Temperatur = 10;
                        weatherdata.RainPrecipation = 13;
                        weatherdata.Wind = 3;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 2;
                        weatherdata.Temperatur = random.Next(10, 20);
                        weatherdata.RainPrecipation = 15;
                        weatherdata.Wind = 2;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(1, 4);
                        weatherdata.Temperatur = random.Next(10, 25);
                        weatherdata.RainPrecipation = 15;
                        weatherdata.Wind = 1;         
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(0, 2);
                        weatherdata.RainPrecipation = 14;
                        weatherdata.Wind = 10;
                    }
                    break;
                case 7:

                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = 1;
                        weatherdata.Temperatur = 5;
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 20;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 3;
                        weatherdata.Temperatur = random.Next(8, 18);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 22;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(2, 3);
                        weatherdata.Temperatur = random.Next(12, 18);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 23;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(6, 8);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 20;
                    }
                    break;
                case 8:

                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = 1;
                        weatherdata.Temperatur = 5;
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 30;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 6;
                        weatherdata.Temperatur = random.Next(20, 24);
                        weatherdata.RainPrecipation = 3;
                        weatherdata.Wind = 32;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(5, 6);
                        weatherdata.Temperatur = random.Next(16, 20);
                        weatherdata.RainPrecipation = 4;
                        weatherdata.Wind = 33;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(5, 20);
                        weatherdata.RainPrecipation = 2;
                        weatherdata.Wind = 35;
                    }
                    break;
                case 9:
                    if (weatherdata.DayTime == 1)
                    {
                        weatherdata.Suntime = random.Next(0, 2);
                        weatherdata.Temperatur = random.Next(-10, 2);
                        weatherdata.RainPrecipation = 0;
                        weatherdata.Wind = 10;
                    }
                    if (weatherdata.DayTime == 2)
                    {
                        weatherdata.Suntime = 6;
                        weatherdata.Temperatur = random.Next(-4, 4);
                        weatherdata.RainPrecipation = 10;
                        weatherdata.Wind = 7;
                    }
                    if (weatherdata.DayTime == 3)
                    {
                        weatherdata.Suntime = random.Next(5, 6);
                        weatherdata.Temperatur = random.Next(-4, 4);
                        weatherdata.RainPrecipation = 10;
                        weatherdata.Wind = 8;
                    }
                    if (weatherdata.DayTime == 4)
                    {
                        weatherdata.Suntime = 0;
                        weatherdata.Temperatur = random.Next(-4,4);
                        weatherdata.RainPrecipation = 10;
                        weatherdata.Wind = 10;
                    }
                    break;
            }

            return weatherdata;
        }

        public List<DTO.WeatherData> RandomLocDate(int locID, DateTime date)
        {
            List<WeatherData> listweaterdata = new List<WeatherData>();
            for (int i = 1; i < 5; i++)
            {
                listweaterdata.Add(getWeatherdataone(locID, date, i));
            }
            return listweaterdata;
        }

        public List<List<WeatherData>> RandomLoc(int locationID)
        {
            List<List<WeatherData>> returnList = new List<List<WeatherData>>();

            DateTime date =System.DateTime.Now; ;
            for (int i = 0; i < 7; i++)
            {
                returnList.Add(RandomLocDate(locationID, date.AddDays(i)));
            }
            return returnList;
            
        }

        public WeatherData getWeatherdataone(int locID, DateTime date, int time)
        {
            List<DTO.WeatherData> weatherdata = new List<DTO.WeatherData>();
            weatherdata = getWeaterData();

            for (int i = 0; i < weatherdata.Count; i++)
            {
                if (weatherdata[i].LocationID == locID && weatherdata[i].Date.Date.Equals(date.Date) && weatherdata[i].DayTime == time)
                {
                    return weatherdata[i];
                }

            }

            PostWeaterData(RandomLocDatetime(locID, date, time));
            return getWeatherdataone(locID, date, time);

        }


        public List<DTO.WeatherData> getWeaterData()
        {
            string uri = baseuri;
            using (HttpClient client = new HttpClient())
            {
                Task<String> response = client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<WeatherData>>(response.Result);
            }
        }

        public bool PostWeaterData(WeatherData p)
        {
            string uri = baseuri;

            using (HttpClient client = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(p);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = client.PostAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }

        }

        public bool PutWeaterData(WeatherData p)
        {
            string uri = baseuri+p.Id;

            using (HttpClient client = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(p);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = client.PutAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }

        }

        public bool DeleteWeaterData(WeatherData p)
        {
            string uri = baseuri+p.Id;

            using (HttpClient client = new HttpClient())
            {
                Task<HttpResponseMessage> response = client.DeleteAsync(uri);
                return response.Result.IsSuccessStatusCode;
            }

        }

        //public List<List<WeatherData>> getWeatherForecast(int id)
        //{
        //    List<List<WeatherData>> returnList = new List<List<WeatherData>>();
            
        //    //List<WeatherData> weatherforecast = new List<WeatherData>();
        //    //List<WeatherData> weatherforecastadd = new List<WeatherData>();

        //    //string uri = baseuri;

        //    //using (HttpClient client = new HttpClient())
        //    //{

        //    //    Task<String> response = client.GetStringAsync(uri);
        //    //    weatherforecast = JsonConvert.DeserializeObject<List<WeatherData>>(response.Result);

        //    //    foreach (var weather in weatherforecast)
        //    //    {
        //    //        if (weather.LocationID == id )
        //    //        {
        //    //            weatherforecastadd.Add(weather);
        //    //        }
        //    //    }
        //    //    return weatherforecastadd;               
        //    //}
        //}
    }
}
