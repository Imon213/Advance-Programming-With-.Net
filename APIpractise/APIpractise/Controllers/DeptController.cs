using APIpractise.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIpractise.Controllers
{
    
    public class DeptController : ApiController
    {
        UnivarsityEntities db = new UnivarsityEntities();
        [HttpPost]
        public HttpResponseMessage create(Dept dp)
        {
            Dept obj = new Dept();
            obj.name = dp.name;
            db.Depts.Add(obj);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, "Department Added");


        }
        [Route("api/edit/Dept/{id}")]
        [HttpPost]
      public HttpResponseMessage edit(Dept dp, int id)
        {
            var stu = db.Depts.Where(l => l.id.Equals(id)).FirstOrDefault();
            stu.name = dp.name;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Department Edited");
        }
        [Route("api/delete/Dept/{id}")]
        [HttpPost]
        public HttpResponseMessage delete(int id)
        {
            var stu = db.Depts.Where(l => l.id.Equals(id)).FirstOrDefault();
            db.Depts.Remove(stu);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Department deleted");
        }

        [Route("api/details/Dept/{id}")]
        [HttpGet]
        public HttpResponseMessage details(int id)
        {
            var stu = db.Depts.Where(l => l.id.Equals(id)).FirstOrDefault();

            return Request.CreateResponse(HttpStatusCode.OK, stu);
        }

    }
}
