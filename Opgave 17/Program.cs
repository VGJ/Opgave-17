using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grundlinje, højde;
            double grundlinje1, højde1, omkreds1, hypotenuse1;

            Console.Write("Indtast grundlinjen på Trekanten: ");

            grundlinje = Console.ReadLine();

            grundlinje1 = double.Parse(grundlinje);

            Console.Write("Indtast højden på Trekanten: ");

            højde = Console.ReadLine();

            højde1 = double.Parse(højde);

            hypotenuse1 = Math.Sqrt(Math.Pow(højde1,2) + Math.Pow(grundlinje1,2));

            omkreds1 = hypotenuse1 + grundlinje1 + højde1;

            Console.WriteLine("Omkredsen på Trekanten er {0:N2}", omkreds1);

            Console.ReadKey();
        }
    }
}
