using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SimpleCode.HomeWork7
{
    internal class HomeWork7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту :");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
//нарисовать треуголник в консоли