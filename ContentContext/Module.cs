using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static conceitosPOO.ContentContext.Course;

//Definição das propriedades e lógicas de cada módulo dentro dos cursos

namespace conceitosPOO.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Tittle { get; set; }
        IList<Lecture> Lectures { get; set; }
    }
}
