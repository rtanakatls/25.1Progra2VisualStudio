﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class DecisionNode : Node
    {

        public DecisionNode() : base("D")
        {

        }
        public override string GetDescription()
        {
            return "Este es un nodo de decisión";
        }

    }
}
