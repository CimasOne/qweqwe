using System;

namespace DzSimpleCode
{
    class HomeWork2
    {
        static int IndexOf (int[] array,int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 321, 421, 5435, 1231, 12, 24, };
            Console.WriteLine("Введите число кторое хотите найти:");
            int x = int.Parse(Console.ReadLine());

            int result = IndexOf(myArray, x);

            Console.WriteLine(result);

            //метод для поиска индекса элемента массива
        }
    }
}