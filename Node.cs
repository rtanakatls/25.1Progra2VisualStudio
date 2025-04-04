using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal abstract class Node
    {
        protected string code;

        public string Code { get {  return code; } }

        public Node(string code)
        {
            this.code = code;
        }

        public abstract string GetDescription();
    }
}
