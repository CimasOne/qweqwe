using System;
using System.Diagnostics.Metrics;

namespace DzSimpleCode
{
    class HomeWork3
    {
        static void Main(string[] args)
        {
            double UsdToRub = 89.67;
            double UsdToEur = 0.923317;
            double USD;

            Console.WriteLine("Enter the amount in usd");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD in RUB=" + USD * UsdToRub);

            Console.WriteLine(USD + " USD in EuR=" + USD * UsdToEur);
        }
    }
}
//перевод usd в рубли и евро