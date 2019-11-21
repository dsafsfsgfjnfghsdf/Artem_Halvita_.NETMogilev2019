using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_2
{
    class Addition
    {
        public static int Add(int first, int second, int third)
        {
            return first + second + third;
        }
        public static int Add(int first, int second)
        {
            return first + second;
        }
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static string Add(string first, string second)
        {
            return first + second;
        }
        public static int[] Add(ref int[] arrayA, ref int[] arrayB)
        {
            int sizeArrayC = arrayA.Length + arrayB.Length;
            int[] arrayC = new int[sizeArrayC];

            int i = 0;
            while (i < arrayA.Length)
            {
                arrayC[i] = arrayA[i];
                i++;
            }

            int j = 0;
            while (j < arrayB.Length)
            {
                arrayC[i] = arrayB[j];
                j++;
                i++;
            }

            return arrayC;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите метод:");
            Console.WriteLine("1. Сложение трех целочисленных чисел");
            Console.WriteLine("2. Сложение двух целочисленных чисел");
            Console.WriteLine("3. Сложение двух вещественных чисел");
            Console.WriteLine("4. Сложение двух строк");
            Console.WriteLine("5. Сложение двух массивов");
            Console.Write("\nОтвет: ");

            int answerUser = Convert.ToInt32(Console.ReadLine());

            switch (answerUser)
            {
                case 1:
                    Console.Write("\nВведите первое число: ");
                    int firstNumberCase1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int secondNumberCase1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    int thirdNumberCase1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nСумма трех целочисленных чивел равна: {Addition.Add(firstNumberCase1, secondNumberCase1, thirdNumberCase1)}");
                    break;
                case 2:
                    Console.Write("\nВведите первое число: ");
                    int firstNumberCase2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int secondNumberCase2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nСумма двух целочисленных чивел равна: {Addition.Add(firstNumberCase2, secondNumberCase2)}");
                    break;
                case 3:
                    Console.Write("\nВведите первое число: ");
                    double firstNumberCase3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double secondNumberCase3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nСумма двух вещественный чисел равна: {Addition.Add(firstNumberCase3,secondNumberCase3)}");
                    break;
                case 4:
                    Console.Write("\nВведите первую строку: ");
                    string firstStringCase4 = Console.ReadLine();

                    Console.Write("Введите вторую строку: ");
                    string secondStringCase4 = Console.ReadLine();

                    Console.WriteLine($"\nКонкатенация двух сток: {Addition.Add(firstStringCase4, secondStringCase4)}");
                    break;
                case 5:
                    Console.Write("\nВведите размерность массива A: ");
                    int sizeArrayA = Convert.ToInt32(Console.ReadLine());
                    int[] arrayA = new int[sizeArrayA];

                    Console.Write("Введите размерность массива B: ");
                    int sizeArrayB = Convert.ToInt32(Console.ReadLine());
                    int[] arrayB = new int[sizeArrayB];

                    Random rand = new Random();

                    for(int i = 0; i < sizeArrayA; i++)
                        arrayA[i] = rand.Next(0, 9);

                    for (int i = 0; i < sizeArrayB; i++)
                        arrayB[i] = rand.Next(0, 9);

                    Console.WriteLine($"\nСложение массивов равно:");

                    for (int i = 0; i < sizeArrayA + sizeArrayB; i++)
                        Console.Write(Addition.Add(ref arrayA, ref arrayB)[i] + " ");
                    break;
            }

                
        }
    }
}
