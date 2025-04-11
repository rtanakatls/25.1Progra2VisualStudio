using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class PlayerNotification : INotification<Player>
    {
        public void Show(Player player)
        {
            Console.WriteLine($"Nombre: {player.Name} - Vida: {player.Life} - Daño: {player.Damage}");
        }
    }
}
