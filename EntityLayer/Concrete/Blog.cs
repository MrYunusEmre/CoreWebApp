using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogThumbnailImage { get; set; }
        public int BlogImage { get; set; }
        public string MyProperty { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}
