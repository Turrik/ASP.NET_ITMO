using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи,которую хотите проверить");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                switch (number)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                }
                Console.WriteLine("Введите номер задачи,которую хотите посмотреть или 0,чтобы выйти");
                number = int.Parse(Console.ReadLine());
            }
        }

        public static void task1()
        {
            Console.WriteLine("найти сумму всех целых чисел, лежащих между 1 и N включительно.\nВведите n");
            int n = int.Parse(Console.ReadLine());
            int sum=0;
            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = 1; i >= n; i--)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Сумма равна " + sum);
        }

        public static void task2()
        {
            Console.WriteLine("В единственной строке записано 2 числа — количество банок, простреленных Гарри и Ларри соответственно.Выведите 2 числа — количество банок, не простреленных Гарри и Ларри соответственно.\nВведите кол-во простреленных банок ");
            string[] number = Console.ReadLine().Split(' ');
            Console.WriteLine("Кол-во простреленных банок равно " + (Convert.ToInt32(number[1])-1) + ' ' + (Convert.ToInt32(number[0])-1));
        }

        public static void task3()
        {
            Console.WriteLine("Для каждого n во вводе выведите соответствующее максимальное значение.\n");
            int n = 2;
            int count = 0;
            int[] array = new int[10];
            do
            {
                Console.WriteLine("Введите n ");
                array[count] = int.Parse(Console.ReadLine());
                count++;
            }
            while (array[count-1] != 0) ;
            for (int i = 0; array[i] != 0; i++)
            {
                int[] massive = new int[array[i]+1];
                massive[0] = 0;
                massive[1] = 1;
                for (int j = 2; j <= array[i]; j++)
                {
                    if (j%2 == 0)
                    {
                        massive[j] = massive[j/2];
                    }
                    else
                    {
                        massive[j] = massive[(j - 1)/2] + massive[((j - 1)/2) + 1];
                    }
                }
                Array.Sort(massive);
                Console.WriteLine("Максимум равен " + massive[array[i]]);
            }
        }
        
    }
}
