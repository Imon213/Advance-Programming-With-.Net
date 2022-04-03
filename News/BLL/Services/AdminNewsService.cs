using AutoMapper;
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
    public class AdminNewsService
    {
        public static newsModel Get(int id)
        {
            var ns = DataAccessFactory.AdminDataAccess().Get(id);
            newsModel nm = new newsModel() { 
                news1 = ns.news1,
                cid = ns.cid,
                uid = ns.uid,
                time = ns.time
            };
            return nm;
        }
        public static List <newsModel> Get()
        {
            var ns = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<news, newsModel>();
                c.CreateMap<category, categoryModel>();
                c.CreateMap<nuser, nuserModel>();
             
            }); 
            var mapper = new Mapper(config);
            var data = mapper.Map<List<newsModel>>(ns);
            
            return data;
            
        }
        public static void Add(newsModel nm)
        {
            news n = new news() {
                news1 = nm.news1,
                cid = nm.cid,
                uid = nm.uid,
                time = DateTime.Now
            };
            DataAccessFactory.AdminDataAccess().Add(n);

        }
        public static void Delete(int id)
        {
            DataAccessFactory.AdminDataAccess().Delete(id);
        }
        public static void Edit (newsModel nm, int id)
        {
            news n = new news()
            {
                news1 = nm.news1,
                cid = nm.cid,
                nid = id

            };
            DataAccessFactory.AdminDataAccess().Edit(n);
        }
        public static List<newsModel> GetNewsByCategory(int id)
        {
            var ns = DataAccessFactory.AdminDataAccess().Get().Where(x => x.cid == id).ToList();
            /*  List<newsModel> nm = new List<newsModel>();
           foreach (var s in ns)
           {

               nm.Add(new newsModel()
               {
                   nid = s.nid,
                   news1 = s.news1,
                   cid = s.cid,
                   uid = s.uid,
                   time = s.time,

               }); ;

           }
           return nm; */


            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<news, newsModel>();
                c.CreateMap<category, categoryModel>();
                c.CreateMap<nuser, nuserModel>();
             
            }); ;
            var mapper = new Mapper(config);
            var data = mapper.Map<List<newsModel>>(ns);

            return data;
        }


        public static List<newsModel> GetNewsByDateTime(string i)
        {
            var ns = DataAccessFactory.AdminDataAccess().Get().Where(x => x.time.ToString().Contains(i)).ToList();
          /*  List<newsModel> nm = new List<newsModel>();
            foreach (var s in ns)
            {

                nm.Add(new newsModel()
                {
                    nid = s.nid,
                    news1 = s.news1,
                    cid = s.cid,
                    uid = s.uid,
                    time = s.time,

                }); ;

            }
            return nm; */
          var config = new MapperConfiguration(c =>
            {
                c.CreateMap<news, newsModel>();
                c.CreateMap<category, categoryModel>();
                c.CreateMap<nuser, nuserModel>();
               
            }); ;
            var mapper = new Mapper(config);
            var data = mapper.Map<List<newsModel>>(ns);
            
            return data;
        }
        public static List<string> GetNews()
        {
            return DataAccessFactory.AdminDataAccess().Get().Select(x => (x.nid,x.news1, x.time).ToString()).ToList();
              
        }
    }
}
