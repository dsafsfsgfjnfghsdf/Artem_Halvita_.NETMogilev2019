using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество  чисел Фибонначи: ");
            int quantityNumbers = Convert.ToInt32(Console.ReadLine());

            int fibonacci1 = 0;
            int fibonacci2 = 1;
            int fibonacciN;

            Console.Write($"\n{fibonacci1} {fibonacci2} ");

            for (int i = 0; i < quantityNumbers - 2; i++)
            {
                fibonacciN = fibonacci1 + fibonacci2;
                Console.Write($"{fibonacciN} ");
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacciN;
            }
        }
    }
}
