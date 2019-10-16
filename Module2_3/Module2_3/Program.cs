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
            string UserAnswerA = Console.ReadLine();

            Console.Write("Введите число b: ");
            string UserAnswerB = Console.ReadLine();

            double a, b;

            bool ResultA = double.TryParse(UserAnswerA, out a);
            bool ResultB = double.TryParse(UserAnswerB, out b);

            NumberFormatInfo numberformatinfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            try
            {
                if (!ResultA)
                    a = double.Parse(UserAnswerA, numberformatinfo);

                if (!ResultB)
                    b = double.Parse(UserAnswerB, numberformatinfo);

                double temp = a;
                a = b;
                b = temp;

                Console.WriteLine($"\na = {a}\nb = {b}\n");
            }

            catch
            {
                Console.WriteLine("\nНекорректный ввод данных");
            }
        }
    }
}
