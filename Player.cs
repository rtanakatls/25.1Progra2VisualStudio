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


        public Player(string name, int level) : base(name)
        {
            if (level <= 0)
            {
                throw new PlayerNoPositiveLevelException(level);
            }
            experience = 0;
            this.level = level;
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

        public override string GetData()
        {
            return $"El jugador con nombre {name} está en nivel {level} y tiene {experience} experiencia";
        }



    }
}
