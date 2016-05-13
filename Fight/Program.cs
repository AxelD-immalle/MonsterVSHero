using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {



            var Monster1 = new Monster();
            var Monster2 = new Monster();

            Console.WriteLine(" U kan typen: Attack, Heal");
            Console.WriteLine();

            string key = Console.ReadLine();

            if (key == "Attack")
            {
                int damage = Monster2.Attack.Next(1, 100);
                Monster1.health = Monster1.health - damage;
                Console.WriteLine("You've taken {0} damage", damage);
                Console.WriteLine("You've {0} health remaining", Monster1.health);
            }



        }
    }
}
