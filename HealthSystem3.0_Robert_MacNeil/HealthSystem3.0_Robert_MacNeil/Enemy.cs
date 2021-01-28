using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3._0_Robert_MacNeil
{
    class Enemy : GameCharacter
    {
        public Enemy()
        {
            name = "Enemy";
            health = 100;
            shield = 100;
            lives = 1;
        }
    }
}
