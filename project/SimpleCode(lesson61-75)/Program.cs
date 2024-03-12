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
    class Students
    {
        public Students(string lastName,DateTime birthday) 
        {
            
        }
        public Students(string lastName,string firstName, string middleName, DateTime birthday) 
        {
            _lastName = lastName;
            _birthday = birthday;
            _firstName = firstName;
            _middleName = middleName;
        }
        public Students(Students students)
        {
            _birthday = students._birthday;
            _firstName= students._firstName;
            _middleName= students._middleName;
            _lastName= students._lastName;
        }

        private string _lastName;
        private DateTime _birthday;
        private string _firstName;
        private string _middleName;

        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName}\n Фамилия :{_lastName}\n" +
                $"Отчество :{_middleName}\n День рождения: {_birthday}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students("qwe","qweqwe","wsde",new DateTime(2003,08,05));
            student.Print();
        }
       
    }
}
 /*
  * enum DayOfWeek: byte
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private static DayOfWeek GetNextDay(DayOfWeek day)
        {
           if (day < DayOfWeek.Sunday) 
            {
                return day + 1;
            }
           return DayOfWeek.Monday;
        }
       static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek);

            Console.WriteLine((DayOfWeek)3);

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
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

/*class Item
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
        }*/