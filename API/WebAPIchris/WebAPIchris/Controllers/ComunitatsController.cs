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
    public class ComunitatsController : ApiController
    {
        private chrysallis_grupo3Entities1 db = new chrysallis_grupo3Entities1();

        // GET: api/Comunitats
        public IQueryable<Comunitat> GetComunitats()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;

            return db.Comunitats;
        }

        // GET: api/Comunitats/5
        [ResponseType(typeof(Comunitat))]
        public IHttpActionResult GetComunitat(int id)
        {
            //Comunitat comunitat = db.Comunitats.Find(id);
            //if (comunitat == null)
            //{
            //    return NotFound();
            //}

            //return Ok(comunitat);


            IHttpActionResult resultado;

            db.Configuration.LazyLoadingEnabled = false;

            Comunitat _Comu = (from t in db.Comunitats
                           where t.id == id
                           select t).FirstOrDefault();


            if (_Comu == null)
            {

                resultado = NotFound();

            }
            else
            {

                resultado = Ok(_Comu);
            }


            return resultado;

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

            db.Comunitats.Add(comunitat);

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
            Comunitat comunitat = db.Comunitats.Find(id);
            if (comunitat == null)
            {
                return NotFound();
            }

            db.Comunitats.Remove(comunitat);
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
            return db.Comunitats.Count(e => e.id == id) > 0;
        }
    }
}