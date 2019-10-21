using System;
using System.Collections.Generic;
using EShop.Enums;

namespace EShop.Products
{
    public class Laptop : Product
    {
        public override EProductType Type => EProductType.ELaptop;
        static List<String> LaptopList = new List<String> { "Dell", "Apple", "Asus" };

        public Laptop(int ID, int Price, ECountry MadeIn, string Name) : base(ID, Price, MadeIn, Name)
        {

        }

        public Laptop() : base()
        {

        }
        //flyweight
        public static bool IsShared(string name)
        {
            return LaptopList.Contains(name);
        }
    }
}
