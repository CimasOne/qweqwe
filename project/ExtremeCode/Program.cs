using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Sockets;
using ConsoleApp1;


namespace SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket();

            rocket.Header = new RocketHeader();
            rocket.Engine = new HatersEngine();
            Rocket rocket2 = new Rocket();

            rocket2.Header = new RocketHeader();
            rocket2.Engine = new rrrrrrrrrrrrt();

            int result = SpecialNasaMethod(rocket.Engine.Power, rocket.weight);
            Console.WriteLine("result" + result);

            if (result > 200)
            {
                rocket.Engine.Start();
            }
            else
            {
                Console.WriteLine("helphelphelp");
            }
            result = SpecialNasaMethod(rocket2.Engine.Power, rocket2.weight);
            Console.WriteLine("result" + result);

            if (result > 1500)
            {
                rocket2.Engine.Start();
            }
            else
            {
                Console.WriteLine("helphe312lphelp");
            }

            Console.ReadKey();
        }


        public static int SpecialNasaMethod(int power, int mass)
        {
            return (mass / power * 10) + 82;
        }
    }
}

/*Boozer Seva = new Boozer();
         Seva.Name = "Seva";
        Seva.Age = 22;
      Seva.Sex = "Man";
    Seva.SayHelloToFriend();
  Seva.drink();
   Console.WriteLine();
     int result;
    Animal[] animals = new Animal[4];
      Cat cat = new Cat();
    cat.Name = "qwe";


  Dog dog = new Dog();
       dog.Name = "qwe";

      Rat rat = new Rat();
          rat.Name = "zxc";
        Boozer boozer = new Boozer();
      boozer.Name = "vodka";
   animals[0] = cat;  
  animals[1] = dog;  
    animals[2] = rat;
  animals[3] = boozer;
     for(int i = 0;i <animals.Length; i++) 
   {
     animals[i].GetRoar(); 
      }
    Console.ReadLine();
     }
 }
  class Animal
 {
     public string Name { get; set; }
   public void GetRoar()
 {
        Console.WriteLine("AAOAOAOOAOAOAOAO");
  }
  }
 class Cat : Animal
  {
  }
 class Dog : Animal
 {
 }
 class Rat : Animal
 {
 }
 class Boozer : Animal


Boozer Seva = new Boozer();
          Seva.Name = "Seva";
        Seva.Age = 22;
      Seva.Sex = "Man";
    Seva.SayHelloToFriend();  Seva.drink();
Console.WriteLine();
 int result;

         
     Class1 class1 = new Class1();
     int a = 223;
   int b = 123;

 result = Class1.qwe(a, b);

 Console.WriteLine(result);


int rr = 100;
        int[] kk = new int[rr];
      for (int i = 0; i < rr; i++){
        kk[i] = i;
      Console.WriteLine("qwe" + i + "ss" + kk[i]);


for (int i = 0; i < 10; i++)
           {
             Console.WriteLine(i);
       }


Console.WriteLine("write your age:");
          string text = Console.ReadLine();
        int x = Convert.ToInt32(text);
      if (x ==3 && x < 10 || x > 10)
  {
      Console.WriteLine("good");
    Console.WriteLine("your better they");
        }         
        Console.ReadLine();


if (a > 16)
 {
     Console.WriteLine("to old");
 }
  else
   {
      Console.WriteLine("I'm on my way.");
  }
 Console.ReadLine();

 
 switch (a)
  {
    case 1:
      Console.WriteLine("number 1");
    break;
case 33:
  Console.WriteLine("number 33");
break;
         default:
           Console.WriteLine("write lheujt number ");
         break;
*/