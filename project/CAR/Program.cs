using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Sockets;
using CAR;


namespace SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());
            car.Drive();
            car.StartEngine(); 
            car.Drive();
            car.StartEngine();
            car.Drive();
            
           
        }
    }
}