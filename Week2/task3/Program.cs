using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static string Space(int a)
        {
            string s = "      ";
            string q = "";
            for (int i = 0; i < a; i++)
            {
                q += s;
            }
            return q;
        }
        static void qweqwe(System.IO.DirectoryInfo dir, int a)
        {
            System.IO.FileInfo[] files = dir.GetFiles();
            System.IO.DirectoryInfo[] dires = dir.GetDirectories();
            foreach (System.IO.FileInfo file in files)
            {

                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach (System.IO.DirectoryInfo dire in dires)
            {
                Console.Write(Space(a));
                Console.WriteLine(dire.Name);
                qweqwe(dire, a + 1);
            }
        }
        static void Main(string[] args)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"C:\Users\Дария\Desktop\СЕКСЕНБАЕВА\Док");
            qweqwe(dir, 0);
            Console.ReadKey();
        }
    }
}
