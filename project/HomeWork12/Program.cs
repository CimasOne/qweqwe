using System;

namespace DzSimpleCode
{
    class HomeWork2
    {
         static void qwe(string a,uint b)
        {
            for (int i = 0;i < b; i++)
            {
                Console.Write(a);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");

            string a = Console.ReadLine();

            Console.WriteLine("Введите количество:");

            uint b = uint.Parse(Console.ReadLine());

            qwe(a,b);
            //метод который выводи на экран строк из которых состоит строка и кол-во вводятся пользователем
        }
    }
}