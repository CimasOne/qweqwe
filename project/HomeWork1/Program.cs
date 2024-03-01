using System;

namespace DzSimpleCode
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Number 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine(result);


        }
    }
}
//средние арифмитеческое чисел