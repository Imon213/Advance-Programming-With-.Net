using NewsPortal.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()

        {
            // List<NewsInfo> news = new List<NewsInfo>();

            /* using (NewsEntities db = new NewsEntities())
              {
                  // news = db.NewsInfos.ToList<NewsInfo>();


              } */
            NewsEntities db = new NewsEntities();
            var news = db.NewsInfos.ToList();
          
            return View(news);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View(new NewsInfo());
        }
        [HttpPost]
        public ActionResult create(NewsInfo s)
        {
            if (ModelState.IsValid)
            {
                s.DateOfPublished = DateTime.Now;

                using(NewsEntities db = new NewsEntities())
                {
                    db.NewsInfos.Add(s);
                    db.SaveChanges();
                }
               
               

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult edit(int id)
        {
            NewsInfo news = new NewsInfo();
            using (NewsEntities db = new NewsEntities())
            {
                //news= db.NewsInfos.Where(x => x.ID == id).FirstOrDefault();
                news = (from b in db.NewsInfos
                        where b.ID == id
                        select b).FirstOrDefault();
            }
            return View(news);
        }
        [HttpPost]
        public ActionResult edit(NewsInfo s)
        {
            using (NewsEntities db = new NewsEntities())
            {
                db.Entry(s).State =System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult delete( int id)
        {
            NewsInfo news = new NewsInfo();
            using (NewsEntities db = new NewsEntities())
            {
                news = (from b in db.NewsInfos
                       where b.ID == id
                       select b).FirstOrDefault();
            }
            return View(news);
        }
        [HttpPost]
        public ActionResult delete(NewsInfo s,int id)
        {
            using (NewsEntities db = new NewsEntities())
            {
                s = db.NewsInfos.Where(x => x.ID == id).FirstOrDefault();
                db.NewsInfos.Remove(s);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

    }
}