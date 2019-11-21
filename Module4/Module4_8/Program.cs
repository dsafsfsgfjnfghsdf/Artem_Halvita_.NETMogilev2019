using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_8
{
    class Program
    {
        public static float GetFunctionX(float x)
        {
            return x - 4;
        }
        public static float GetBisection(float x1, float x2, double accuracy)
        {
            float x = (x1 + x2) / 2;
            if(Math.Abs(GetFunctionX(x)) > accuracy)
            {
                if (GetFunctionX(x) > 0)
                {
                    x2 = x;
                    return GetBisection(x1, x2, accuracy);
                }
                else
                {
                    x1 = x;
                    return GetBisection(x1, x2, accuracy);
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите точность числа: ");
            double accuracy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nЧисло при x - 4 равно: {GetBisection(x1, x2, accuracy)}");
        }
    }
}
