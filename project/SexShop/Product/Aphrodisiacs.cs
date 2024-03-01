using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SexShop.Products
{
    class Aphrodisiacs : Product
    {
        public string Composition { get; set; }

        public Aphrodisiacs(string name, int price, string manufacturer, string composition)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Composition = composition;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }

    }
}