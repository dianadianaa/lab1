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
            string starString = Console.ReadLine(); //вводим размер трегольника
            int star = int.Parse(starString); //конвертируем строковое в целочисленное

            for (int i = 0; i <= star; i++) //заполняем строки
            {
                for (int j = 0; j < i; j++) //заполняем столббцы
                {
                    Console.Write("[*]");
                }
                Console.Write("\n");//на след строку переход
            }
            Console.ReadKey();//вывод
        }
    }
}



