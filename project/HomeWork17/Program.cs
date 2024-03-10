using System;

namespace DzSimpleCode
{
    class HomeWork17
    { 
        static void PrinArray(int[] myArray,int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrinArray(myArray, i + 1);
            }
                
                
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, };

            PrinArray(myArray);

        }
    }
}//Рекурсивный вывод массива