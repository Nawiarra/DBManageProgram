using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProductsCore
{
    [Serializable]
    public class Furniture : Product
    {
        public string Manufacturer { get; private set; }

        public Furniture(string name, string manufacturer, float price)
        {
            Name = name;

            Manufacturer = manufacturer;

            Price = price;
        }
        public Furniture()
        {
        }

        public override string ToString()
        {
            return $"{Name} from {Manufacturer}, that cost {Price}";
        }

        public override int CompareTo(object obj)
        {
            Furniture furniture = obj as Furniture;

            if (furniture != null)
            {
                return this.Price.CompareTo(furniture.Price);
            }
            else
            {
                throw new Exception("can't compare");
                }
        }

        public override bool isFurniture()
        {
            return true;
        }

    }
}
