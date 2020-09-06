using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsCore;
using WorkWithDBCore;

namespace DBManageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.DeserializeFurnitureDB();

            DB.AddFurniture(new Furniture("mirror", "Mirror Creator", (float)200.5));

            DB.AddFurniture(new Furniture("wardrobe", "Wardrobe Creator", (float)450.5));

            DB.AddFurniture(new Furniture("closet ", "Closet  Creator", (float)420.5));

            DB.SortFurniture();

            string [] infoAboutFurniture = DB.PrintFurniture();

            foreach(string infoLine in infoAboutFurniture)
            {
                Console.WriteLine(infoLine);
            }

            DB.SerializeFurnitureDB();

            Console.ReadKey();
        }
    }
}
