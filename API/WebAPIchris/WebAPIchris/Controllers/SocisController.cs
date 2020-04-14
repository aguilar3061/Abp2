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
using WebAPIchris;

namespace WebAPIchris.Controllers
{
    public class SocisController : ApiController
    {
        private chrysallis_grupo3Entities1 db = new chrysallis_grupo3Entities1();

        // GET: api/Socis
        public IQueryable<Soci> GetSocis()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;

            return db.Socis;
        }

        // GET: api/Socis/5
        [ResponseType(typeof(Soci))]
        public IHttpActionResult GetSoci(int id)
        {
            //Soci soci = db.Socis.Find(id);
            //if (soci == null)
            //{
            //    return NotFound();
            //}

            //return Ok(soci);

            IHttpActionResult resultado;

            db.Configuration.LazyLoadingEnabled = false;

            Soci _soci = (from t in db.Socis
                           where t.id == id
                           select t).FirstOrDefault();


            if (_soci == null)
            {

                resultado = NotFound();

            }
            else
            {

                resultado = Ok(_soci);
            }

            return resultado;

        }

        // PUT: api/Socis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSoci(int id, Soci soci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != soci.id)
            {
                return BadRequest();
            }

            db.Entry(soci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SociExists(id))
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
        [ResponseType(typeof(Soci))]
        public IHttpActionResult PostSoci(Soci soci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Socis.Add(soci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = soci.id }, soci);
        }

        // DELETE: api/Socis/5
        [ResponseType(typeof(Soci))]
        public IHttpActionResult DeleteSoci(int id)
        {
            Soci soci = db.Socis.Find(id);
            if (soci == null)
            {
                return NotFound();
            }

            db.Socis.Remove(soci);
            db.SaveChanges();

            return Ok(soci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SociExists(int id)
        {
            return db.Socis.Count(e => e.id == id) > 0;
        }
    }
}