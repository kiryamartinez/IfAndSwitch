using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="Имя не заданно", password="Пароль не задан", userInput, colorConsole;
            bool exit = false;
            bool havePassword = false;
            bool haveName = false;

            while (exit==false)
            {
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("SetName - задать имя пользователя");
                Console.WriteLine("SetPassword - задать пороль пользователя");
                Console.WriteLine("WriteName - вывести имя пользователя");
                Console.WriteLine("ChangeConsoleColor - изменить цвет текста консоли");
                Console.WriteLine("Esc - выйти");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "SetName":
                        Console.Write("Напишите имя пользователя: ");
                        name=Console.ReadLine();
                        haveName = true;
                        break;
                    case "SetPassword":
                        Console.Write("Напишите пароль пользователя: ");
                        password = Console.ReadLine();
                        havePassword = true;
                        break;
                    case "WriteName":
                        if (havePassword==true)
                        {
                            string password2;
                            Console.Write("Введите пароль:  ");
                            password2 = Console.ReadLine();
                            if (password2==password)
                            {
                                Console.WriteLine("Имя пользователя: " + name);
                            }
                            else
                            {
                                Console.WriteLine("Пароль не верный!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Пароль не был задан! Задайте пароль пользователя");
                        }
                        break;
                    case "ChangeConsoleColor":
                        Console.WriteLine("");
                        Console.Write("Выберите цвет- Зеленный, Голубой, Красный : ");
                        colorConsole = Console.ReadLine();
                        switch (colorConsole)
                        {
                            case "Зеленный":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "Голубой":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "Красный":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                        }
                        break;
                    case "Esc":
                        Console.WriteLine("Вы вышли из меню!");
                        exit = true;
                        break;
                }

            }
        }
    }
}
