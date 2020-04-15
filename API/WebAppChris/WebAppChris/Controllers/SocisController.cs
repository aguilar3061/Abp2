using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAppChris;

namespace WebAppChris.Controllers
{
    public class SocisController : ApiController
    {
        private chrysallis_grupo3Entities db = new chrysallis_grupo3Entities();

        // GET: api/Socis
        public IQueryable<Socis> GetSocis()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;
            return db.Socis;
        }

        // GET: api/Socis/5
        [ResponseType(typeof(Socis))]
        public IHttpActionResult GetSocis(int id)
        {
            Socis socis = db.Socis.Find(id);
            if (socis == null)
            {
                return NotFound();
            }

            return Ok(socis);
        }

        // PUT: api/Socis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSocis(int id, Socis socis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != socis.id)
            {
                return BadRequest();
            }

            db.Entry(socis).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SocisExists(id))
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

        // POST: api/Socis
        [ResponseType(typeof(Socis))]
        public IHttpActionResult PostSocis(Socis socis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Socis.Add(socis);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = socis.id }, socis);
        }

        // DELETE: api/Socis/5
        [ResponseType(typeof(Socis))]
        public IHttpActionResult DeleteSocis(int id)
        {
            Socis socis = db.Socis.Find(id);
            if (socis == null)
            {
                return NotFound();
            }

            db.Socis.Remove(socis);
            db.SaveChanges();

            return Ok(socis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SocisExists(int id)
        {
            return db.Socis.Count(e => e.id == id) > 0;
        }
    }
}