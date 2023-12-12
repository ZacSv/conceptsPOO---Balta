using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.ContentContext
{
    public class Article : Content
    {

        public Article(string tittle, string url)
            :base(tittle, url) //Pegando os dados necessário direto do construtor base, no caso o "Content"
        {
            
        }
         
    }
}
