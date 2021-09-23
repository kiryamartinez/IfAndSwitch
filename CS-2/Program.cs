using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 10000;
            int damge = 180;
            int enemy = 10000;
            int enemyDamage = 185;

            while (health>0 && enemy>0)
            {
                health -= enemyDamage;
                enemy -= damge;

                Console.WriteLine("Герой: "+ health);
                Console.WriteLine("Враг: "+ enemy);
            }
            if (health<=0 && enemy<=0)
            {
                Console.WriteLine("Ничья");

            }
            else if (health>=0)
            {
                Console.WriteLine("Победа героя");
            }
            else if (enemy >= 0)
            {
                Console.WriteLine("Победа врага");
            }
        }
    }
}
