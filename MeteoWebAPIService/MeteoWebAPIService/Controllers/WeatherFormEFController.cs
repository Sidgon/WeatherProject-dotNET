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
    public class WeatherFormEFController : ApiController
    {
        private MeteoWebAPIServiceContext db = new MeteoWebAPIServiceContext();

        // GET: api/WeatherFormEF
        public IQueryable<WeatherForm> GetWeatherForms()
        {
            return db.WeatherForms;
        }

        // GET: api/WeatherFormEF/5
        [ResponseType(typeof(WeatherForm))]
        public async Task<IHttpActionResult> GetWeatherForm(int id)
        {
            WeatherForm weatherForm = await db.WeatherForms.FindAsync(id);
            if (weatherForm == null)
            {
                return NotFound();
            }

            return Ok(weatherForm);
        }

        // PUT: api/WeatherFormEF/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutWeatherForm(int id, WeatherForm weatherForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weatherForm.Id)
            {
                return BadRequest();
            }

            db.Entry(weatherForm).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherFormExists(id))
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

        // POST: api/WeatherFormEF
        [ResponseType(typeof(WeatherForm))]
        public async Task<IHttpActionResult> PostWeatherForm(WeatherForm weatherForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WeatherForms.Add(weatherForm);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = weatherForm.Id }, weatherForm);
        }

        // DELETE: api/WeatherFormEF/5
        [ResponseType(typeof(WeatherForm))]
        public async Task<IHttpActionResult> DeleteWeatherForm(int id)
        {
            WeatherForm weatherForm = await db.WeatherForms.FindAsync(id);
            if (weatherForm == null)
            {
                return NotFound();
            }

            db.WeatherForms.Remove(weatherForm);
            await db.SaveChangesAsync();

            return Ok(weatherForm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeatherFormExists(int id)
        {
            return db.WeatherForms.Count(e => e.Id == id) > 0;
        }
    }
}