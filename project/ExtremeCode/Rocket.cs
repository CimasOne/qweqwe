using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rocket
    {
        public RocketHeader Header { get; set; }
        public IEngine Engine { get; set; }

        public int weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight;
            }


        }
    }

    class RocketHeader
    {
        public int Cosmonauts { get; private set; }
        public int MassShell { get; private set; }

        public RocketHeader()
        {
            Cosmonauts = 3;
            MassShell = 5000;
        }

        public int GetWeight()
        {
            return (Cosmonauts * 80) + MassShell;
        }

        public void SendMessage (string message)
        {
            Console.WriteLine("message" + message + "send");
        }

    }

    interface IEngine
    {
        void Start();
        void Stop();
        int Weight { get; }
        int Power { get; }
    }

    class HatersEngine : IEngine
    {
        public int Weight { get; }
        public int Power { get; }
        public string GetCop { get; }

        public HatersEngine()
        {
            Weight = 322;
            Power = 228;
            GetCop = "tutruturuturuturuturuturu";
        }

        public void Start()
        {
            Console.WriteLine("iziziziizizizizi");
        }
        public void Stop()
        {
            Console.WriteLine("qweqweqweqweqwe");
        }
    }
    class rrrrrrrrrrrrt : IEngine
    {
        public int Weight { get; }
        public int Power { get; }
        public string GetCop { get; }

        public rrrrrrrrrrrrt()
        {
            Weight = 232132;
            Power = 2218;
            GetCop = "tutruturutur3123123uturuturuturu";
        }

        public void Start()
        {
            Console.WriteLine("iziziziiz123123izizizi");
        }
        public void Stop()
        {
            Console.WriteLine("qweqwe123123qweqweqwe");
        }
    }

}