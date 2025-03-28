using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class Menu : IMenu
    {
        private Player player;

        public void Execute()
        {
            CreatePlayer();
        }

        private void CreatePlayer()
        {
            string name;
            Console.WriteLine("Introduce el nombre:");
            name= Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"Se ha creado al jugador con nombre: {player.Name} y está en nivel {player.Level} con {player.Experience} de experiencia");
        }
    }
}
