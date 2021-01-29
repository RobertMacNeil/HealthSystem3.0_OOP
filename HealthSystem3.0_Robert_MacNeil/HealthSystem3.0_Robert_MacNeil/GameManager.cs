using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    class GameManager
    {
        public void TestLogs()
        {
            // creates game objects
            Player player = new Player();
            Enemy enemy = new Enemy();

            // allows user to name player
            // player.NamePlayer();

            // testing scripts
            // showcase Player.TakeDamage() modifies shield
            player.ResetStats();
            player.ShowHUD();
            player.TakeDamage(50);
            player.ShowHUD();

            // showcase Player.TakeDamage() modifies shield and health
            player.ResetStats();
            player.ShowHUD();
            player.TakeDamage(150);
            player.ShowHUD();

            // showcase Player.TakeDamage() modifies shield and health and lives
            player.ResetStats();
            player.ShowHUD();
            player.TakeDamage(250);
            player.ShowHUD();

            // showcase Player.TakeDamage() error checks
            player.ResetStats();
            player.ShowHUD();
            player.TakeDamage(-10);
            player.ShowHUD();

            // showcase Player.Heal() modifies health from full
            player.ResetStats();
            player.ShowHUD();
            player.Heal(100);
            player.ShowHUD();

            // showcase Player.Heal() modifies health from half full
            player.ResetStats();
            player.ShowHUD();
            player.TakeDamage(150);
            player.Heal(100);
            player.ShowHUD();



            // showcase Player.TakeDamage() modifies shield
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.TakeDamage(50);
            enemy.ShowHUD();

            // showcase Player.TakeDamage() modifies shield and health
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.TakeDamage(150);
            enemy.ShowHUD();

            // showcase Player.TakeDamage() modifies shield and health and lives
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.TakeDamage(250);
            enemy.ShowHUD();

            // showcase Player.TakeDamage() error checks
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.TakeDamage(-10);
            enemy.ShowHUD();

            // showcase Player.Heal() modifies health from full
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.Heal(100);
            enemy.ShowHUD();

            // showcase Player.Heal() modifies health from half full
            enemy.ResetStats();
            enemy.ShowHUD();
            enemy.TakeDamage(150);
            enemy.Heal(100);
            enemy.ShowHUD();

            // waits for user input to close
            Console.WriteLine("Once done hit any key to close");
            Console.ReadKey();
        }

        /*
        public void Start()
        {
            Enemy enemy = new Enemy();
            Player player = new Player();
            while (player.GetLives() > 0)
            {
                player.ShowHUD();
                enemy.ShowHUD();
            }
        }
        */
    }
}