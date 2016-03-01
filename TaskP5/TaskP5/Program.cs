using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            while (n!= 0 )
            {
                count = count + n%2;
                n = n/2;
            }
            Console.WriteLine(count);
        }
    }
}
