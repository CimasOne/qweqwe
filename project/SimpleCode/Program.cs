using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[12];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}



/*int[,] myArray = new int[2, 3];

int height = myArray.GetLength(0);
int width = myArray.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        myArray[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}

//заполнение массива в ручную + таблица*/




/*int[,] myArray = new int[5,5];

            Random random = new Random();

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t" );
                }
                Console.WriteLine();
            }

            //заполнение массива в таблице+рандом*/



/*int[,] myArray =
{
    { 1,2,3,4,5,},
    { 12,123,123,53,6},
    { 435,234,1,23,5}
};

int height = myArray.GetLength(0);
int width = myArray.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(myArray[i,j] + "\t" );
    }
}

Console.WriteLine();*/




/* int[,] myArray =
{
    { 1,2,3,4,5,},
    { 12,123,123,53,6},
    { 435,234,1,23,5}
};//тоже самое
myArray = new int[3, 5]
{
    { 1,2,3,4,5,}, 
    { 12,123,123,53,6},
    { 435,234,1,23,5}
}; 
foreach (var i in myArray)
{
    Console.WriteLine(i + " ");
}  */



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

Array.Find(myArray, i => i < 1500);//поиск одного числа с начала*/



/* for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);  
}
Console.ReadLine();*/