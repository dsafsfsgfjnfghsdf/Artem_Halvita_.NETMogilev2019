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
            int n = Convert.ToInt32(Console.ReadLine());

            int f1 = 0;
            int f2 = 1;
            int fn;

            Console.Write($"\n{f1} {f2} ");

            for (int i = 0; i < n; i++)
            {
                fn = f1 + f2;
                Console.Write($"{fn} ");
                f1 = f2;
                f2 = fn;
            }
        }
    }
}
