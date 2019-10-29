using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_3
{
    class Reference
    {
        public static void IncreaceBy10(ref int first, ref int second, ref int third)
        {
            first += 10;
            second += 10;
            third += 10;
        }
        public static void Circumference(ref int radius, out double circumference, out double circleSquare)
        {
            circumference = 2 * Math.PI * radius;
            circleSquare = 2 * Math.PI * radius * radius;
        }
        public static void GetInfoArray(out int maximum, out int minimum, out int sum, ref int sizeArray, params int[] array)
        {
            maximum = array[0];
            minimum = array[0];
            sum = 0;

            for (int i = 0; i < sizeArray; i++)
            {
                if (maximum < array[i])
                    maximum = array[i];

                if (minimum > array[i])
                    minimum = array[i];

                sum += array[i];
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Выберите метод:" +
                    "\n1. Увеливение трех переменных на 10" +
                    "\n2. Нахождение длины окружности и площади круга" +
                    "\n3. Нахождение минимального, максимального и суммы элементов массива" +
                    "\n\nОтвет: ");
                int SelectUser = Convert.ToInt32(Console.ReadLine());

                switch (SelectUser)
                {
                    case 1:
                        Console.Write("\nВведите первое число: ");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        int thirdNumber = Convert.ToInt32(Console.ReadLine());

                        Reference.IncreaceBy10(ref firstNumber, ref secondNumber, ref thirdNumber);

                        Console.WriteLine($"Числа изменены на: {firstNumber} {secondNumber} {thirdNumber}");
                        break;

                    case 2:
                        Console.Write("Введите радиус окружности: ");
                        int radius = Convert.ToInt32(Console.ReadLine());

                        double circurefence, circleSquare;

                        Reference.Circumference(ref radius, out circurefence, out circleSquare);

                        Console.WriteLine($"Длина окружности - {circurefence}, площадь - {circleSquare}");
                        break;

                    case 3:
                        Console.Write("\nВведите размерность массива: ");
                        int sizeArray = Convert.ToInt32(Console.ReadLine());

                        int[] array = new int[sizeArray];

                        Random rand = new Random();

                        Console.WriteLine("\nИсходный массив: ");

                        for (int i = 0; i < sizeArray; i++)
                        {
                            array[i] = rand.Next(0, 9);
                            Console.Write(array[i] + " ");
                        }

                        int maximum;
                        int minimum;
                        int sum;

                        Reference.GetInfoArray(out maximum, out minimum, out sum, ref sizeArray, array);

                        Console.WriteLine($"Максимальный элемент: {maximum}\n" +
                            $"Минимальный элемент: {minimum}\n" +
                            $"Сумма всех жлементов: {sum}");
                        break;
                }
            }
        }
    }
}