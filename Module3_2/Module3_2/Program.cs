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
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (n != 0)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                    n--;
                }
                i++;
            }
        }
    }
}
