using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class CombatNode : Node
    {
        public CombatNode() : base("X")
        {

        }
        public override string GetDescription()
        {
            return "Este es un nodo de combate";
        }
    }
}
