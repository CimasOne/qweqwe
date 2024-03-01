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
            string str = "2213";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Good " + a);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine(); 
        }
    }
}

/*string str = "5.6";

           NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
           {
               NumberDecimalSeparator = ".";
           }

           double a = double.Parse(str,numberFormatInfo);*/
/*string srt;

           int a, b;
           Console.WriteLine("Number 1");

           str = Console.ReadLine();

           a = Convert.ToInt32(str);

           Console.WriteLine("Number 2");

           str = Console.ReadLine();

           b = Convert.ToInt32(str);

           int result = a + b;

           Console.WriteLine("Summa =" + result);*/
/*string data;

            data = Console.ReadLine();

            Console.WriteLine("Hello" + data + "!!!");*/
/*  while (true)
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
      catch(Exception)
      {
          Console.WriteLine("unlucky");
              Console.ReadLine();
          continue;
      }

      Console.WriteLine("+.-.*./");
          s = Console.ReadLine();

      switch(s)
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
      }*/
