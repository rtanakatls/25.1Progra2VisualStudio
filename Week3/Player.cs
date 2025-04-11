using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class Player
    {
        private string name;
        private int life;
        private int damage;

        public string Name { get { return name; } }
        public int Life { get { return life; } } 
        public int Damage { get { return damage; } }

        public Player(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }
    }
}
