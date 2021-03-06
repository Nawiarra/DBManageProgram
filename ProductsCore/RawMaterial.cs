﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProductsCore
{
    [Serializable]
    public class RawMaterial : Product
    {
        private float width;
        public float Width 
        { 
            get 
            { 
                return width; 
            } 
            
            private set 
            { 
                width = value > 0 ? value : Math.Abs(value); 
            } 
        }

        private float height;
        public float Height
        { 
            get 
            { 
                return height; 
            } 
            private set 
            {
                height = value > 0 ? value : Math.Abs(value);
            } 
        }


        private float thickness;
        public float Thickness
        {
            get
            {
                return thickness;
            }
            private set
            {
                thickness = value > 0 ? value : Math.Abs(value);
            }
        }

        public string Size { get; private set; }

        public RawMaterial(string name, float width, float height, float thickness, float price)
        {
            Name = name;

            Width = width;

            Height = height;

            Thickness = thickness;

            Price = price;
        }

        public override int CompareTo(object obj)
        {
            RawMaterial rawMaterial = obj as RawMaterial;

            if (rawMaterial != null)
            { 
                return this.Price.CompareTo(rawMaterial.Price); 
            }
                
            else
            {
                throw new Exception("can't compare");
            }
        }

        public override string ToString()
        {
            return $"{Name} that is {Width}x{Height}x{Thickness}, that cost {Price}";
        }

        public override bool isFurniture()
        {
            return false;
        }

    }
}
