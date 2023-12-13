using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.NotificationContext
    /* Classe que será base da herança para criação das notificações de erro para as classes */
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification) 
        {
            Notifications.Add(notification);
        }

        public void AddRangeNotification(IEnumerable<Notification> notification)
        {
          Notifications.AddRange(notification);
        }
    }
}
