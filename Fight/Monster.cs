using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Monster
    {
        

        public int HP;
        public int AP;
        private int damage;
        private int heal;
        public Random Rnd = new Random();


        public Monster()
        {
            HP = 1000;
            AP = 1;
        }

        private void Attack(Hero m)
        {
            damage = this.AP * Rnd.Next(1, 101);
            m.Health -= damage;
        }

        private void Heal()
        {
            heal = Rnd.Next(1, 51);
            this.HP += heal;
            if (this.HP>1000)
            {
                this.HP = 1000;
            }

        }

        public int Health
        {
            get { return HP; }
        }
        
        public int Damage
        {
            get { return damage; }
        }

        public int Regen
        {
            get { return heal; }
        }

        public void Turn(Hero tar)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ENEMY");
            Console.ForegroundColor = ConsoleColor.White;

            int rnd = Rnd.Next(1, 4);
            if (rnd == 1 | rnd == 2)
            {
                Attack(tar);
                Console.WriteLine("You've taken {0} damage.", Damage);
                Console.WriteLine("You've {0} health remaining.", tar.Health);
                Console.WriteLine();
            }
            else
            {
                Heal();
                Console.WriteLine("He healed himself for {0} health.", Regen);
                Console.WriteLine("He has {0} health remaining.", Health);
                Console.WriteLine();
            }
        }


    }
}
