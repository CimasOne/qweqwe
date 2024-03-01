using System;

namespace DzSimpleCode
{
    class HomeWork4
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
//проверка числа на четность