using System;

namespace DzSimpleCode
{
    class HomeWork18
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
            return 0;
          
            int result = Sum(myArray, i + 1);
            return myArray[i]+ result;
                


        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, };

            int result = Sum(myArray);

        }
    }
}//Сумма элементов массива рекурсией