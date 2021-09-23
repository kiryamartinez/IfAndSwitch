using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthHero = 100;
            int healthBoss = 1000;
            int damageBoss;
            int inputSkill = 0;
            bool spirit = false;
            Random rnd = new Random();

            Console.WriteLine("Бой с боссом!!! Будьте осторожный у босса рандомная еденица урона!");

            while (healthHero > 0 && healthBoss > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Здоровье героя: " + healthHero + " Здоровье босса: " +  healthBoss);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Выберите способность:");
                Console.WriteLine("1 - Рашамон – призывает теневого духа для нанесения атаки (Отнимает 10 хп игроку)");
                Console.WriteLine("2 - Хуганзакура (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона");
                Console.WriteLine("3 - Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп");
                Console.WriteLine("4 - Мощный удар молнией,наносит 400 урона.(Отнимает 100 хп игроку)");
                inputSkill=Convert.ToInt32(Console.ReadLine());
                switch (inputSkill)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Призывается дух! 10хп отнимается игроку");
                        healthHero -= 10;
                        spirit = true;
                        break;
                    case 2:
                        if (spirit==true)
                        {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Урон в 100 ед");
                        healthBoss -= 100;
                        }
                        else
                        {
                            Console.WriteLine("Для использования нужно призвать Рашамона");
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вы скрываетесь и восстанавливаете 250хп");
                        healthHero += 250;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Урон боссу в 400 ед. У героя отнимается 100хп");
                        healthHero -= 100;
                        healthBoss -= 400;
                        break;

                }
                damageBoss = rnd.Next(50,100);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Удар босса в "+ damageBoss + " едениц");
                healthHero -= damageBoss; 
            }

            if(healthHero<=0 && healthBoss <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ничья! Оба мертвы!");
            }
            else if (healthHero<=0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Герой умер! Победа босса!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Победа героя! Босс мертв!");
            }
        }
    }
}
