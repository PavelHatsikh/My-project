using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_realization_5_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Describe class Receipt");
            Console.WriteLine();

            Receipt rec = new Receipt();
            rec.Input();

            Console.WriteLine();
            rec.Display();

            Console.ReadKey();
        }
    }
}