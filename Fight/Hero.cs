using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Hero
    {
        private int HP;
        private int AP;
        private int damage;
        private int heal;
        private string name;
        private Random Rnd = new Random();
        private int cooldown = 0;

        public Hero(string name = "John")
        {
            HP = 1020;
            AP = 1;
            this.name = name;
        }

        private void Attack(Monster tar) {
            damage = Rnd.Next(1, 101);
            tar.HP -= damage;
        }

        private void Heal() {
            heal = Rnd.Next(1, 51);
            HP += heal;
            
        }
        
        private void Kobe(Monster tar) {
            damage = Rnd.Next(100, 9999);
            tar.HP -= damage;
            cooldown = 5;
        }

        public void Turn(Monster tar)
        {

            string key = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU");
            Console.ForegroundColor = ConsoleColor.White;
            switch (key)
            {
                case "a":
                    Attack(tar);
                    Console.WriteLine("You did {0} damage.", damage);
                    Console.WriteLine("He has {0} health remaining.", tar.Health);
                    Console.WriteLine();
                    break;
                case "h":
                    Heal();
                    Console.WriteLine("You healed yourself for {0} health.", heal);
                    Console.WriteLine("You have {0} health remaining.", HP);
                    Console.WriteLine();
                    break;
                case "k":
                    if (cooldown == 0)
                    {
                        Kobe(tar);
                        Console.WriteLine("KOBE!");
                        Console.WriteLine("You did {0} damage.", damage);
                        Console.WriteLine("He has {0} health remaining.", tar.Health);
                    } else
                    {
                        Console.WriteLine("The special ability Kobe is on cooldown, it needs {0} more turns to recharge", cooldown);
                    }
                    break;
                default:
                    Console.WriteLine("This was not an option. You wasted your turn. Loser!");
                    break;
            }
            if (cooldown > 0)
            {
                cooldown -= 1;
            }
            

        }

        public string Name {

            get { return name; }

        }
        public int Health {
            get { return HP; }
            set { HP = value; }
        }

        public int Cooldown {
            get { return cooldown; }
        }


    }
}
