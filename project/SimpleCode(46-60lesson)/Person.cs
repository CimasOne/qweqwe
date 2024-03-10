using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCode_46_60lesson_

{
    internal class Person
    {
        public int FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()

        {
            return "okey";
        }

        public string GetPhoneNumber()
        {
            return "qweqwe";
        }
    }
}
  