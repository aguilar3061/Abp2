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
    public class ComunitatsController : ApiController
    {
        private chrysallis_grupo3Entities db = new chrysallis_grupo3Entities();

        // GET: api/Comunitats
        public IQueryable<Comunitat> GetComunitat()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;
            return db.Comunitat;
        }

        // GET: api/Comunitats/5
        [ResponseType(typeof(Comunitat))]
        public IHttpActionResult GetComunitat(int id)
        {
            Comunitat comunitat = db.Comunitat.Find(id);
            if (comunitat == null)
            {
                return NotFound();
            }

            return Ok(comunitat);
        }

        // PUT: api/Comunitats/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComunitat(int id, Comunitat comunitat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comunitat.id)
            {
                return BadRequest();
            }

            db.Entry(comunitat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComunitatExists(id))
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

        // POST: api/Comunitats
        [ResponseType(typeof(Comunitat))]
        public IHttpActionResult PostComunitat(Comunitat comunitat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Comunitat.Add(comunitat);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ComunitatExists(comunitat.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = comunitat.id }, comunitat);
        }

        // DELETE: api/Comunitats/5
        [ResponseType(typeof(Comunitat))]
        public IHttpActionResult DeleteComunitat(int id)
        {
            Comunitat comunitat = db.Comunitat.Find(id);
            if (comunitat == null)
            {
                return NotFound();
            }

            db.Comunitat.Remove(comunitat);
            db.SaveChanges();

            return Ok(comunitat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComunitatExists(int id)
        {
            return db.Comunitat.Count(e => e.id == id) > 0;
        }
    }
}