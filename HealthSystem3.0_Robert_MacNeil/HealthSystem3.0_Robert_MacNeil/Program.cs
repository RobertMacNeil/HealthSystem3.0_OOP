//Robert MacNeil
//Intro to OOP
//Health System 3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    class Program
    {
        static void Main(string[] args)
        {
            //first screen/title
            Console.WriteLine("Health System 3.0");
            Console.WriteLine("Made by: Robert MacNeil");
            Console.WriteLine();
            Console.WriteLine("This is currently a test log");
            //Console.WriteLine("Press 1: runs default test variables");
            //Console.WriteLine("Press 2: runs example game");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            GameManager gameManager = new GameManager();

            gameManager.TestLogs();

            // MenuOption();

            // waits for user input to continue then wipes screen and starts
            /*
            void MenuOption()
            {
                string option = Console.ReadKey().ToString();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        gameManager.TestLogs();
                        break;
                    case "2":
                        Console.Clear();
                        gameManager.Start();
                        break;
                    default:
                        Console.Clear();
                        MenuOption();
                        break;
                }
            }
            */

        }
    }
}
