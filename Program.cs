using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int age = 0;
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Введи номер дня своего рождения");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи номер месяца своего рождения");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи год своего рождения");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((d > 0 & d < 32) && (m > 0 & m < 13) && (y > 0 & y < Convert.ToInt32(now.ToString("yyyy"))))
            {
                if (m == 2 && d > 29)
                {
                    Console.WriteLine("Вы ввели неверные данные");
                }
                else if (m % 2 != 0 && d == 31)
                {
                    Console.WriteLine("Вы ввели неверные данные");
                }
                else if (m == 2 && d == 29)
                {
                    if (y % 4 != 0)
                    {
                        Console.WriteLine("Вы ввели неверные данные");
                    }
                    else if (y % 100 == 0)
                    {
                        if (y % 400 != 0)
                        {
                            Console.WriteLine("Вы ввели неверные данные");
                        }
                        else
                        {
                            if (d > Convert.ToInt32(now.ToString("dd")) && m >= Convert.ToInt32(now.ToString("MM")))
                            {
                                age = Convert.ToInt32(now.ToString("yyyy")) - y - 1;
                            }
                            else
                            {
                                age = Convert.ToInt32(now.ToString("yyyy")) - y;
                            }
                            Console.WriteLine($"Привет,{name}.Ваш возраст равен {age} лет.Приятно познакомиться.");
                        }
                    }
                    else
                    {
                        if (d > Convert.ToInt32(now.ToString("dd")) && m >= Convert.ToInt32(now.ToString("MM")))
                        {
                            age = Convert.ToInt32(now.ToString("yyyy")) - y - 1;
                        }
                        else
                        {
                            age = Convert.ToInt32(now.ToString("yyyy")) - y;
                        }
                        Console.WriteLine($"Привет,{name}.Ваш возраст равен {age} лет.Приятно познакомиться.");
                    }
                }
                else
                {
                    if (d > Convert.ToInt32(now.ToString("dd")) && m >= Convert.ToInt32(now.ToString("MM")))
                    {
                        age = Convert.ToInt32(now.ToString("yyyy")) - y - 1;
                    }
                    else
                    {
                        age = Convert.ToInt32(now.ToString("yyyy")) - y;
                    }
                    Console.WriteLine($"Привет,{name}.Ваш возраст равен {age} лет.Приятно познакомиться.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверные данные");
            }
            Console.ReadKey();
        }
    }
}
