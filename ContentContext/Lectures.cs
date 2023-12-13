using conceitosPOO.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Definição das propriedades e lógicas das aulas

namespace conceitosPOO.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string? Tittle { get; set; }
        public int DurationInMinutes { get; set; }
        
    }
}
    