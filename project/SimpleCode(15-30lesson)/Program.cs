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
            Console.Write("Введите высоту :");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину :");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();

            }
        }
    }
}

/*int InputData = int.Parse(Console.ReadLine());

int outputDate = InputData < 0 ? 0 : InputData;
/* for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("цикл номер 1 итерацие № "+i);

    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine("\t цикл номер 2 итерацие № " + j);
    }
}*/

/*int i = 0;
int j = 3;

for (; i < 6 && j < 12; i++ ,j++)
{
    Console.WriteLine("for1 " + i);
    Console.WriteLine("j" +  j);
}
for (; i <17; i++) 
{
    Console.WriteLine("for2 " + i);
}*/
/*for (int i = 0, j = 5 ; i < 5; i++ , j--)
{
    Console.WriteLine(i);
    Console.WriteLine(j);
}

Console.ReadLine();*/

/*int fanSpeed = 3000;

    bool isInfected  = true;

    bool isInfected2 = fanSpeed >= 0;

    if (isInfected && isInfected2)
    {
        Console.WriteLine("true");
    }
    else 
    { 
        Console.WriteLine("false");
    }*/