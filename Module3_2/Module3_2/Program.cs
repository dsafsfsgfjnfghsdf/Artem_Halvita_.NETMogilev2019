using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество натуральных чисел: ");
            int quantityIntegers = Convert.ToInt32(Console.ReadLine());

            int number = 0;
            while (quantityIntegers != 0)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                    quantityIntegers--;
                }
                number++;
            }
        }
    }
}
