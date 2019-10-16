using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_6
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
                arr[i] = rand.Next(-5, 5);
                Console.Write("{0, 3}", $"{arr[i]}");
            }

            Console.WriteLine("\nПреобразованный массив:");

            for (int i = 0; i < n; i++)
            {
                arr[i] *= -1;
                Console.Write("{0, 3}", $"{arr[i]}");
            }

            Console.WriteLine();
        }
    }
}
