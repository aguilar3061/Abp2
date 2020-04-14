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
    public class EsdevenimentsController : ApiController
    {
        private chrysallis_grupo3Entities1 db = new chrysallis_grupo3Entities1();

        // GET: api/Esdeveniments
        public IQueryable<Esdeveniment> GetEsdeveniments()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;

            return db.Esdeveniments;
        }

        // GET: api/Esdeveniments/5
        [ResponseType(typeof(Esdeveniment))]
        public IHttpActionResult GetEsdeveniment(int id)
        {
            //Esdeveniment esdeveniment = db.Esdeveniments.Find(id);
            //if (esdeveniment == null)
            //{
            //    return NotFound();
            //}

            //return Ok(esdeveniment);

            IHttpActionResult resultado;

            db.Configuration.LazyLoadingEnabled = false;

            Esdeveniment _Esdeve = (from t in db.Esdeveniments
                           where t.id == id
                           select t).FirstOrDefault();


            if (_Esdeve == null)
            {

                resultado = NotFound();

            }
            else
            {

                resultado = Ok(_Esdeve);
            }


            return resultado;









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

            db.Esdeveniments.Add(esdeveniment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = esdeveniment.id }, esdeveniment);
        }

        // DELETE: api/Esdeveniments/5
        [ResponseType(typeof(Esdeveniment))]
        public IHttpActionResult DeleteEsdeveniment(int id)
        {
            Esdeveniment esdeveniment = db.Esdeveniments.Find(id);
            if (esdeveniment == null)
            {
                return NotFound();
            }

            db.Esdeveniments.Remove(esdeveniment);
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
            return db.Esdeveniments.Count(e => e.id == id) > 0;
        }
    }
}