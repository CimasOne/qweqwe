using System;

namespace DzSimpleCode
{
    class HomeWork14
    {
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[]newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, };

            Resize(ref myArray,10);
        }
    }
}
//ИЗМЕНИТЬ РАЗМЕР МАССИВА