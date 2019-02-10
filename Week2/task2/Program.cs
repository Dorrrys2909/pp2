using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static bool Prime(int a)
        {
            if (a <= 1)
            {
                return false;
            }
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            System.IO.StreamReader inp = new System.IO.StreamReader(@"C:\Users\Дария\Documents\PP2\Week2\task2\2.txt");
            string arr = inp.ReadToEnd();
            string[] arra = arr.Split(' ');
            System.IO.StreamWriter outp = new System.IO.StreamWriter(@"C:\Users\Дария\Documents\PP2\Week2\task2\result.txt");

            for (int i = 0; i < arra.Length; i++)
            {
                int we = int.Parse(arra[i]);


                if (Prime(we))
                {
                    outp.Write(we + " ");
                 
                }
            }
            outp.Close();

        }
    }
}
