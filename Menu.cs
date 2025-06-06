﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251
{
    internal class Menu : IMenu
    {
        private List<Node> nodes;
        private int currentPosition;
        private Player player;

        public void Execute()
        {
            CreateNodes();
            while(currentPosition< nodes.Count)
            {
                ShowNodes();
                Console.ReadKey();
                currentPosition++;
            }
        }

        private void ShowNodes()
        {
            string text = "";
            for (int i = 0; i < nodes.Count; i++)
            {
                if (i == currentPosition)
                {
                    Console.Write("P");
                    text = nodes[i].GetDescription();
                }
                else
                {
                    Console.Write(nodes[i].Code);
                }
            }
            Console.WriteLine();
            Console.WriteLine(text);
        }

        private void CreateNodes()
        {
            nodes= new List<Node>();
            currentPosition = 0;
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new DecisionNode());
            nodes.Add(new CombatNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new DecisionNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new CombatNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new DecisionNode());
            nodes.Add(new CombatNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new DecisionNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new AdvanceNode());
            nodes.Add(new CombatNode());
        }

        private void Execute2()
        {
            CreatePlayer();
            GainExperienceMenu();
        }

        private void CreatePlayer()
        {
            string name;
            int level=0;
            bool continueFlag1 = true;
            while (continueFlag1)
            {
                Console.WriteLine("Introduce el nombre:");
                name = Console.ReadLine();
                bool continueFlag2 = true;
                while (continueFlag2)
                {
                    Console.WriteLine("Introduce el nivel del jugador:");
                    try
                    {
                        level = int.Parse(Console.ReadLine());
                        continueFlag2 = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                try
                {
                    player = new Player(name, level);
                    continueFlag1 = false;
                }
                catch (PlayerNoNameException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(PlayerNoPositiveLevelException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

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
                        Console.WriteLine(player.GetData());
                        break;
                    case "2":
                        player.GainExperience(10); 
                        Console.WriteLine(player.GetData());
                        break;
                    case "3":
                        player.GainExperience(100);
                        Console.WriteLine(player.GetData());
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
