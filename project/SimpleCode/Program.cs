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
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
            /*int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            int[] myArray2 = myArray[1..4];//диапозон от 1 до 4 индекса(число 2 точки число)

            Index myIndex = new Index(3,true);

            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            Console.WriteLine(myArray[^1]);//последний индекс массива
           /*int[] myArray = { 1231, 2321, 3443, 423, 1235, };

            int result = (myArray.Where(i => i % 2 == 0).Sum());//проверка на четность и сумма этих чисел

            int resuit1 = Array.FindIndex(myArray, i => i == 1235);//поиск одного индекса

            Array.Sort(myArray);//сортировка он меньшего к большему

            Array.Reverse(myArray);//поворачивает массив наоборот

            Array.Find(myArray, i => i < 1500);//поиск одного числа с начала

           /* for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);  
            }
            Console.ReadLine();*/