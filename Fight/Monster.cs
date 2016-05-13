using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Monster
    {
        public int health;
        public Random Attack = new Random();
        public Random Heal = new Random();

        public Monster()
        {
            health = 1000;
        }

        public void Do()
        {
            
        }

        public int Health
        {
            get { return health; }
        }
        

    }
}
