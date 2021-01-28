using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    class GameManager
    {
        public void Start()
        {
            // creates game objects
            Player player = new Player();
            Enemy enemy = new Enemy();

            // allows user to name player
            // player.NamePlayer();

            // shows stats
            player.ShowHUD();
            enemy.ShowHUD();

            player.TakeDamage(50);

            player.ShowHUD();
            enemy.ShowHUD();

            // waits for user input to close
            Console.WriteLine("Once done hit any key to close");
            Console.ReadKey();
        }
    }
}