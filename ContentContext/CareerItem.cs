using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Definindo regras para os itens (Cursos) de cada carreira, lembrando que uma carreira contém vários cursos e um curso pode estar em várias carreiras
namespace conceitosPOO.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(string tittle, string description, int order, Course course)
        {
            Tittle = tittle;
            Description = description;
            Order = order;
            Course = course;
        }

        /* Toda a carreira para ser concluída deve ser seguida por uma ordem sequencial de cursos,
         * para saber essa ordem utilizarei a propriedade "Order" para ordenar qual curso vem primeiro e qual vem depois*/
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
    }
}
