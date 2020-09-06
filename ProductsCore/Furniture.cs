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

        public override bool Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("furniture.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);

                return true;
            }
        }

        public Furniture Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("furniture.dat", FileMode.OpenOrCreate))
            {
                Furniture newFurniture = (Furniture)formatter.Deserialize(fs);

                return newFurniture;
            }

        }
    }
}
