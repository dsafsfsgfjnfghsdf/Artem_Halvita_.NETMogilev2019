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
            Console.Write("Введите первый множитель: ");
            int firstMultiplier = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второй множитель: ");
            int secondMutiplier = Convert.ToInt32(Console.ReadLine());

            if (firstMultiplier >= 0 && secondMutiplier >= 0)
            {
                int multiply = 0;

                for (int i = 0; i < secondMutiplier; i++)
                    multiply += firstMultiplier;

                Console.WriteLine($"{firstMultiplier} * {secondMutiplier} = {multiply}");
            }
            else if (firstMultiplier <= 0 && secondMutiplier >= 0)
            {
                int multiply = ~firstMultiplier + 1 + firstMultiplier;

                for (int i = 0; i < secondMutiplier; i++)
                    multiply += firstMultiplier;

                Console.WriteLine($"{firstMultiplier} * {secondMutiplier} = {multiply}");
            }
            else if (firstMultiplier >= 0 && secondMutiplier <= 0)
            {
                int multiply = ~secondMutiplier + 1 + secondMutiplier;

                for (int i = 0; i < firstMultiplier; i++)
                    multiply += secondMutiplier;

                Console.WriteLine($"{firstMultiplier} * {secondMutiplier} = {multiply}");
            }
            else if (firstMultiplier <= 0 && secondMutiplier <= 0)
            {
                int multiply = ~firstMultiplier + 1 + firstMultiplier;

                for (int i = 0; i < (~secondMutiplier + 1); i++)
                    multiply += firstMultiplier;

                Console.WriteLine($"{firstMultiplier} * {secondMutiplier} = {-multiply}");
            }
        }
    }
}
