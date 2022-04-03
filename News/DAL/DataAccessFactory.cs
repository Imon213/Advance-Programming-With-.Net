using DAL.AdminRepo;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static NewsPortalEntities db = new NewsPortalEntities();

        public static IRepository<news, int> AdminDataAccess()
        {
            return new AdminNewsRepo(db);
        }
        public static IRepository<category,int> AdminCategoryAccess()
        {
            return new AdminCategoryRepo(db);
        }
        public static IRepository<ucomment,int> UserCommentAccess()
        {
            return new UserCommentRepo(db);
        }
    }
}
