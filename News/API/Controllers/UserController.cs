using BLL.Entity;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("api/User/Add")]
        public void Add(ucommentModel obj)
        {
            UserCommentService.Add(obj);

        }

        [Route("api/User/GetNews")]
        public List<String> GetNews()
        {
            return AdminNewsService.GetNews();

        }
    }
}
