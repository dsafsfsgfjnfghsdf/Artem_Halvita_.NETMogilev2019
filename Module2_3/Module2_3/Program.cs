using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            string userAnswerA = Console.ReadLine();

            Console.Write("Введите число b: ");
            string userAnswerB = Console.ReadLine();

            double numberA, numberB;

            bool resultA = double.TryParse(userAnswerA, out numberA);
            bool resultB = double.TryParse(userAnswerB, out numberB);

            NumberFormatInfo numberformatinfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            try
            {
                if (!resultA)
                    numberA = double.Parse(userAnswerA, numberformatinfo);

                if (!resultB)
                    numberB = double.Parse(userAnswerB, numberformatinfo);

                double temp = numberA;
                numberA = numberB;
                numberB = temp;

                Console.WriteLine($"\na = {numberA}\nb = {numberB}\n");
            }

            catch
            {
                Console.WriteLine("\nНекорректный ввод данных");
            }
        }
    }
}
