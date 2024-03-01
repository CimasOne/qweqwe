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
    internal class HomeWork8
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");

            int element = int.Parse(Console.ReadLine());

            int[] myArray = new int[element];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\n Введите элемент массива под индекосом  {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n Вывод массива:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
//заполнить массив с клавиатуры