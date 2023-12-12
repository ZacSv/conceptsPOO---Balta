using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.ContentContext
{
    public class Career : Content
    {
        public Career(string tittle, string url)
            :base(tittle, url)
        {
            Items = new List<CareerItem>();    
        }
        public IList<CareerItem> Items { get; set; }
        public int CoursesCount => Items.Count; //Expression body
 
    }

}
