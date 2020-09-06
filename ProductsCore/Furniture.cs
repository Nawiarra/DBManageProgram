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
        public static bool operator >(Furniture furniture1, Furniture furniture2)
        {
            return furniture1.Price > furniture2.Price;
        }
        public static bool operator <(Furniture furniture1, Furniture furniture2)
        {
            return furniture1.Price < furniture2.Price;
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

        public static List<Furniture> Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            List<Furniture> furnitureTable = new List<Furniture>();

            using (FileStream fs = new FileStream("furniture.dat", FileMode.OpenOrCreate))
            {
                furnitureTable.Add((Furniture)formatter.Deserialize(fs));

                return furnitureTable;
            }

        }
    }
}
