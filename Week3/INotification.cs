using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal interface INotification<T>
    {
        void Show(T message);
    }
}
