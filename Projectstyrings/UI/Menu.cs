using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Menu
    {
        private Controller x = null;

        public Menu()
        {
            x = new Controller();
        }

        public void RunMenu()
        {
            string tournamentName = null;
            bool running = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("1. Profiles");
                Console.WriteLine("2. Projects");
                Console.WriteLine();
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Indtast dit valg: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        Console.Write("1. Choose a Profile");
                        Console.Write("2. Create a new Profile");
                        break;
                    case "2":
                        Console.Write("1. Choose a new Project");
                        Console.Write("2. Create a new Project");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }
    }
}