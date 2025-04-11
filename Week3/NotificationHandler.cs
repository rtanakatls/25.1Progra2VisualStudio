using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class NotificationHandler
    {
        public void Show<T>(INotification<T> notification, T message)
        {
            notification.Show(message);
        }
    }
}
