using System;

namespace DzSimpleCode
{
    class HomeWork16
    {
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        static void AddFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }
        static void AddLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length -1 );
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, };

            RemoveAt(ref myArray, 2);
        }
    }
}
//КАК УДАЛИТЬ ЭЛЕМЕНТ ИЗ МАССИВА