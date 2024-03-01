using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace SimpleCode
{
    internal class HomeWork10
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            Console.WriteLine("\n Вывод массива:");

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}