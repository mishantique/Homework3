using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, last_digit, first_digit;
            string first_age, second_age, age_word;

            Console.WriteLine("Введите возраст от 20 до 69 включительно");
            age = Convert.ToInt32(Console.ReadLine());

            if (20 <= age && age <= 69)
            {
                last_digit = age % 10;
                first_digit = (age % 100) / 10;

                if (last_digit == 1)
                {
                    age_word = "год";
                    second_age = "один";
                    if (first_digit == 2)
                    {
                        first_age = "двадцать";
                        Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                    else if (first_digit == 3)
                    {
                        first_age = "тридцать";
                        Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                    else if (first_digit == 4)
                    {
                        first_age = "сорок";
                        Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                    else if (first_digit == 5)
                    {
                        first_age = "пятьдесят";
                        Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                    else if (first_digit == 6)
                    {
                        first_age = "шестьдесят";
                        Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                }
                
                else if (2 <= last_digit && last_digit <= 4)
                {
                    age_word = "года";
                    switch (last_digit)
                    {
                        case 2:
                            {
                                second_age = "два";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 3:
                            {
                                second_age = "три";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 4:
                            {
                                second_age = "четыре";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                    }  
                }
                else if (5 <= last_digit && last_digit <= 9 || last_digit == 0)
                {
                    age_word = "лет";
                    switch (last_digit)
                    {
                        case 5:
                            {
                                second_age = "пять";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 6:
                            {
                                second_age = "шесть";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 7:
                            {
                                second_age = "семь";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 8:
                            {
                                second_age = "восемь";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 9:
                            {
                                second_age = "девять";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 0:
                            {
                                second_age = "";
                                switch (first_digit)
                                {
                                    case 2:
                                        {
                                            first_age = "Двадцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            first_age = "Тридцать";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            first_age = "Сорок";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            first_age = "Пятьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 6:
                                        {
                                            first_age = "Шестьдесят";
                                            Console.WriteLine("{0} {1} {2}", first_age, second_age, age_word);
                                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
            else
            {
                Console.WriteLine("Неправильно введен возраст");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }

        }
    }
}
