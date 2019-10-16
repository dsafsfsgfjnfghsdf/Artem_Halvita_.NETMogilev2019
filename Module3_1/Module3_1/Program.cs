using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите множитель: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второй множитель: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                int multiply = 0;

                for (int i = 0; i < b; i++)
                    multiply += a;

                Console.WriteLine($"{a} * {b} = {multiply}");
            }
            else if (a <= 0 && b >= 0)
            {
                int multiply = ~a + 1 + a;

                for (int i = 0; i < b; i++)
                    multiply += a;

                Console.WriteLine($"{a} * {b} = {multiply}");
            }
            else if (a >= 0 && b <= 0)
            {
                int multiply = ~b + 1 + b;

                for (int i = 0; i < a; i++)
                    multiply += b;

                Console.WriteLine($"{a} * {b} = {multiply}");
            }
            else if (a <= 0 && b <= 0)
            {
                int multiply = ~a + 1 + a;

                for (int i = 0; i < (~b + 1); i++)
                    multiply += a;

                Console.WriteLine($"{a} * {b} = {-multiply}");
            }
        }
    }
}
