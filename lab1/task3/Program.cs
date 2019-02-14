using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Double(int[] arr, int[] arr1) // function with parameters
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr1[2 * i] = arr1[2 * i + 1] = arr[i];

            }
            foreach (int i in arr1) // array
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // number of elements in array in line
            int a = int.Parse(s); // number from line
            string ss = Console.ReadLine();
            int[] arr = new int[a]; // new array
            string[] sss = ss.Split(' '); // if there is one space, this is new element
            int[] arr1 = new int[2*a]; // second array with doubled number
            for(int i = 0; i < sss.Length; i++)
            {
                arr[i] = int.Parse(sss[i]); // filling array
            }
            Double(arr, arr1); // function to double
        }
    }
}
