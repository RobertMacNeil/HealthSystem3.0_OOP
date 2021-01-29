using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    // parent of Player and Enemy
    abstract class GameCharacter
    {
        protected string name;
        protected int shield;
        protected int maxShield;
        protected int health;
        protected int maxHealth;
        protected int lives;

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Debug: " + name + " is about to be dealt " + damage + " damage");
            // error check
            if (damage < 0)
            {
                Console.WriteLine("Error: The damage value has to be a positive number");
                Console.WriteLine();
                return;
            }
            else
            {
                // dealing damage
                Console.WriteLine(name + " took " + damage + " damage");
                shield = shield - damage;
                if (shield < 0)
                {
                    int rDamage = shield * -1;
                    shield = 0;
                    health = health - rDamage;
                    // if shield breaks goes through to damage character
                    // if kills the character
                    if (health <= 0)
                    {
                        health = 0;
                        lives = lives - 1;
                        if (lives <= 0)
                        {
                            Console.WriteLine(name + " has died");
                        }
                        else
                        {
                            Console.WriteLine(name + " has lost a life");
                            ResetStats();
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public void Heal(int heal)
        {
            Console.WriteLine("Debug: " + name + " is about to be healed " + heal + " health");
            // error check
            if (heal < 0)
            {
                Console.WriteLine("Error: The heal value has to be a positive number");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine(name + " has healed " + heal + " health");
                health = health + heal;
                if(health > maxHealth)
                {
                    Console.WriteLine(name + " has been brought to max health: " + maxHealth);
                    health = maxHealth;
                }
            }
            Console.WriteLine();
        }

        public void RegenerateShield(int regen)
        {
            Console.WriteLine("Debug: " + name + " is about to regenerate " + regen + " shield");
            // error check
            if (regen < 0)
            {
                Console.WriteLine("Error: The regen value has to be a positive number");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine(name + " has regenerated " + regen + " shield");
                shield = shield + regen;
                if (shield > maxShield)
                {
                    Console.WriteLine(name + " has been brought to max shield: " + maxShield);
                    shield = maxShield;
                }
            }
            Console.WriteLine();
        }

        public void ShowHUD()
        {
            Console.WriteLine(name + "'s stats:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine();
        }

        public void ResetStats()
        {
            Console.WriteLine("DEBUG: RESETTING CHARACTER");
            health = maxHealth;
            shield = maxShield;
        }

        // -----------------Get/Set

        /*public int GetLives()
        {
            return lives;
        }
        public void SetLives(int value)
        {
            if (value < 1)
            {
                value = 1;
            }
            lives = value;
        }
        public int GetMaxHealth()
        {
            return maxHealth;
        }
        public void SetMaxHealth(int value)
        {
            if (value < 1)
            {
                value = 1;
            }
            health = value;
        }
        public int GetMaxShield()
        {
            return maxShield;
        }
        public void SetMaxShield(int value)
        {
            if (value < 1)
            {
                value = 1;
            }
            shield = value;
        }
        */

    }
}
