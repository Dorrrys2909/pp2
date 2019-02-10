using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = @"C:\Users\Дария\Documents\PP2\Week2\task4\1.txt";    //  Пути для создания 
            string w = @"C:\Users\Дария\Documents\PP2\Week2\task4\2.txt";    //     файлов
            string asd = "Hello World!";
            System.IO.StreamWriter dd = new System.IO.StreamWriter(q);
            dd.Write(asd);
            dd.Close();
            System.IO.File.Copy(q, w);   //  Копируем  в новый файл
            System.IO.File.Delete(q);   //  Удаляем первый файл
        }
    }
}
