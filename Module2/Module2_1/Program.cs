using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N (число компаний, работающих в стране): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите M (налог, который взымает государство): ");
            int M = Convert.ToInt32(Console.ReadLine());

            int CompanyProfits = 500;

            Console.WriteLine("Суммарный налог, который получит государство: " + CompanyProfits * N / 100 * M);
        }
    }
}
