using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Definindo regras para os itens (Cursos) de cada carreira, lembrando que uma carreira contém vários cursos e um curso pode estar em várias carreiras
namespace conceitosPOO.ContentContext
{
    public class CareerItem
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int Ordem { get; set; }
        public Course Course { get; set; }
    }
}
