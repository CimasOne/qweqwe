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
    internal class Person
    {
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }
        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }
        static void Print(Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }
        static void Main(string[] args)
        {
            Item item = InitItem();

           // Print(item);
            
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}

/*static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(123, 321, 32, 213, 44, 12, 445);
            Console.WriteLine(result);
        }*/