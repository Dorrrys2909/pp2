using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Polyndrom(string q)
        {
            bool p = true;
            for (int i = 0; i <= q.Length / 2; i++)
            {
                if (q[i] != q[q.Length - 1 - i])
                {
                    p = false;
                    return p;
                }
            }
            return p;
        }
        static void Main(string[] args)
        {
            string file = System.IO.File.ReadAllText(@"C:\Users\Дария\Documents\PP2\Week2\Task1\11.txt");
            if (Polyndrom(file))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
