﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SimpleCode_46_60lesson_;


namespace SimpleCode
{
    internal class Program
    {
<<<<<<< HEAD
        static Person GetPerson() 
          {
=======
     static void Main(string[] args)
        {
<<<<<<< HEAD
        static Person GetPerson()
=======

        }
    }
}

/*static Person GetPerson()
>>>>>>> 11df6c30050b043494a64dd449fcd0bb98f4d2fe
        {
>>>>>>> a39a498eb69b756b7de90ef2da2e907c49f4f9e4
            Person person=null;

            return person;
          }
        static void Main(string[] args)
        {
            Person person = GetPerson();

            string phoneNumber = person?.Contacts?.PhoneNumber ?? "0";

            Console.WriteLine(phoneNumber);
<<<<<<< HEAD
        }
             
    }
}


=======
        }*/
>>>>>>> 11df6c30050b043494a64dd449fcd0bb98f4d2fe

/*static int[ ] GetArray()
        {
            int[] myArray = null;

            return myArray;
        }
        static void Main(string[] args)
        {
            int[ ] myArray = GetArray();

            Console.WriteLine("Сумма элементов массива:" + (myArray?.Sum () ?? 0));
        }*/



/*string str = "test";

        str ??= string.Empty;

        int[] myArray = null;

        myArray ??= new int[0];

        Console.WriteLine(myArray.Length);
        Console.WriteLine(str.Length);

        //?? оператор обьеденение(проверка на null
        //?? оператор присваивания обьеденения (проверка на null,
        //но если значение null то присваивается другое значение*/