using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int n = int.Parse(Console.ReadLine());            
            int[] array = new int[n];
            int sum1 = 0, sum2 = 0;
            string[] arr = (Console.ReadLine()).Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }
            Array.Sort(array);
            for (int j = n-1; j>=0; j--)
            {
                if (sum1 - sum2 >= 0)
                {
                    sum2 += array[j];
                }
                else
                {
                    sum1 += array[j];
                }
            }
            Console.WriteLine("Минимальная разность равна " + (sum2-sum1));
            Console.ReadLine();
        }
    }
}

