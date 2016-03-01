using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TaskP8
{
    enum days { Monday = 0, Tuesday, Wednsday, Thursday, Friday, Saturday, Sunday }
            ;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(days.Monday);
                    break;
                case 2:
                    Console.WriteLine(days.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(days.Wednsday);
                    break;
                case 4:
                    Console.WriteLine(days.Thursday);
                    break;
                case 5:
                    Console.WriteLine(days.Friday);
                    break;
                case 6:
                    Console.WriteLine(days.Saturday);
                    break;
                case 7:
                    Console.WriteLine(days.Sunday);
                    break;
            }

        }
    }
}

