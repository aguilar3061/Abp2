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
    public class NotificacionsController : ApiController
    {
        private chrysallis_grupo3Entities db = new chrysallis_grupo3Entities();

        // GET: api/Notificacions
        public IQueryable<Notificacions> GetNotificacions()
        {
            //solo cargargar las cosas cuando se utilizan
            db.Configuration.LazyLoadingEnabled = false;
            return db.Notificacions;
        }

        // GET: api/Notificacions/5
        [ResponseType(typeof(Notificacions))]
        public IHttpActionResult GetNotificacions(int id)
        {
            Notificacions notificacions = db.Notificacions.Find(id);
            if (notificacions == null)
            {
                return NotFound();
            }

            return Ok(notificacions);
        }

        // PUT: api/Notificacions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotificacions(int id, Notificacions notificacions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notificacions.id)
            {
                return BadRequest();
            }

            db.Entry(notificacions).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotificacionsExists(id))
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

        // POST: api/Notificacions
        [ResponseType(typeof(Notificacions))]
        public IHttpActionResult PostNotificacions(Notificacions notificacions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notificacions.Add(notificacions);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (NotificacionsExists(notificacions.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = notificacions.id }, notificacions);
        }

        // DELETE: api/Notificacions/5
        [ResponseType(typeof(Notificacions))]
        public IHttpActionResult DeleteNotificacions(int id)
        {
            Notificacions notificacions = db.Notificacions.Find(id);
            if (notificacions == null)
            {
                return NotFound();
            }

            db.Notificacions.Remove(notificacions);
            db.SaveChanges();

            return Ok(notificacions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotificacionsExists(int id)
        {
            return db.Notificacions.Count(e => e.id == id) > 0;
        }
    }
}