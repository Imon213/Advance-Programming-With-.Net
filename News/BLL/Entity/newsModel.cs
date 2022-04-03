using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class newsModel
    {
        public int nid { get; set; }
        public string news1 { get; set; }
        public Nullable<int> cid { get; set; }
        public Nullable<int> uid { get; set; }
        public Nullable<System.DateTime> time { get; set; }

        public virtual categoryModel category { get; set; }
        public virtual nuserModel nuser { get; set; }
        
    }
}
