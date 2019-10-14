using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Figures
    {
        static double pi = 3.1415;
        static public int GetFigure()
        {
            Console.WriteLine("Выберите фигуру:\n");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг");

            Console.Write("\nОтвет: ");
            int FigureSelect = Convert.ToInt32(Console.ReadLine());

            return FigureSelect;
        }
        static public int GetFigureCharacteristic()
        {
            Console.WriteLine("\nВыберите численную характеристику:\n");
            Console.WriteLine("1. Периметр");
            Console.WriteLine("2. Площадь");

            Console.Write("\nОтвет: ");
            int FigureCharacteristicSelect = Convert.ToInt32(Console.ReadLine());

            return FigureCharacteristicSelect;
        }

        static public double TrianglePerimetr()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double c = Convert.ToInt32(Console.ReadLine());

            return a + b + c;
        }
        static public double TriangleSquare()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double c = Convert.ToInt32(Console.ReadLine());

            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static public double TrianglePeirmetr(double TriangleSquare)
        {
            Console.Write("\nВведите площадь круга вписанной в треугольник: "); 
            double CircleSquare = Convert.ToDouble(Console.ReadLine());

            return TriangleSquare / Math.Sqrt(CircleSquare / pi) * 2;
        }
        static public double TriangleSquare(double TrianglePerimetr)
        {
            Console.Write("\nВведите площадь круга вписанной в треугольник: ");
            double CircleSquare = Convert.ToDouble(Console.ReadLine());

            return Math.Sqrt(CircleSquare / pi) * TrianglePerimetr / 2;
        }
        static public double QuadranglePerimetr()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            return (a + b) * 2;
        }
        static public double QuadrangleSquare()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            return a * b;
        }
        static public double QuadranglePeirmetr(double square)
        {
            return Math.Sqrt(square) * 4;
        }
        static public double QuadrangleSquare(double perimetr)
        {
            return Math.Pow(perimetr / 4, 2);
        }

        static public double CirclePerimetr()
        {
            Console.Write("\nВведите радиус: ");
            int r = Convert.ToInt32(Console.ReadLine());

            return 2 * pi * r;
        }
        static public double CircleSquare()
        {
            Console.Write("\nВведите радиус: ");
            int r = Convert.ToInt32(Console.ReadLine());

            return pi * r * r;
        }
        static public double CirclePerimetr(double square)
        {
            return square / pi / 2;
        }
        static public double CircleSquare(double perimetr)
        {
            return Math.Sqrt(perimetr / pi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int FigureSelect = Figures.GetFigure();
            int FigureCharacteristicSelect = Figures.GetFigureCharacteristic();
            
            switch (FigureSelect)
            {
                case 1:
                    switch (FigureCharacteristicSelect)
                    {
                        case 1:
                            double TrianglePerimetr = Figures.TrianglePerimetr();

                            Console.WriteLine($"\nПериметр треугольника равен: {TrianglePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь квадрата: {Figures.QuadrangleSquare(TrianglePerimetr)}");
                            Console.WriteLine($"Площадь круга: {Figures.CircleSquare(TrianglePerimetr)}");
                            break;
                        case 2:
                            double TriangleSquare = Figures.TriangleSquare();

                            Console.WriteLine($"\nПлощадь треугольника равна: {TriangleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, периметры фигур равны:");
                            Console.WriteLine($"\nПериметр квадрата: {Figures.QuadranglePeirmetr(TriangleSquare)}");
                            Console.WriteLine($"Периметр круга: {Figures.CirclePerimetr(TriangleSquare)}");
                            break;
                    }
                    break;
                case 2:
                    switch (FigureCharacteristicSelect)
                    {
                        case 1:
                            double QuadranglePerimetr = Figures.QuadranglePerimetr();

                            Console.WriteLine($"\nПериметр четырехугольника равен: {QuadranglePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь треугольника: {Figures.TriangleSquare(QuadranglePerimetr)}");
                            Console.WriteLine($"Площадь круга: {Figures.CircleSquare(QuadranglePerimetr)}");
                            break;
                        case 2:
                            double QuadrangleSquare = Figures.QuadrangleSquare();

                            Console.WriteLine($"\nПлощадь четырехугольника равна: {QuadrangleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, периметры фигур равны:");
                            Console.WriteLine($"\nПериметр треугольника: {Figures.TriangleSquare(QuadrangleSquare)}");
                            Console.WriteLine($"Периметр круга: {Figures.CircleSquare(QuadrangleSquare)}");
                            break;
                    }
                    break;
                case 3:
                    switch (FigureCharacteristicSelect)
                    {
                        case 1:
                            double CirclePerimetr = Figures.CirclePerimetr();

                            Console.WriteLine($"\nПериметр круга равен: {CirclePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь треугольника: {Figures.TriangleSquare(CirclePerimetr)}");
                            Console.WriteLine($"Площадь квадрата: {Figures.QuadrangleSquare(CirclePerimetr)}");
                            break;
                        case 2:
                            double CircleSquare = Figures.CircleSquare();

                            Console.WriteLine($"\nПлощадь круга равна: {CircleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПериметр треугольника: {Figures.TrianglePeirmetr(CircleSquare)}");
                            Console.WriteLine($"Периметр квадрата: {Figures.QuadranglePeirmetr(CircleSquare)}");
                            break;
                    }
                    break;
            }

        }
    }
}
