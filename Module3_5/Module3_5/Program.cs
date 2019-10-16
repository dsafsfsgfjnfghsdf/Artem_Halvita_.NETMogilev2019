using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер разяда числа (начиная с единицы), который необходимо удалить: ");
            int numberDigit = Convert.ToInt32(Console.ReadLine());

            int leftPart = number / (int)Math.Pow(10, numberDigit) * (int)Math.Pow(10, numberDigit - 1);
            int rightPart = number % (int)Math.Pow(10, numberDigit - 1);

            Console.WriteLine($"Полученное число: {leftPart + rightPart}");
        }
    }
}
