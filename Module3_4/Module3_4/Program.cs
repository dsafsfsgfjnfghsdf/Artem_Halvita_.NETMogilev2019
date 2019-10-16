using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для преобразования: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int inverted = 0;

            while (number != 0)
            {
                inverted = inverted * 10 + number % 10;
                number /= 10;
            }

            Console.WriteLine($"Перевернутое число: {inverted}");
        }
    }
}
