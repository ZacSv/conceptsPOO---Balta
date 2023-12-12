using conceitosPOO.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Definição das propriedades e lógicas dos cursos

namespace conceitosPOO.ContentContext
{
    public class Course : Content
    {
        public Course(string tittle, string url) 
            : base(tittle, url ) //Trazendo os parâmetros passados na instância do construtor base 
        {
            Modules = new List<Module>();
        }
        public string TagCourse { get; set; }
        public double DurationInHours { get; set; }
        public EContentLevel Level { get; set; }
        public IList<Module> Modules{ get; set; }
        


    }
}
