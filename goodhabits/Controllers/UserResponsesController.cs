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
    public class UserResponsesController : ApiController
    {
        private goodhabitsContext db = new goodhabitsContext();

        // GET: api/UserResponses
        public IQueryable<UserResponse> GetUserResponses()
        {
            return db.UserResponses;
        }

        // GET: api/UserResponses/5
        [ResponseType(typeof(UserResponse))]
        public async Task<IHttpActionResult> GetUserResponse(int id)
        {
            UserResponse userResponse = await db.UserResponses.FindAsync(id);
            if (userResponse == null)
            {
                return NotFound();
            }

            return Ok(userResponse);
        }

        // PUT: api/UserResponses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserResponse(int id, UserResponse userResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userResponse.UserResponseId)
            {
                return BadRequest();
            }

            db.Entry(userResponse).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserResponseExists(id))
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

        // POST: api/UserResponses
        [ResponseType(typeof(UserResponse))]
        public async Task<IHttpActionResult> PostUserResponse(UserResponse userResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserResponses.Add(userResponse);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = userResponse.UserResponseId }, userResponse);
        }

        // DELETE: api/UserResponses/5
        [ResponseType(typeof(UserResponse))]
        public async Task<IHttpActionResult> DeleteUserResponse(int id)
        {
            UserResponse userResponse = await db.UserResponses.FindAsync(id);
            if (userResponse == null)
            {
                return NotFound();
            }

            db.UserResponses.Remove(userResponse);
            await db.SaveChangesAsync();

            return Ok(userResponse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserResponseExists(int id)
        {
            return db.UserResponses.Count(e => e.UserResponseId == id) > 0;
        }
    }
}