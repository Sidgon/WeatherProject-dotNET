using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MeteoWebAPIService.Models;

namespace MeteoWebAPIService.Controllers
{
    public class WeatherDataEFController : ApiController
    {
        private MeteoWebAPIServiceContext db = new MeteoWebAPIServiceContext();

        // GET: api/WeatherDataEF
        public IQueryable<WeatherData> GetWeatherDatas()
        {
            return db.WeatherDatas;
        }

        // GET: api/WeatherDataEF/5
        [ResponseType(typeof(WeatherData))]
        public async Task<IHttpActionResult> GetWeatherData(int id)
        {
            WeatherData weatherData = await db.WeatherDatas.FindAsync(id);
            if (weatherData == null)
            {
                return NotFound();
            }

            return Ok(weatherData);
        }

        // PUT: api/WeatherDataEF/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutWeatherData(int id, WeatherData weatherData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weatherData.Id)
            {
                return BadRequest();
            }

            db.Entry(weatherData).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/WeatherDataEF
        [ResponseType(typeof(WeatherData))]
        public async Task<IHttpActionResult> PostWeatherData(WeatherData weatherData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WeatherDatas.Add(weatherData);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = weatherData.Id }, weatherData);
        }

        // DELETE: api/WeatherDataEF/5
        [ResponseType(typeof(WeatherData))]
        public async Task<IHttpActionResult> DeleteWeatherData(int id)
        {
            WeatherData weatherData = await db.WeatherDatas.FindAsync(id);
            if (weatherData == null)
            {
                return NotFound();
            }

            db.WeatherDatas.Remove(weatherData);
            await db.SaveChangesAsync();

            return Ok(weatherData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeatherDataExists(int id)
        {
            return db.WeatherDatas.Count(e => e.Id == id) > 0;
        }
    }
}