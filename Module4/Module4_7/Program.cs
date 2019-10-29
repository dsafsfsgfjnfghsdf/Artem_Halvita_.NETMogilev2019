using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_7
{
    class Program
    {
        static void SortArray(int direction, ref int sizeArray, params int[] array)
        {
            if (direction == 1)
            {
                for (int i = 0; i < sizeArray - 1; i++)
                {
                    for (int j = i + 1; j < sizeArray; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            if (direction == 2)
            {
                for (int i = 0; i < sizeArray - 1; i++)
                {
                    for (int j = i + 1; j < sizeArray; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
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
                array[i] = rand.Next(0, 9);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\nВыберите сортировку:" +
                "\n1. По возрастанию" +
                "\n2. По убыванию" +
                "\nОтвет: ");
            int selectSort = Convert.ToInt32(Console.ReadLine());

            SortArray(selectSort, ref sizeArray, array);

            Console.WriteLine("\nОтсортированный массив: ");

            foreach (int i in array)
                Console.Write(i + " ");
        }
    }
}
