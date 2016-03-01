using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberoftask = 0;
            Console.WriteLine("Введите номер задачи,которую хотите просмотреть.");
            while (numberoftask !=51 || numberoftask !=0)
            {
                numberoftask = int.Parse(Console.ReadLine());
                switch (numberoftask)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                }
                Console.WriteLine("Введите номер задачи,которую хотите просмотреть. Для выхода введите 51");
            }
        }

        static void Task1()
        {
            Console.WriteLine("Формулировка. Вывести на экран сообщение «Hello World!».");
            Console.WriteLine("Hello World!");
        }

        static void Task2()
        {
            Console.WriteLine("Формулировка. Вывести на экран три введенных с клавиатуры числа в порядке, " +
                              "обратном их вводу.");
            int firstnumber, secondnumber, thirdnumber;
            Console.WriteLine("Введите первое число.");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число.");
            thirdnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(thirdnumber + " " + secondnumber + " " + firstnumber);
        }

        static void Task3()
        {
            Console.WriteLine("Формулировка. Дано натуральное число меньше 256. Сформировать число, представляющее собой его квадрат.");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number * number);
        }

        static void Task4()
        {
            Console.WriteLine("Формулировка. Сформировать число, представляющее собой реверсную запись заданного трехзначного числа.");
            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            Console.WriteLine(str[2] + "" + str[1] + "" + str[0]);
        }

        static void Task5()
        {
            Console.WriteLine("Формулировка. Дано натуральное число меньше 16.Посчитать количество его единичных битов.");
            int count = 0;
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                count = count + number % 2;
                number = number / 2;
            }
            Console.WriteLine("Результат: " + count);
        }

        static void Task6()
        {
            Console.WriteLine("Даны два числа. Вывести на экран то из них, которое больше.");
            Console.WriteLine("Введите первое число");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondnumber = int.Parse(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                Console.WriteLine("Результат: " + firstnumber);
            }
            else
            {
                Console.WriteLine("Результат: " + secondnumber);
            }
        }

        static void Task7()
        {
            Console.WriteLine("Формулировка. Даны три числа. Вывести на экран то из них, которое больше");
            Console.WriteLine("Введите первое число");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int thirdnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            if (firstnumber > secondnumber && firstnumber > thirdnumber)
            {
                Console.WriteLine(firstnumber);

            }
            else if (secondnumber > firstnumber && secondnumber > thirdnumber)
            {
                Console.WriteLine(secondnumber);

            }
            else if (thirdnumber > firstnumber && thirdnumber > secondnumber)
            {
                Console.WriteLine(thirdnumber);

            }
        }

        static void Task8()
        {
            Console.WriteLine("Формулировка. Вывести название дня недели по его номеру.");
            Console.WriteLine("Введите номер");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
            case 1:
                    Console.WriteLine(number+"-й день недели это "+ "понедельник");
            break;
                case 2:
                    Console.WriteLine(number + "-й день недели это " + "вторник");
            break;
                case 3:
                    Console.WriteLine(number + "-й день недели это " + "среда");
            break;
                case 4:
                    Console.WriteLine(number + "-й день недели это " + "четверг");
            break;
                case 5:
                    Console.WriteLine(number + "-й день недели это " + "пятница");
            break;
                case 6:
                    Console.WriteLine(number + "-й день недели это " + "суббота");
            break;
                case 7:
                    Console.WriteLine(number + "-й день недели это " + "воскресенье");
            break;
        }
        
    }

        static void Task9()
        {
            Console.WriteLine("Формулировка.Дано четырехзначное число. Проверить, является ли оно палиндромом");
            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            if (str[0] == str[3] && str[1] == str[2])
            {
                Console.WriteLine("Да,это полиндром");
            }
            else
            {
                Console.WriteLine("Нет,это не палиндром");
            }
        }

        static void Task10()
        {
            Console.WriteLine("Формулировка.Дано четырехзначное число. Проверить, является ли оно «счастливым билетом».");
            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            if (Convert.ToInt32(str[0]) + Convert.ToInt32(str[1]) == Convert.ToInt32(str[2]) + Convert.ToInt32(str[3]))
            {
                Console.WriteLine("Да,это счастливый билет");
            }
            else
            {
                Console.WriteLine("Нет,это не счастливый билет");
            }
        }

        static void Task11()
        {
            Console.WriteLine("Дано число типа byte. Проверить, является ли палиндромом его двоичное представление с учетом того, что сохранены старшие нули");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int number1 = number;
            int count = 0;
            int[] bytes= new int[8];
            while (number1 != 0)
            {
                number1 /=2;
                count ++;
            }
            int n = 8 - count;
            for (int i = 0; i < n; i++)
            {
                bytes[i] = 0;
            }
            for (int i =7; i >= n; i--)
            {
                bytes[i] = number % 2;
                number /= 2;
            }

            if (bytes[0] == bytes[7] && bytes[1] == bytes[6] && bytes[2] == bytes[5] && bytes[3] == bytes[4]) Console.WriteLine("Это палиндром");

            else
                {
                    Console.WriteLine("Это не палиндром");
                }
            }

        }
    }
