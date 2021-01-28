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
            Console.WriteLine("Press any key to continue...");

            GameManager gameManager = new GameManager();

            // waits for user input to continue then wipes screen and starts
            Console.ReadKey();
            Console.Clear();

            gameManager.Start();
        }
    }
}
