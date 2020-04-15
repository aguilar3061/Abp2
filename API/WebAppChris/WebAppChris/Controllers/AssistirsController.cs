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
    public class AssistirsController : ApiController
    {
        private chrysallis_grupo3Entities db = new chrysallis_grupo3Entities();

        // GET: api/Assistirs
        public IQueryable<Assistir> GetAssistir()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;
            return db.Assistir;
        }

        // GET: api/Assistirs/5
        [ResponseType(typeof(Assistir))]
        public IHttpActionResult GetAssistir(int id)
        {
            Assistir assistir = db.Assistir.Find(id);
            if (assistir == null)
            {
                return NotFound();
            }

            return Ok(assistir);
        }

        // PUT: api/Assistirs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAssistir(int id, Assistir assistir)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assistir.id_Soci)
            {
                return BadRequest();
            }

            db.Entry(assistir).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssistirExists(id))
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

        // POST: api/Assistirs
        [ResponseType(typeof(Assistir))]
        public IHttpActionResult PostAssistir(Assistir assistir)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Assistir.Add(assistir);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AssistirExists(assistir.id_Soci))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = assistir.id_Soci }, assistir);
        }

        // DELETE: api/Assistirs/5
        [ResponseType(typeof(Assistir))]
        public IHttpActionResult DeleteAssistir(int id)
        {
            Assistir assistir = db.Assistir.Find(id);
            if (assistir == null)
            {
                return NotFound();
            }

            db.Assistir.Remove(assistir);
            db.SaveChanges();

            return Ok(assistir);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssistirExists(int id)
        {
            return db.Assistir.Count(e => e.id_Soci == id) > 0;
        }
    }
}