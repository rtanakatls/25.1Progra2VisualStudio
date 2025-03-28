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
            GainExperienceMenu();
        }

        private void CreatePlayer()
        {
            string name;
            Console.WriteLine("Introduce el nombre:");
            name= Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"Se ha creado al jugador con nombre: {player.Name} y está en nivel {player.Level} con {player.Experience} de experiencia");
        }

        private void GainExperienceMenu()
        {
            bool continueFlag = true;
            while (continueFlag) 
            {
                Console.WriteLine("Selecciona una opción");
                Console.WriteLine("1. Obten 1 de experiencia");
                Console.WriteLine("2. Obten 10 de experiencia");
                Console.WriteLine("3. Obten 100 de experiencia");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        player.GainExperience(1);
                        Console.WriteLine(player.GetPlayerData());
                        break;
                    case "2":
                        player.GainExperience(10); 
                        Console.WriteLine(player.GetPlayerData());
                        break;
                    case "3":
                        player.GainExperience(100);
                        Console.WriteLine(player.GetPlayerData());
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}
