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
    public class WeatherFormEF
    {
        string baseuri = "http://localhost:5850/api/WeatherFormEF/";

        
        public List<DTO.WeatherForm> getWeatherForm()
        {
            string uri = baseuri;


            using (HttpClient client = new HttpClient())
            {
                Task<String> response = client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<WeatherForm>>(response.Result);
            }
        }

        public string getImagePath(int idWeatherForm)
        {
            string name = "";
            string path = "";
            List<WeatherForm> forms = this.getWeatherForm();
            foreach(WeatherForm form in forms)
            {
                if (form.Id == idWeatherForm)
                {
                    name = form.Name;
                }
            }
            if (name.Equals("bluesky"))
            {
                path = "~/Content/150x150/sunny.png";
            }
            if (name.Equals("littlecloudy"))
            {
                path = "~/Content/150x150/m-cloudy.png";
            }
            if (name.Equals("fewrainy"))
            {
                path = "~/Content/150x150/m-c-rain.png";
            }
            if (name.Equals("littlestormy"))
            {
                path = "~/Content/150x150/chance-storm.png";
            }
            if (name.Equals("littleSnow"))
            {
                path = "~/Content/150x150/m-c-snow.png";
            }
            if (name.Equals("cloudy"))
            {
                path = "~/Content/150x150/cloudy.png";
            }
            if (name.Equals("Rainy"))
            {
                path = "~/Content/150x150/rainy.png";
            }
            if (name.Equals("Stormy"))
            {
                path = "~/Content/150x150/thunder-storm.png";
            }
            if (name.Equals("Snow"))
            {
                path = "~/Content/150x150/snow.png";
            }
            return path;
        }

        public bool PostWeatherForm(WeatherForm p)
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

        public bool PutWeatherForm(WeatherForm p)
        {
            string uri = baseuri + p.Id;

            using (HttpClient client = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(p);

                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = client.PutAsync(uri, frame);

                return response.Result.IsSuccessStatusCode;
            }

        }

        public bool DeleteWeatherForm(WeatherForm p)
        {
            string uri = baseuri + p.Id;

            using (HttpClient client = new HttpClient())
            {
                Task<HttpResponseMessage> response = client.DeleteAsync(uri);
                return response.Result.IsSuccessStatusCode;
            }

        }
    }
}
