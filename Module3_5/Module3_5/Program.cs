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
            string number = Console.ReadLine();

            Console.Write("Введите цифру которую необходимо удалить: ");
            string digit = Console.ReadLine();

            Console.WriteLine($"Полученное число: {number.Replace(digit, "")}");

        }
    }
}
