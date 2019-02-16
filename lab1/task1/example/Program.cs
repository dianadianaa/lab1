using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Isprime(int n) //метод который определяет простое число или нет 
        {
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) //если число делится, то число счетчика увеличивается
                    cnt++;
            }
            if (cnt == 2) //если кол-во делителей равно двум то число является простым
                return true;
            else
                return false; //если условие не выполнено то возвращается значение фолс
        }

        static void Main(string[] args)
        {
            String f = Console.ReadLine(); //устанавливаем кол-во эл-ов в массиве
            int an = int.Parse(f);//конвертируем в целочисленное

            var prost = new List<int>(); //новый список

            String b = Console.ReadLine(); //заполняем массив
            String[] nums = b.Split(' ');

            for (int i = 0; i < an; i++)
            {
                int numm = int.Parse(nums[i]); //конвертируем элементы массива в целочисленные
                if (Isprime(numm))
                {
                    prost.Add(numm); //если функция возвращает тру, тогда доавляем элемент в список
                }
            }

            Console.WriteLine(prost.Count); //вывод количества эл-ов массива
            for (int i = 0; i < prost.Count; i++)
            {
                Console.Write(prost[i] + " "); //вывод простых чисел
            }
            Console.ReadKey();
        }
    }
}
