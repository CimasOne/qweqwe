using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SexShop.Products
{
    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
    }
}