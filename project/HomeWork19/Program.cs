using System;

namespace DzSimpleCode
{
    class HomeWork19
    {
        static int Foo(int value)
        {
            if (value < 10) 
                return value;

            int digit = value % 10;

            int Nextvalue = value / 10;

            return digit + Foo(Nextvalue);
        }
        static void Main(string[] args)
        {
            int myValue = 562;

            Console.WriteLine(myValue % 10);

        }
    }
}//Как найти сумму цифр числа через (Рекурсия)