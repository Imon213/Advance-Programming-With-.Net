using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminRepo
{
    public class UserCommentRepo : IRepository<ucomment, int>
    {
        NewsPortalEntities db;
        public UserCommentRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Add(ucomment obj)
        {
            db.ucomments.Add(obj);
            if(db.SaveChanges()!=0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ucomment obj)
        {
            throw new NotImplementedException();
        }

        public ucomment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ucomment> Get()
        {
            return db.ucomments.ToList();
        }
    }
}