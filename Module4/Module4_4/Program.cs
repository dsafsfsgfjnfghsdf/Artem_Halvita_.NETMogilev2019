using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_4
{
    class Reference
    {
        public static (int, int, int) IncreaceBy10(int firstNumber, int secondNumber, int thirdNumber)
        {
            firstNumber += 10;
            secondNumber += 10;
            thirdNumber += 10;

            (int, int, int) numbers = (firstNumber, secondNumber, thirdNumber);

            return numbers;
        }
        public static (double, double) Circumference(int radius)
        {

            double circumference = 2 * Math.PI * radius;
            double circleSquare = 2 * Math.PI * radius * radius;

            (double, double) circleInfo = (circumference, circleSquare);

            return circleInfo;
        }
        public static (int, int, int) GetInfoArray(int sizeArray, int[] array)
        {
            int maximum = array[0];
            int minimum = array[0];
            int sum = 0;

            for (int i = 0; i < sizeArray; i++)
            {
                if (maximum < array[i])
                    maximum = array[i];

                if (minimum > array[i])
                    minimum = array[i];

                sum += array[i];
            }

            (int, int, int) arrayInfo = (maximum, minimum, sum);

            return arrayInfo;
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
                        
                        var (increaseBy10FirstNumber, increaseBy10SecondNumber, increaseBy10ThirdNumber) = Reference.IncreaceBy10(firstNumber, secondNumber, thirdNumber);

                        Console.WriteLine($"Числа изменены на: {increaseBy10FirstNumber} {increaseBy10SecondNumber} {increaseBy10ThirdNumber}");
                        break;

                    case 2:
                        Console.Write("Введите радиус окружности: ");
                        int radius = Convert.ToInt32(Console.ReadLine());

                        var (circurefence, circleSquare) = Reference.Circumference(radius);    

                        Console.WriteLine($"При радиусе {radius}:\nДлина окружности - {circurefence}, площадь - {circleSquare}");
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

                        var (maximum, minimum, sum) = Reference.GetInfoArray(sizeArray, array);

                        Console.WriteLine($"\nМаксимальный элемент: {maximum}" +
                            $"\nМинимальный элемент: {minimum}" +
                            $"\nСумма всех жлементов: {sum}");
                        break;
                }
            }   
        }
    }
}
