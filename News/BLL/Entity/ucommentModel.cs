using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class ucommentModel
    {
        public int coid { get; set; }
        public Nullable<int> uid { get; set; }
        public string comment { get; set; }
        public Nullable<int> nid { get; set; }

        public virtual newsModel news1 { get; set; }
    }
}
