using System;

namespace DzSimpleCode
{
    class HomeWork5
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string s;


                try
                {
                    Console.WriteLine("number 1");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("number 2");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("unlucky");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("+.-.*./");
                s = Console.ReadLine();

                switch (s)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        if (b == 0)
                            Console.WriteLine("Error");
                        else
                            Console.WriteLine(a / b);
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
//калькулятор