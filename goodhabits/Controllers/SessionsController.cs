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
using goodhabits.Models;

namespace goodhabits.Controllers
{
    public class SessionsController : ApiController
    {
        private goodhabitsContext db = new goodhabitsContext();

        // GET: api/Sessions
        public IQueryable<Session> GetSessions()
        {
            return db.Sessions;
        }

        // GET: api/Sessions/5
        [ResponseType(typeof(Session))]
        public async Task<IHttpActionResult> GetSession(string id)
        {
            Session session = await db.Sessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }

            return Ok(session);
        }

        // PUT: api/Sessions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSession(string id, Session session)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != session.SessionId)
            {
                return BadRequest();
            }

            db.Entry(session).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessionExists(id))
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

        // POST: api/Sessions
        [ResponseType(typeof(Session))]
        public async Task<IHttpActionResult> PostSession(Session session)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sessions.Add(session);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SessionExists(session.SessionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = session.SessionId }, session);
        }

        // DELETE: api/Sessions/5
        [ResponseType(typeof(Session))]
        public async Task<IHttpActionResult> DeleteSession(string id)
        {
            Session session = await db.Sessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }

            db.Sessions.Remove(session);
            await db.SaveChangesAsync();

            return Ok(session);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SessionExists(string id)
        {
            return db.Sessions.Count(e => e.SessionId == id) > 0;
        }
    }
}