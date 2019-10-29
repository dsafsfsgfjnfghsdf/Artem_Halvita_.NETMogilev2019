using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_6
{
    class Program
    {
        static void IncreaseArrayBy5(ref int sizeArray, params int[] array)
        {
            for (int i = 0; i < sizeArray; i++)
                array[i] += 5;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[sizeArray];

            Random rand = new Random();

            Console.WriteLine("\nИсходный массив: ");

            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = rand.Next(0, 4);
                Console.Write(array[i] + " ");
            }

            IncreaseArrayBy5(ref sizeArray, array);

            Console.WriteLine("\nИзмененный массив: ");

            foreach (int i in array)
                Console.Write(i + " ");
        }
    }
}
