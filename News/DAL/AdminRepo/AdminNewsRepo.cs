using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminRepo
{
    public class AdminNewsRepo : IRepository<news, int>
    {
        NewsPortalEntities db;
        public  AdminNewsRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Add(news obj)
        {
            db.news.Add(obj);
            if(db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var ns = db.news.FirstOrDefault(x => x.nid == id);
            db.news.Remove(ns);
            if(db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public  bool Edit(news obj)
        {
            var ns = db.news.FirstOrDefault(x => x.nid == obj.nid);
            ns.news1 = obj.news1;
            ns.cid = obj.cid;
           if (db.SaveChanges()!= 0)
                {
                return true;
            }
            return false;
        }

        public news Get(int id)
        {
            return db.news.FirstOrDefault(a => a.nid == id);
        }


        public List<news> Get()
        {
            return db.news.ToList();
        }
    }
}
