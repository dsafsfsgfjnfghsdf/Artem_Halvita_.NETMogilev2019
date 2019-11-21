using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
    class Array
    {
        static public int MaximumValue(ref int size, params int[] array)
        {
            int maximum = array[0];

            for (int i = 0; i < size; i++)
                if (maximum < array[i])
                    maximum = array[i];

            return maximum;
        }
        static public int MinimumValue(ref int size, params int[] array)
        {
            int minimum = array[0];

            for (int i = 0; i < size; i++)
                if (minimum > array[i])
                    minimum = array[i];

            return minimum;
        }
        static public int SumElements(ref int size, params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < size; i++)
                sum += array[i];

            return sum;
        }
        static public int DifferenceValues(ref int size, params int[] array)
        {
            return MaximumValue(ref size, array) - MinimumValue(ref size, array);
        }
        static public void IncreaseEvenAndReduceOddElements(ref int size, params int[] array)
        {
            int maximum = MaximumValue(ref size, array);
            int minimum = MinimumValue(ref size, array);

            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                    array[i] += maximum;

                else if (array[i] % 2 != 0)
                    array[i] -= minimum;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Введите количество элементов в массиве: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = rand.Next(1, 9);
            }

            Console.WriteLine("Исходный массив: ");

            foreach (int i in array)
                Console.Write(i + " ");

            Console.WriteLine("\n1. Поиск максимального элемента");
            Console.WriteLine("2. Поиск минимального элемента");
            Console.WriteLine("3. Сумма всех элементов");
            Console.WriteLine("4. Разница между максимальным и минимальным элементом");
            Console.WriteLine("5. Увеличить четные элементы на максимальный и уменьшить нечетные элемент на минимальный");

            Console.Write("\nВыберите дейстие: ");
            int SelectOption = Convert.ToInt32(Console.ReadLine());

            switch (SelectOption)
            {
                case 1:
                    Console.WriteLine(Array.MaximumValue(ref sizeArray, array));
                    break;
                case 2:
                    Console.WriteLine(Array.MinimumValue(ref sizeArray, array));
                    break;
                case 3:
                    Console.WriteLine(Array.SumElements(ref sizeArray, array));
                    break;
                case 4:
                    Console.WriteLine(Array.DifferenceValues(ref sizeArray, array));
                    break;
                case 5:
                    Array.IncreaseEvenAndReduceOddElements(ref sizeArray, array);

                    Console.WriteLine("\nИзмененный массив:");

                    foreach (int i in array)
                        Console.Write(i + " ");
                    break;
            }
        }
    }
}
