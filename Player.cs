using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class Player : Character
    {
        protected int experience;
        protected int level;

        public int Experience { get { return experience; } }
        public int Level { get { return level; } }


        public Player(string name) : base(name)
        {
            experience = 0;
            level = 1;
        }

        public void GainExperience(int experience)
        {
            this.experience += experience;
            while (this.experience >= level * 10)
            {
                this.experience -= level * 10;
                level++;
            }
        }

        public string GetPlayerData()
        {
            return $"El jugador con nombre {name} está en nivel {level} y tiene {experience} experiencia";
        }



    }
}
