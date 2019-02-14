using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static bool Prime(int a) //new  boolean function 
        {
            bool cnt = true; //boolean variable
            if (a <= 1) // checking for prime number
            {
                return false;
            }
            else
            {
                for(int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // giving a number of array
            int a = int.Parse(s); // get only numbers from a string line
            string ss = Console.ReadLine(); // elements of array
            int[] arr = new int[a]; // new array
            string[] sss = ss.Split(' '); // if there is one space this is another element

            for(int i = 0; i < sss.Length; i++) // filling array
            {
                arr[i] = int.Parse(sss[i]);
            }

            List<int> b = new List<int>(); // new list, like a vector

            foreach(int q in arr) // foreach checking with boolean function
            {
                if (Prime(q))
                {
                    b.Add(q);
                }
            }

            Console.WriteLine(b.ToArray().Length); // length of list, array
             
            foreach(int q in b) 
            {
                Console.Write(q + " "); // elements of list, array
            }
            Console.WriteLine();
        }
    }
}
