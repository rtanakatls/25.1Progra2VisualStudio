using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class PlayerNoPositiveLevelException : Exception
    {
        public PlayerNoPositiveLevelException(int level) : base($"El jugador debe tener nivel positivo por ahora tiene {level}")
        {

        }
    }
}
