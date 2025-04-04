using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class PlayerNoNameException : Exception
    {
        public PlayerNoNameException(string  message) : base(message) { }
    }
}
