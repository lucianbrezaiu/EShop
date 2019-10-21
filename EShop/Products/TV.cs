using System;
using System.Collections.Generic;
using EShop.Enums;

namespace EShop.Products
{
    public class TV : Product
    {
        public override EProductType Type => EProductType.ETV;

        static List<String> TVList = new List<String> { "Samsung", "Sony", "LG" };
        public TV(int ID, int Price, ECountry MadeIn, string Name) : base(ID, Price, MadeIn, Name)
        {

        }

        public TV() : base()
        {

        }
        //flyweight
        public static bool IsShared(string name)
        {
            return TVList.Contains(name);
        }
    }
}
