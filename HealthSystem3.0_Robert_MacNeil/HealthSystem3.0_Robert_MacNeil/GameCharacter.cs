using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    abstract class GameCharacter
    {
        protected string name;
        protected int shield;
        protected int health;
        protected int lives;

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Debug: " + name + " is about to be dealt " + damage + " damage");
            if (damage < 0)
            {
                Console.WriteLine("Error: The damage value has to be a positive number");
                Console.WriteLine();
                return;
            }
            else
            {
                shield = shield - damage;
                if (shield < 0)
                {
                    int rDamage = shield * -1;
                    shield = 0;
                    health = health - rDamage;

                    if (health <= 0)
                    {
                        lives = lives - 1;
                        if (lives <= 0)
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine(name + " has lost a life");
                        }
                    }
                }
                Console.WriteLine(name + " took " + damage + " damage");
                Console.WriteLine();
            }
        }

        public void Heal(int health)
        {

        }

        public void RegenerateShield(int regen)
        {

        }

        public void ShowHUD()
        {
            Console.WriteLine(name + "'s stats:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine();
        }
    }
}
