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
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n];

            int i = 1;
            int j;
            int k;
            int p = n / 2;

            for (k = 1; k <= p; k++)
            {
                for (j = k - 1; j < n - k + 1; j++)
                    arr[k - 1, j] = i++;

                for (j = k; j < n - k + 1; j++)
                    arr[j, n - k] = i++;

                for (j = n - k - 1; j >= k - 1; --j)
                    arr[n - k, j] = i++;

                for (j = n - k - 1; j >= k; j--)
                    arr[j, k - 1] = i++;
            }

            Console.WriteLine("\nПреобразованный массив:");

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write("{0, 3}", arr[a, b]);
                }

                Console.WriteLine();
            }
        }
    }
}
