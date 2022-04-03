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
    public class AdminController : ApiController
    {
        [Route("api/Admin/Get")]
        public List<newsModel> Get()
        {
            return AdminNewsService.Get();
        }

        [Route("api/Admin/Get/{id}")]
        public newsModel Get(int id)
        {
            return AdminNewsService.Get(id);
        }
        [HttpPost]
        [Route("api/Admin/Add")]
        public void Add(newsModel nm)
        {
            AdminNewsService.Add(nm);
        }
        [HttpPost]
        [Route("api/Admin/Edit/{id}")]
        public void Edit(newsModel nm, int id)
        {
            AdminNewsService.Edit(nm,id);
        }

        
        [Route("api/Admin/Delete/{id}")]
        public void Delete(int id)
        {
            AdminNewsService.Delete(id);
        }

        //Category Part Started

        [Route("api/Admin/GetCategory")]
        public List<categoryModel> GetCategory()
        {
            return AdminCategoryService.Get();
        }

        [Route("api/Admin/GetCategory/{id}")]
        public categoryModel GetCategory(int id)
        {
            return AdminCategoryService.Get(id);
        }

        [HttpPost]
        [Route("api/Admin/AddCategory")]
        public void AddAdd(categoryModel nm)
        {
            AdminCategoryService.Add(nm);
        }
        [HttpPost]
        [Route("api/Admin/EditCategory/{id}")]
        public void EditCategory(categoryModel nm, int id)
        {
            AdminCategoryService.Edit(nm,id);
        }

        [HttpPost]
        [Route("api/Admin/DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            AdminCategoryService.Delete(id);
        }

        [Route("api/Admin/GetNewsByCategory/{id}")]
        public List<newsModel> GetNewsByCategory(int id)
        {
          return  AdminNewsService.GetNewsByCategory(id);
        }
        [HttpPost]
        [Route("api/Admin/GetNewsByDateTime")]
        public List<newsModel> GetNewsByDateTime(newsModel t)
        {
           string ti= t.time.ToString();
            return AdminNewsService.GetNewsByDateTime(ti);
        }
        [Route("api/Admin/GetComment")]
        public List<ucommentModel> GetComment()
        {
            return UserCommentService.Get();
        }


    }
}
