using BLL.Entity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminCategoryService
    {
        public static categoryModel Get(int id)
        {
            var ns = DataAccessFactory.AdminCategoryAccess().Get(id);
            categoryModel nm = new categoryModel()
            {
               cid = ns.cid,
               cname = ns.cname

            };
            return nm;
        }
        public static List<categoryModel> Get()
        {
            var ns = DataAccessFactory.AdminCategoryAccess().Get();
            List<categoryModel> nm = new List<categoryModel>();
            foreach (var s in ns)
            {
                nm.Add(new categoryModel()
                {
                    cid = s.cid,
                    cname = s.cname
                });
            }
            return nm;
        }
        public static void Add(categoryModel nm)
        {
            category n = new category()
            {
                cname = nm.cname,
               
            };
            DataAccessFactory.AdminCategoryAccess().Add(n);

        }
        public static void Delete(int id)
        {
            DataAccessFactory.AdminCategoryAccess().Delete(id);
        }
        public static void Edit(categoryModel nm, int id)
        {
            category n = new category()
            {
               cname = nm.cname,
               cid = id
               

            };
            DataAccessFactory.AdminCategoryAccess().Edit(n);
        }
    }
}
