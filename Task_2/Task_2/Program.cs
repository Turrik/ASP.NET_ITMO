using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] nuli = new int[n];
            Console.WriteLine("Заполнение массива");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                int numb = 1;
                for (int z = 0; numb < array[j] ; z++)
                {
                    if (numb < array[j])
                    {
                        numb += z+1;
                    }
                }
                if (numb == array[j])
                {
                    nuli[j] = 1;
                }
                else
                {
                    nuli[j] = 0;
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(nuli[i]);
            }
            Console.ReadLine();
        }
    }
}
