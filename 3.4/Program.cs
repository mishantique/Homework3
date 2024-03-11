using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, first_digit, second_digit, third_digit;
            string first_word, second_word, third_word;

            Console.WriteLine("Введите число от 100 до 999");
            num = Convert.ToInt32(Console.ReadLine());

            if (100 <= num &&  num <= 999)
            {
                first_digit = (num % 1000) / 100;
                second_digit = (num % 100) / 10;
                third_digit = num % 10;

                switch (first_digit)
                    // Смотрим первую цифру
                {
                    case 1:
                        // Сто
                        #region
                        {
                            first_word = "Сто";
                            switch (second_digit)
                                // смотрим вторую цифру
                            { 
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    #endregion
                    case 2:
                        // Двести
                        {
                            first_word = "Двести";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        // Триста
                        {
                            first_word = "Триста";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        // Четыреста
                        {
                            first_word = "Четыреста";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 5:
                        // Пятьсот
                        {
                            first_word = "Пятьсот";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 6:
                        // Шестьсот
                        {
                            first_word = "Шестьсот";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 7:
                        // Семьсот
                        {
                            first_word = "Семьсот";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 8:
                        // Восемьсот
                        {
                            first_word = "Восемьсот";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 9:
                        // Девятьсот
                        {
                            first_word = "Девятьсот";
                            switch (second_digit)
                            // смотрим вторую цифру
                            {
                                case 1:
                                    // для случаев десять - девятнадцать
                                    {
                                        switch (third_digit)
                                        {
                                            case 0:
                                                // десять
                                                {
                                                    second_word = "десять";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 1:
                                                // одиннадцать
                                                {
                                                    second_word = "одиннадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // двенадцать
                                                {
                                                    second_word = "двенадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // тринадцать
                                                {
                                                    second_word = "тринадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // четырнадцать
                                                {
                                                    second_word = "четырнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // пятнадцать
                                                {
                                                    second_word = "пятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // шестнадцать
                                                {
                                                    second_word = "шестнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // семнадцать
                                                {
                                                    second_word = "семнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // восемнадцать
                                                {
                                                    second_word = "восемнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // девятнадцать
                                                {
                                                    second_word = "девятнадцать";
                                                    Console.WriteLine("{0} {1}", first_word, second_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 2:
                                    // сто двадцать
                                    {
                                        second_word = "двадцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто двадцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто двадцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто двадцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто двадцать чет ыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто двадцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто двадцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто двадцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто двадцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто двадцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 3:
                                    // сто тридцать
                                    {
                                        second_word = "тридцать";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто тридцать один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто тридцать два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто тридцать три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто тридцать четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто тридцать пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто тридцать шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто тридцать семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто тридцать восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто тридцать девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 4:
                                    // сто сорок
                                    {
                                        second_word = "сорок";
                                        // смотрим сорок цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто сорок один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто сорок два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто сорок три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто сорок четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто сорок пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто сорок шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто сорок семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто сорок восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто сорок девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 5:
                                    // сто пятьдесят
                                    {
                                        second_word = "пятьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто пятьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто пятьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто пятьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто пятьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто пятьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто пятьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто пятьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто пятьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто пятьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 6:
                                    // сто шестьдесят
                                    {
                                        second_word = "шестьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто шестьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто шестьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто шестьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто шестьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто шестьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто шестьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто шестьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто шестьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто шестьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 7:
                                    // сто семьдесят
                                    {
                                        second_word = "семьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто семьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто семьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто семьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто семьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто семьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто семьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто семьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто семьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто семьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 8:
                                    // сто восемьдесят
                                    {
                                        second_word = "восемьдесят";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто восемьдесят один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто восемьдесят два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто восемьдесят три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто восемьдесят четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто восемьдесят пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто восемьдесят шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто восемьдесят семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто восемьдесят восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто восемьдесят девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case 9:
                                    // сто девяноста
                                    {
                                        second_word = "девяноста";
                                        // смотрим третью цифру
                                        switch (third_digit)
                                        {
                                            case 1:
                                                // сто девяноста один
                                                {
                                                    third_word = "один";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 2:
                                                // сто девяноста два
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 3:
                                                // сто девяноста три
                                                {
                                                    third_word = "три";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 4:
                                                // сто девяноста четыре
                                                {
                                                    third_word = "четыре";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 5:
                                                // сто девяноста пять
                                                {
                                                    third_word = "пять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 6:
                                                // сто девяноста шесть
                                                {
                                                    third_word = "шесть";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 7:
                                                // сто девяноста семь
                                                {
                                                    third_word = "семь";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 8:
                                                // сто девяноста восемь
                                                {
                                                    third_word = "два";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            case 9:
                                                // сто девяноста девять
                                                {
                                                    third_word = "девять";
                                                    Console.WriteLine("{0} {1} {2}", first_word, second_word, third_word);
                                                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Введите число в указанном диапазоне");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
    }
}
