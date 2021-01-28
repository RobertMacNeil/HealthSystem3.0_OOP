using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    class Player : GameCharacter
    {
        // child of GameCharacter
        public Player()
        {
            name = "Player";
            health = 100;
            maxHealth = 100;
            shield = 100;
            maxShield = 100;
            lives = 3;
        }

        public void NamePlayer()
        {
            Console.WriteLine("Please enter your characters name: ");
            name = Console.ReadLine();
            Console.Clear();
        }

        public new void ShowHUD()
        {
            Console.WriteLine(name + "'s stats:" );
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
        }
    }
}
