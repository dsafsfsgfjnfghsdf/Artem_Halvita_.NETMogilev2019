using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if ((age % 2 == 0) && (age >= 18))
                Console.WriteLine("Поздравляю с 18-и летием");

            else if ((age % 2 != 0) && (age > 13) && (age < 18))
                Console.WriteLine("Поздравляю с переходом в старшую школу");
        }
    }
}
