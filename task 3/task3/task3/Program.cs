using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using System.IO;

namespace task3
{
    class Program
    {
        static void MakeSpace(int lvl) //метод для расстояния
        {
            for (int i = 0; i < lvl; i++)
                Console.Write("       ");
        }


        static void FD(DirectoryInfo dir, int lvl)
        {
            FileInfo[] files = dir.GetFiles(); //записываем в массив список файлов
            DirectoryInfo[] directories = dir.GetDirectories(); //записываем в другой массив список директорий

            foreach (FileInfo file in files)
            {
                MakeSpace(lvl);
                Console.WriteLine(file.Name); //имя файла записывается в консоль
            }

            foreach (DirectoryInfo d in directories)
            {
               MakeSpace(lvl);
                Console.WriteLine(d.Name); //имя каталога записыватеся в консоль
                FD(d, lvl + 1);
            }
        }



        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"/Users/dee/Desktop/File"); //инициализирует содержимое папки
            FD(d, 0); //начинаем с нулевого уровня
            Console.ReadKey();
        }
    }
}





