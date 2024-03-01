/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Human
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }

        public Human(){}

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name , int age) : this(name)
        {
            Age = age;
        }

       
        public void SayHelloToFriend()
        {
            Console.WriteLine("Hey friend");
        }
    }
    class Boozer : Human
    { 
        public string DrugType { get; set; }

        public Boozer(string name,int age, string DrugType) : base(name, age)
        {
            DrugType = DrugType;
            Console.ReadLine();
        }
       
        
       
    }
}
*/