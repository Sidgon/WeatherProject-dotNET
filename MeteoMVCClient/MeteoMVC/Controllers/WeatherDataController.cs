using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoMVC.Controllers
{
    public class WeatherDataController : Controller
    {

        //reused access objects
        BLL.LocationEF accessloc = new BLL.LocationEF();
        BLL.WeatherDataEF accessdata = new BLL.WeatherDataEF();
        BLL.WeatherFormEF accessform = new BLL.WeatherFormEF();
        List<List<DTO.WeatherData>> fullist = null;

        // GET: all Product
        public ActionResult Location()
        {

            return View(accessloc.getLocation());
        }


        //post new location
        [HttpPost]
        public ActionResult Location(string Cityname, int PLZ)
        {
            DTO.Location loc = new DTO.Location();
            loc.Name = Cityname;
            loc.Plz = PLZ;
            accessloc.PostLocation(loc);
            return View(accessloc.getLocation());
        }

        public ActionResult Startpage()
        {

            return View(accessloc.getLocation());
        }


        //post new location
        [HttpPost]
        public ActionResult Startpage(string Cityname, int PLZ)
        {
            DTO.Location loc = new DTO.Location();
            loc.Name = Cityname;
            loc.Plz = PLZ;
            accessloc.PostLocation(loc);
            return View(accessloc.getLocation());
        }



        public ActionResult Weatherform()
        {


            return View(accessform.getWeatherForm());
        }

        //load weather data for a location
        public ActionResult Weatherdata(int id)
        {
            //for future referecne save in viewbag
            ViewBag.idlocation = id;

            List<string> path = new List<string>();
            fullist = accessdata.RandomLoc(id);

            for (int i = 0; i < fullist.Count; i++)
            {
                foreach (DTO.WeatherData data in fullist[i])
                {
                    path.Add(accessform.getImagePath(data.WeatherFormID));
                }
            }

            return View(Tuple.Create<List<List<DTO.WeatherData>>, List<string>>(fullist, path));
        }


        public ActionResult Delete(List<List<DTO.WeatherData>> data, int idlocation)
        {
            //for future referecne save in viewbag
            ViewBag.idlocation = idlocation;

            List<DTO.Location> loclist = accessloc.getLocation();
            List<List<DTO.WeatherData>> fullist = accessdata.RandomLoc(idlocation);
            //get location object from id 
            foreach (DTO.Location loc in loclist)
            {
                if (loc.Id == idlocation)
                {
                    accessloc.DeleteLocation(loc);
                }
            }
            for (int i = 0; i < fullist.Count; i++)
            {
                foreach (DTO.WeatherData datasingle in fullist[i])
                {
                    accessdata.DeleteWeaterData(datasingle);
                }
            }
            return RedirectToAction("Location", "WeatherData");
        }

        public ActionResult Change(int id, int idlocation)
        {
            //for future referecne save in viewbag
            ViewBag.idlocation = idlocation;

            //make dropdownlist
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "bluesky", Value = "0" });

            items.Add(new SelectListItem { Text = "littlecloudy", Value = "1" });

            items.Add(new SelectListItem { Text = "fewrainy", Value = "2", Selected = true });

            items.Add(new SelectListItem { Text = "littlestormy", Value = "3" });

            ViewBag.myDropdownlistItems = items;

            /*
             *             if (name.Equals("bluesky"))
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
             * 
             * */

            DTO.WeatherData changedata = null;
            fullist = accessdata.RandomLoc(idlocation);
            for (int i = 0; i < fullist.Count; i++)
            {
                foreach (DTO.WeatherData data in fullist[i])
                {
                    if (data.Id == id)
                    {
                        changedata = data;
                    }
                }
            }

            return View(changedata);
        }
        
        [HttpPost]
        public ActionResult Change(DTO.WeatherData data)
        {
            if (ModelState.IsValid)
            {
                accessdata.PutWeaterData(data);
            }
            //for future referecne save in viewbag
            ViewBag.idlocation = data.LocationID;

            return RedirectToAction("WeatherData", "Weatherdata", new { id = ViewBag.idlocation });

        }

        public ActionResult DeleteSingleWeather(int idweatherdata, int idlocation)
        {
            //for future referecne save in viewbag
            ViewBag.idlocation = idlocation;

            fullist = accessdata.RandomLoc(idlocation);
            for (int i = 0; i < fullist.Count; i++)
            {
                foreach (DTO.WeatherData data in fullist[i])
                {
                    if (data.Id == idweatherdata)
                    {
                        accessdata.DeleteWeaterData(data);
                    }
                }
            }
            return RedirectToAction("WeatherData", "Weatherdata", new { id = idlocation});
        }

    }
}