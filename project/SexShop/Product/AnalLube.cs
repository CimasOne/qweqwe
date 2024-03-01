using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop.Products
{
    class AnalLube : Product
    {
        public AnalLube(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}

