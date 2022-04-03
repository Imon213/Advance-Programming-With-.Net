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
    public class UserCommentService
    {
        public static void Add(ucommentModel obj)
        {
            ucomment model = new ucomment() { 
                uid = obj.uid,
                nid = obj.nid,
                comment = obj.comment
            };
             DataAccessFactory.UserCommentAccess().Add(model);
        }
        public static List<ucommentModel> Get()
        {
            var comment = DataAccessFactory.UserCommentAccess().Get();
            var config = new MapperConfiguration(x =>
            {
               
                x.CreateMap<news, newsModel>();
                x.CreateMap<ucomment, ucommentModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ucommentModel>>(comment);
            return data;

        }

    }
}
