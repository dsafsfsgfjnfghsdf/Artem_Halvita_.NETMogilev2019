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
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите M (налог, который взымает государство): ");
            int m = Convert.ToInt32(Console.ReadLine());

            int companyProfits = 500;

            Console.WriteLine("Суммарный налог, который получит государство: " + companyProfits * n / 100 * m);
        }
    }
}
