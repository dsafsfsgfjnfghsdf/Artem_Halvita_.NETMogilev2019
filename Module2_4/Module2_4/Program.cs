using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Figures
    {
        public static int GetFigure()
        {
            Console.WriteLine("Выберите фигуру:\n");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг");

            Console.Write("\nОтвет: ");
            int figureSelect = Convert.ToInt32(Console.ReadLine());

            return figureSelect;
        }
        public static int GetFigureCharacteristic()
        {
            Console.WriteLine("\nВыберите численную характеристику:\n");
            Console.WriteLine("1. Периметр");
            Console.WriteLine("2. Площадь");

            Console.Write("\nОтвет: ");
            int figureCharacteristicSelect = Convert.ToInt32(Console.ReadLine());

            return figureCharacteristicSelect;
        }

        public static double TrianglePerimetr()
        {
            Console.Write("\nВведите сторону a: ");
            double lineA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double lineB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double lineC = Convert.ToInt32(Console.ReadLine());

            return lineA + lineB + lineC;
        }
        public static double TriangleSquare()
        {
            Console.Write("\nВведите сторону a: ");
            double lineA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double lineB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double lineC = Convert.ToInt32(Console.ReadLine());

            double halfPerimetr = (lineA + lineB + lineC) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - lineA) * (halfPerimetr - lineB) * (halfPerimetr - lineC));
        }

        public static double TrianglePeirmetr(double triangleSquare)
        {
            Console.Write("\nВведите площадь круга вписанной в треугольник: ");
            double circleSquare = Convert.ToDouble(Console.ReadLine());

            return triangleSquare / Math.Sqrt(circleSquare / Math.PI) * 2;
        }
        public static double TriangleSquare(double trianglePerimetr)
        {
            Console.Write("\nВведите площадь круга вписанной в треугольник: ");
            double circleSquare = Convert.ToDouble(Console.ReadLine());

            return Math.Sqrt(circleSquare / Math.PI) * trianglePerimetr / 2;
        }
        public static double QuadranglePerimetr()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            return (a + b) * 2;
        }
        public static double QuadrangleSquare()
        {
            Console.Write("\nВведите сторону a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            return a * b;
        }
        public static double QuadranglePeirmetr(double square)
        {
            return Math.Sqrt(square) * 4;
        }
        public static double QuadrangleSquare(double perimetr)
        {
            return Math.Pow(perimetr / 4, 2);
        }

        public static double CirclePerimetr()
        {
            Console.Write("\nВведите радиус: ");
            int r = Convert.ToInt32(Console.ReadLine());

            return 2 * Math.PI * r;
        }
        public static double CircleSquare()
        {
            Console.Write("\nВведите радиус: ");
            int r = Convert.ToInt32(Console.ReadLine());

            return Math.PI * r * r;
        }
        public static double CirclePerimetr(double square)
        {
            return square / Math.PI / 2;
        }
        public static double CircleSquare(double perimetr)
        {
            return Math.Sqrt(perimetr / Math.PI);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int figureSelect = Figures.GetFigure();
            int figureCharacteristicSelect = Figures.GetFigureCharacteristic();

            switch (figureSelect)
            {
                case 1:
                    switch (figureCharacteristicSelect)
                    {
                        case 1:
                            double trianglePerimetr = Figures.TrianglePerimetr();

                            Console.WriteLine($"\nПериметр треугольника равен: {trianglePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь квадрата: {Figures.QuadrangleSquare(trianglePerimetr)}");
                            Console.WriteLine($"Площадь круга: {Figures.CircleSquare(trianglePerimetr)}");
                            break;
                        case 2:
                            double triangleSquare = Figures.TriangleSquare();

                            Console.WriteLine($"\nПлощадь треугольника равна: {triangleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, периметры фигур равны:");
                            Console.WriteLine($"\nПериметр квадрата: {Figures.QuadranglePeirmetr(triangleSquare)}");
                            Console.WriteLine($"Периметр круга: {Figures.CirclePerimetr(triangleSquare)}");
                            break;
                    }
                    break;
                case 2:
                    switch (figureCharacteristicSelect)
                    {
                        case 1:
                            double quadranglePerimetr = Figures.QuadranglePerimetr();

                            Console.WriteLine($"\nПериметр четырехугольника равен: {quadranglePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь треугольника: {Figures.TriangleSquare(quadranglePerimetr)}");
                            Console.WriteLine($"Площадь круга: {Figures.CircleSquare(quadranglePerimetr)}");
                            break;
                        case 2:
                            double quadrangleSquare = Figures.QuadrangleSquare();

                            Console.WriteLine($"\nПлощадь четырехугольника равна: {quadrangleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, периметры фигур равны:");
                            Console.WriteLine($"\nПериметр треугольника: {Figures.TriangleSquare(quadrangleSquare)}");
                            Console.WriteLine($"Периметр круга: {Figures.CircleSquare(quadrangleSquare)}");
                            break;
                    }
                    break;
                case 3:
                    switch (figureCharacteristicSelect)
                    {
                        case 1:
                            double circlePerimetr = Figures.CirclePerimetr();

                            Console.WriteLine($"\nПериметр круга равен: {circlePerimetr}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПлощадь треугольника: {Figures.TriangleSquare(circlePerimetr)}");
                            Console.WriteLine($"Площадь квадрата: {Figures.QuadrangleSquare(circlePerimetr)}");
                            break;
                        case 2:
                            double circleSquare = Figures.CircleSquare();

                            Console.WriteLine($"\nПлощадь круга равна: {circleSquare}");
                            Console.WriteLine("\nНа основании полученных данных, площади фигур равны:");
                            Console.WriteLine($"\nПериметр треугольника: {Figures.TrianglePeirmetr(circleSquare)}");
                            Console.WriteLine($"Периметр квадрата: {Figures.QuadranglePeirmetr(circleSquare)}");
                            break;
                    }
                    break;
            }
        }
    }
}
