using APIpractise.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIpractise.Controllers
{
    public class StudentController : ApiController
    {
        UnivarsityEntities db = new UnivarsityEntities();
        [Route("api/create/Student")]
        [HttpPost]
        public HttpResponseMessage create(Student st)
        {
            Student obj = new Student();
            obj.name = st.name;
            obj.Sec = st.Sec;
            obj.deptid = st.deptid;
            db.Students.Add(obj);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, "Student Added");


        }
        [Route("api/edit/Student/{id}")]
        [HttpPost]
        public HttpResponseMessage edit(Student dp, int id)
        {
            var stu = db.Students.Where(l => l.id.Equals(id)).FirstOrDefault();
            stu.name = dp.name;
            stu.Sec = dp.Sec;
            stu.deptid = dp.deptid;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Student Edited");
        }
        [Route("api/delete/Student/{id}")]
        [HttpPost]
        public HttpResponseMessage delete(int id)
        {
            var stu = db.Students.Where(l => l.id.Equals(id)).FirstOrDefault();
            db.Students.Remove(stu);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Student deleted");
        }

        [Route("api/details/Student/{id}")]
        [HttpGet]
        public HttpResponseMessage details(int id)
        {
            var data = (from b in db.Students
                        where b.deptid.Equals(id)
                        select b);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
