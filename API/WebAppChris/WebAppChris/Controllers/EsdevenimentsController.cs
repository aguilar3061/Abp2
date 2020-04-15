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
    public class EsdevenimentsController : ApiController
    {
        private chrysallis_grupo3Entities db = new chrysallis_grupo3Entities();

        // GET: api/Esdeveniments
        public IQueryable<Esdeveniment> GetEsdeveniment()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;
            return db.Esdeveniment;
        }

        // GET: api/Esdeveniments/5
        [ResponseType(typeof(Esdeveniment))]
        public IHttpActionResult GetEsdeveniment(int id)
        {
            Esdeveniment esdeveniment = db.Esdeveniment.Find(id);
            if (esdeveniment == null)
            {
                return NotFound();
            }

            return Ok(esdeveniment);
        }

        // PUT: api/Esdeveniments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEsdeveniment(int id, Esdeveniment esdeveniment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != esdeveniment.id)
            {
                return BadRequest();
            }

            db.Entry(esdeveniment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsdevenimentExists(id))
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

        // POST: api/Esdeveniments
        [ResponseType(typeof(Esdeveniment))]
        public IHttpActionResult PostEsdeveniment(Esdeveniment esdeveniment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Esdeveniment.Add(esdeveniment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = esdeveniment.id }, esdeveniment);
        }

        // DELETE: api/Esdeveniments/5
        [ResponseType(typeof(Esdeveniment))]
        public IHttpActionResult DeleteEsdeveniment(int id)
        {
            Esdeveniment esdeveniment = db.Esdeveniment.Find(id);
            if (esdeveniment == null)
            {
                return NotFound();
            }

            db.Esdeveniment.Remove(esdeveniment);
            db.SaveChanges();

            return Ok(esdeveniment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EsdevenimentExists(int id)
        {
            return db.Esdeveniment.Count(e => e.id == id) > 0;
        }
    }
}