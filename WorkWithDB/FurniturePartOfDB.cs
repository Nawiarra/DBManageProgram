using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductsCore;

namespace WorkWithDBCore
{
    public static partial class DB
    {
        private static List<Furniture> furnitureTable = new List<Furniture>();

        public static void AddFurniture(Furniture furniture)
        {
            furnitureTable.Add(furniture);
        }

        public static void SortFurniture()
        {
            furnitureTable.Sort();
        }

        public static string[] PrintFurniture()
        {
            string[] furnitureInfo = new string[furnitureTable.Count];

            for (int i = 0; i < furnitureTable.Count; i++)
            {

                furnitureInfo[i] = furnitureTable[i].ToString();
            }

            return furnitureInfo;
        }

        public static void DeleteFurniture(Furniture furniture)
        {
            furnitureTable.Remove(furniture);
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

       
    }
}
