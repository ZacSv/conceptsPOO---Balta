using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Objeto criado com o intuito de reduzir a utilização de Exceptions e em seu lugar apenas notificar as classes de modo que o programador decida oq fazer com o erro;
namespace conceitosPOO.NotificationContext
{
    public sealed class Notification //A classe será selada por motivos de padronização
    {

        public Notification() { }

        public Notification(string Property, string Message) { }


        public string Property { get; set; } //Propriedade que deu o erro
        public string Message { get; set; } //Mensagem de erro
    }
}
