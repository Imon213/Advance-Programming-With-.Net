using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminRepo
{
    public class AdminCategoryRepo : IRepository<category, int>
    {

        NewsPortalEntities db;
        public AdminCategoryRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Add(category obj)
        {

            db.categories.Add(obj);
            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {

            var ns = db.categories.FirstOrDefault(x => x.cid == id);
            db.categories.Remove(ns);
            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(category obj)
        {
            var ns = db.categories.FirstOrDefault(x => x.cid == obj.cid);
            ns.cname = obj.cname;
            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public category Get(int id)
        {
            return db.categories.FirstOrDefault(a => a.cid == id);
        }

        public List<category> Get()
        {
            return db.categories.ToList();
        }
    }
}
