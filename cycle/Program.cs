using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit=0;
            string userInputExit;
            string userInputExchange;
            float rub, usd, eur;
            float usdToRub = 73;
            float eurToRub = 87;
            float RubToUsd = 0.014f;
            float RubToEur = 0.012f;
            float usdToEur = 0.84f;
            float eurToUsd = 1.19f;
            float currencyCount;


            while (exit==0)
            {
                Console.WriteLine("Добро пожаловать в обменик!");

                Console.Write("Введите количество рублей: ");
                rub=Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите количество долларов: ");
                usd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите количество евро: ");
                eur = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("1 - обменять доллары в рубли.");
                Console.WriteLine("2 - обменять евро в рубли.");
                Console.WriteLine("3 - обменять рубли в доллары.");
                Console.WriteLine("4 - обменять рубли в евро.");
                Console.WriteLine("5 - обменять доллары в евро.");
                Console.WriteLine("6 - обменять евро в доллары.");
                userInputExchange = Console.ReadLine();
                switch (userInputExchange)
                {
                    case "1":
                        Console.WriteLine("Обмен долларов в рубли");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= usd)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен евро в рубли");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= eur)
                        {
                            eur -= currencyCount;
                            rub += currencyCount * eurToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен рубли в доллары");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= rub)
                        {
                            rub -= currencyCount;
                            usd += currencyCount * RubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен рубли в евро");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= rub)
                        {
                            rub -= currencyCount;
                            eur += currencyCount * RubToEur;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен долларов в евро");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= usd)
                        {
                            usd -= currencyCount;
                            eur += currencyCount * usdToEur;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен евро в доллары");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (currencyCount <= eur)
                        {
                            eur -= currencyCount;
                            usd += currencyCount * eurToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        break;
                }

                Console.WriteLine($"Ваш баланс {rub} рублей , {usd} долларов , {eur} евро .");
                Console.WriteLine("Вы хотите выйти из обменика?");
                userInputExit = Console.ReadLine();
                if (userInputExit == "Да" || userInputExit=="да")
                {
                    exit = 1;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("Вы вышли из обменика");
        }
    }
}
