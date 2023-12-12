using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.ContentContext
{
    public class Content
    {

        public Content(string tittle, string url)
        {
            Tittle = tittle;
            Url = url;
            Id = Guid.NewGuid(); //Definindo por padrão a inicialização de um novo ID sempre que a classe for instanciada
        }
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; }
    }
}
