﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu menu=new Menu();
            menu.Execute();
        }
    }
}
