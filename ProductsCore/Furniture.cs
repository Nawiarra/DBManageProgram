using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCore
{
    public class Furniture : Product
    {
        public string Manufacturer { get; private set; }

        public Furniture(string name, string manufacturer, decimal price)
        {
            Name = name;

            Manufacturer = manufacturer;

            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} from {Manufacturer}, that cost {Price}";
        }

        public override bool isFurniture()
        {
            return true;
        }
    }
}
