using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductsCore;

namespace WorkWithDBCore
{
    public class DB
    {
        private static List<Furniture> furnitureTable = new List<Furniture>();

        private static List<RawMaterial> rawMaterialTable = new List<RawMaterial>();

        public static void AddFurniture(Furniture furniture)
        {
            furnitureTable.Add(furniture);
        }

        public static void AddRawMaterial(RawMaterial rawMaterial)
        {
            rawMaterialTable.Add(rawMaterial);
        }

        public static void DeleteFurniture(Furniture furniture)
        {
            furnitureTable.Remove(furniture);
        }

        public static void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            rawMaterialTable.Remove(rawMaterial);
        }

        public static void SerializeFurnitureDB()
        {
            foreach (Furniture furniture in furnitureTable)
            {
                furniture.Serialize();
            }
        }
        public static void DeserializeFurnitureDB()
        {
            furnitureTable = Furniture.Deserialize();
        }

        public static void SerializeRawMaterialDB()
        {
            foreach (RawMaterial rawMaterial in rawMaterialTable)
            {
                rawMaterial.Serialize();
            }
        }

        public static void DeserializeRawMaterialDB()
        {
            rawMaterialTable = RawMaterial.Deserialize();
        }
    }
}
