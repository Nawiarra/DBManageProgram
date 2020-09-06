using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCore
{
    [Serializable]
    public abstract class Product
    {
        public string Name { get; protected set; }

        public float Price { get; protected set; }

        public abstract bool isFurniture();

        public abstract bool Serialize();
    }
}
