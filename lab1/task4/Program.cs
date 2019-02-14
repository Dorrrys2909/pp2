using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s); // writing number of star triangle
            for (int i = 1; i <= a; i++) // creating rows 
            {
                for (int j = 1; j <= i; j++) // creating columns
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
