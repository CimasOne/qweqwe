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
    internal class HomeWork11
    {
        static void Main(string[] args)
        {
            int[] myArray = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            Console.WriteLine("\n Вывод массива:");

            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);
            Console.ReadLine();
        }
    }
}
//найдите наимелньший элемент массива