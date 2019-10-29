using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_5
{
    class Program
    {
        enum Operation
        {
            Addiction,
            Substraction,
            Multiplication,
            Division
        }
        static double MathOperation(double firstNumber, double secondNumber, Operation operation)
        {
            switch (operation)
            {
                case Operation.Addiction:
                    return firstNumber + secondNumber;
                case Operation.Substraction:
                    return firstNumber - secondNumber;
                case Operation.Multiplication:
                    return firstNumber * secondNumber;
                case Operation.Division:
                    return firstNumber / secondNumber;
                default:
                    return -1;
            }
        }
        static double DaysOfMonth(double month)
        {
            return 28 + (month + Math.Floor(month / 8)) % 2 + 2 % month + 2 * Math.Floor(1 / month);
        }
        static void Main(string[] args)
        {
            Console.Write("Часть А.\n" +
                "Выберите действие:" +
                "\n1. Сложение" +
                "\n2. Вычитание" +
                "\n3. Умножение" +
                "\n4. Деление" +
                "\n\nОтвет: ");
            int selectOperation = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            switch (selectOperation)
            {
                case 1:
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Addiction)}");
                    break;
                case 2:
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Substraction)}");
                    break;
                case 3:
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Multiplication)}");
                    break;
                case 4:
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {MathOperation(firstNumber, secondNumber, Operation.Division)}");
                    break;
            }

            Console.Write("\nЧасть B.\n" +
                "Введите число месяца:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Количество дней в месяце: {DaysOfMonth(month)}");
        }
    }
}
