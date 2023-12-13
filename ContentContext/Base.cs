using conceitosPOO.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Enteidade base utilizada para heranças*/

namespace conceitosPOO.ContentContext
{
    public class Base : Notifiable
    {
        public Guid Id { get; set; }
        public Base() 
        {
            Id = Guid.NewGuid(); //Definindo por padrão a inicialização de um novo ID sempre que a classe for instanciada
        }
    }
}
