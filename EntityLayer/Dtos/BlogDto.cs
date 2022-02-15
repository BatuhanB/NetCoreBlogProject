using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
    public class BlogDto
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public int WriterID { get; set; }
        public string WriterName { get; set; }
    }
}
