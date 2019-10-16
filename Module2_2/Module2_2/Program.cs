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
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if ((N % 2 == 0) && (N >= 18))
                Console.WriteLine("Поздравляю с 18-и летием");

            else if ((N % 2 != 0) && (N > 13) && (N < 18))
                Console.WriteLine("Поздравляю с переходом в старшую школу");
        }
    }
}
