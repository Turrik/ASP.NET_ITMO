using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskP9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s[0] == s[3] && s[1] == s[2])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
