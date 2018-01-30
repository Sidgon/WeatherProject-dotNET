using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DTO;

namespace BLL
{
    
    public class LocationEF
    {
        
        string baseuri = "http://localhost:5850/api/LocationEF/";

        //hier kommt die ganze logik zb neue sachen hinzufügen
        //Random daten machen und und und

        public List<DTO.Location> getLocation()
        {
            string uri = baseuri;


            using (HttpClient client = new HttpClient())
            {
                Task<String> response = client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<Location>>(response.Result);
            }
        }

        public bool PostLocation(Location p)
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

        public bool PutLocation(Location p)
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

        public bool DeleteLocation(Location p)
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
