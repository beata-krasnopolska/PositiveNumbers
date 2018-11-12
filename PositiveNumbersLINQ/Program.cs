using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNumbersLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program uses multiple where conditions to find positive numbers within a range of 1 to 10 from the given table of numbers");
            int[] table = new int[10] { -5, -12, 0, 3, 5, -2, 14, 23, -18, 55 };

            var positive = from numbers in table
                           where numbers > 0
                           where numbers < 11
                           select numbers;

            foreach (var numbers in positive)
            {
                Console.WriteLine("{0}", numbers);
            }
            Console.ReadKey();
        }
    }
}
