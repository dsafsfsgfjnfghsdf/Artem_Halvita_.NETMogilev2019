using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введте количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Random rand = new Random();

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 9);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\nЭлементы числового массива, которые больше, чем элементы, стоящие перед ними:");

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                    Console.Write($"{arr[i + 1]} ");
            }
        }
    }
}
