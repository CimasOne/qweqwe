using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SimpleCode
{
    internal class HomeWork6

    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;
            uint evenNumberCount = 0;

            int correntValue = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            while (correntValue < limit)
            {
                if (correntValue % 2 == 0)
                {
                    oddNumberCount++;
                }
                else
                {
                    evenNumberCount++;
                }
                correntValue++;
            }

            Console.WriteLine("oddNumberCount = " + oddNumberCount);
            Console.WriteLine("evenNumberCount = " + evenNumberCount);
            Console.ReadLine();
        }
    }
}
// сумма и количество четных и не четных чисел