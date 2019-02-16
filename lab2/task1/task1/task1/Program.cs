using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{
    class Program
    {

        public static bool IsPalindrome(string a) //ввод значения boolean
        {
            for (int i = 0, j = a.Length - 1; i < j; i++, j--) //сравниваем первую часть и последнюю
                if (a[i] != a[j]) //если первая часть не похожа на вторую, возвращаем false, если нет true
                    return false;
            return true;
        }


        static void Main(string[] args)
        {
            string a = Console.ReadLine(); //ввод словa
            if (IsPalindrome(a)) //если функция палиндром возвращает true выводим Yes, если нет No
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }

    }
}



