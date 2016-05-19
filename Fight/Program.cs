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
            Monster monster = new Monster();
            Hero hero = new Hero();

            Console.WriteLine(" U kan typen: a (Attack), h (Heal) of k (Kobe)");
            Console.WriteLine();

            while (hero.Health > 0 && monster.HP > 0)
            {

                hero.Turn(monster);

                monster.Turn(hero);

            }

            if (hero.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOUR BOOTY HAS BEEN DESTROYED.");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU HAVE DESTROYED THE ENEMY'S BOOTY.");
                Console.ForegroundColor = ConsoleColor.White;
            }


           
            
           



        }
    }
}
