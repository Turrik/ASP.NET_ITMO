using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество голосующих групп");
            int n = int.Parse(Console.ReadLine());
            int m = n/2 + 1;
            int[] array = new int[n];
            int sum = 0;
            Console.WriteLine("Введите количество людей в группе");
            string[] arr = (Console.ReadLine()).Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }
            Array.Sort(array);
            for (int i = 0; i < m; i++)
            {
                sum += array[i]/2+1;
            }
            Console.WriteLine("Выведите минимальное количество сторонников партии, " +
                              "способное решить исход голосования равно " +sum);
            Console.ReadLine();


        }
    }
}
