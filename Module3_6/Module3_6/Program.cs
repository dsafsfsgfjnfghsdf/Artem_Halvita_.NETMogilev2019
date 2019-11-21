using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введте количество элементов массива: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[quantity];

            Random random = new Random();

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < quantity; i++)
            {
                array[i] = random.Next(-5, 5);
                Console.Write("{0, 3}", $"{array[i]}");
            }

            Console.WriteLine("\nПреобразованный массив:");

            for (int i = 0; i < quantity; i++)
            {
                array[i] *= -1;
                Console.Write("{0, 3}", $"{array[i]}");
            }

            Console.WriteLine();
        }
    }
}
