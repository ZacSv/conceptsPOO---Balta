using conceitosPOO.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.ContentContext
{
    public class Content : Base
    {

        public Content(string tittle, string url)
        {
            Tittle = tittle;
            Url = url;
            
        }
        public string Tittle { get; set; }
        public string Url { get; set; }
    }
}
