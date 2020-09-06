using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsCore;

namespace WorkWithDB
{
    public static partial class DB
    {
        private static List<RawMaterial> rawMaterialTable = new List<RawMaterial>();

        public static void AddRawMaterial(RawMaterial rawMaterial)
        {
            rawMaterialTable.Add(rawMaterial);
        }

        public static void SortRawMaterial()
        {
            rawMaterialTable.Sort();
        }

        public static string[] PrintRawMaterial()
        {
            string[] rawMaterialInfo = new string[rawMaterialTable.Count];

            for (int i = 0; i < rawMaterialTable.Count; i++)
            {

                rawMaterialInfo[i] = rawMaterialTable[i].ToString();
            }

            return rawMaterialInfo;
        }

        public static void DeleteRawMaterial(RawMaterial rawMaterial)
        {
            rawMaterialTable.Remove(rawMaterial);
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
