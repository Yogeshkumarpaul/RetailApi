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
using MiddleLayer.Models;

namespace MiddleLayer.Controllers
{
    public class TypeDetailsController : ApiController
    {
        private RetailEntities db = new RetailEntities();

        // GET: api/TypeDetails
        public IQueryable<TypeDetail> GetTypeDetails()
        {
            return db.TypeDetails;
        }

        // GET: api/TypeDetails/5
        [ResponseType(typeof(TypeDetail))]
        public IHttpActionResult GetTypeDetail(int id)
        {
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            if (typeDetail == null)
            {
                return NotFound();
            }

            return Ok(typeDetail);
        }

        // PUT: api/TypeDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTypeDetail(int id, TypeDetail typeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeDetail.TypeId)
            {
                return BadRequest();
            }

            db.Entry(typeDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeDetailExists(id))
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

        // POST: api/TypeDetails
        [ResponseType(typeof(TypeDetail))]
        public IHttpActionResult PostTypeDetail(TypeDetail typeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TypeDetails.Add(typeDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = typeDetail.TypeId }, typeDetail);
        }

        // DELETE: api/TypeDetails/5
        [ResponseType(typeof(TypeDetail))]
        public IHttpActionResult DeleteTypeDetail(int id)
        {
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            if (typeDetail == null)
            {
                return NotFound();
            }

            db.TypeDetails.Remove(typeDetail);
            db.SaveChanges();

            return Ok(typeDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeDetailExists(int id)
        {
            return db.TypeDetails.Count(e => e.TypeId == id) > 0;
        }
    }
}