using System;
using System.Collections.Generic;
using EShop.Enums;

namespace EShop.Products
{
    public class Appliance : Product
    {
        public override EProductType Type => EProductType.EAppliance;
        static List<String> ApplianceList = new List<String> { "Dell", "Apple", "Asus" };

        public Appliance(int ID, int Price, ECountry MadeIn, string Name) : base(ID, Price, MadeIn, Name)
        {

        }

        public Appliance() : base()
        {

        }
        //flyweight
        public static bool IsShared(string name)
        {
            return ApplianceList.Contains(name);
        }
    }
}
