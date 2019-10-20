using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[sizeArray, sizeArray];

            int count = 1;
            int bijection = sizeArray / 2 + 1;

            for (int i = 1; i <= bijection; i++)
            {
                for (int j = i - 1; j < sizeArray - i + 1; j++)
                    array[i - 1, j] = count++;

                for (int j = i; j < sizeArray - i + 1; j++)
                    array[j, sizeArray - i] = count++;

                for (int j = sizeArray - i - 1; j >= i - 1; --j)
                    array[sizeArray - i, j] = count++;

                for (int j = sizeArray - i - 1; j >= i; j--)
                    array[j, i - 1] = count++;
            }

            Console.WriteLine("\nПреобразованный массив:");

            for (int n = 0; n < sizeArray; n++)
            {
                for (int m = 0; m < sizeArray; m++)
                {
                    Console.Write("{0, 3}", array[n, m]);
                }

                Console.WriteLine();
            }
        }
    }
}
