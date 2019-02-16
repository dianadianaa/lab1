
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine(); //кол-во эл-ов массива
            int n = int.Parse(a);

            String m = Console.ReadLine(); //ввод массива
            String[] numbers = m.Split(' '); //сплитим элементы через каждые " "

            doubleArray t = new doubleArray(); //обращаемся к классу doubleArray
            t.Do(numbers);
        }
    }
    public class doubleArray
    {
        public void Do(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); //ввод эл-та
                Console.Write(array[i] + " "); //повторный ввод
            }
            Console.ReadKey();//вывод
        }
    }
}

