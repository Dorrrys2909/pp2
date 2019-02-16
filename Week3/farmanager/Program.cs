using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace farmanager
{
    class Farmanager
    {
        public int point; //переменные
        DirectoryInfo dir;
        public int size;
        public Farmanager() //конструктор
        {
            point = 0;
        }
        public void Color(FileSystemInfo fs, int index) // функция для цветов
        {
            if (point == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (fs.GetType() == typeof(FileInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

        }
        public void Show(string path) // функция показ содержимого
        {
            dir = new DirectoryInfo(path);
            FileSystemInfo[] fsi = dir.GetFileSystemInfos();
            size = fsi.Length;

            for (int i = 0; i < size; i++)
            {
                Color(fsi[i], i);
                Console.WriteLine(fsi[i].Name);
            }
        }
        public void Start(string path) // основная функция старт
        {
            FileSystemInfo fs = null;
            while (1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (point == 0)
                    {
                        point = size - 1;
                    }
                    else
                    {
                        point--;
                    }
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (point == size - 1)
                    {
                        point = 0;
                    }
                    else
                    {
                        point++;
                    }
                }
                if (key.Key == ConsoleKey.O) // функция для открытия файлов и папок
                {
                    for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
                    {
                        if (point == i)
                        {
                            fs = dir.GetFileSystemInfos()[i];
                            break;
                        }
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        point = 0;
                        dir = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                    else if (fs.GetType() == typeof(FileInfo))
                    {
                        FileStream fss = new FileStream(fs.FullName, FileMode.Open, FileAccess.Read);
                        StreamReader str = new StreamReader(fss);
                        string s = "";
                        while (!str.EndOfStream)
                        {
                            s += str.ReadLine();
                        }
                        Console.Clear();
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        fss.Close();
                        str.Close();

                    }
                }
                if (key.Key == ConsoleKey.D) //функция для удаления 
                {
                    for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
                    {
                        if (point == i)
                        {
                            fs = dir.GetFileSystemInfos()[i];
                            break;
                        }
                    }
                    fs.Delete();
                }
                if (key.Key == ConsoleKey.R) // функция для переименования 
                {
                    for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
                    {
                        if (i == point)
                        {
                            fs = dir.GetFileSystemInfos()[i];
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("new name: ");
                    string newname = Console.ReadLine();
                    string p = new DirectoryInfo(fs.FullName).Parent.FullName;
                    if (fs.GetType() == typeof(FileInfo))
                    {
                        File.Move(fs.FullName, p + "/" + newname);
                    }
                    else {
                        Directory.Move(fs.FullName, p + "/" + newname);
                    }
                }
                if (key.Key == ConsoleKey.I) // переход к предыдующей папке
                {
                    point = 0;
                    dir = dir.Parent;
                    path = dir.FullName;

                }
                if (key.Key == ConsoleKey.E) // функция для завершения рабооты фарменеджер
                {
                    return;
                }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                Farmanager far = new Farmanager(); // объект класса farmanager
                string path = @"C:\Users\Дария\Desktop\СЕКСЕНБАЕВА"; // указываем путь к папке
                far.Start(path); // вызываем функцию 

            }
        }
    }
}
