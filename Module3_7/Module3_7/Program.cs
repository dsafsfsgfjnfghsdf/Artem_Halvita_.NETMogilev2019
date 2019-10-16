using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
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
                array[i] = random.Next(0, 9);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\nЭлементы числового массива, которые больше, чем элементы, стоящие перед ними:");

            for (int i = 0; i < quantity - 1; i++)
            {
                if (array[i] < array[i + 1])
                    Console.Write($"{array[i + 1]} ");
            }
        }
    }
}
