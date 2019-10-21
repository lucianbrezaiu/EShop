using EShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products.Headphones.Colors;
using EShop.Products.Headphones.Connectivity;
using EShop.Products.Headphones.Style;

namespace EShop.Products.Headphones
{
    public class BasicHeadphones: Product, IHeadphones
    {
        static List<String> HeadphonesList = new List<String> { "Samsung", "Apple", "Asus" };

        public override EProductType Type => EProductType.EHeadphones;

        public BasicHeadphones(int ID, int Price, ECountry MadeIn, string Name) : base(ID, Price, MadeIn, Name)
        {
            Color = EColor.Black;
            Style = EStyle.InEar;
            Connectivity = EConnectivity.Wired;
        }

        public BasicHeadphones() : base()
        {
            Color = EColor.Black;
            Style = EStyle.InEar;
            Connectivity = EConnectivity.Wired;
        }
        public EColor Color { get; set; }
        public EConnectivity Connectivity { get; set; }
        public EStyle Style { get; set; }

        public override string ToString()
        {
            return
                $"- Name: {Name}, Price: {Price}, Color: {Color}, Connectivity: {Connectivity}, Style: {Style}";
        }

        //flyweight
        public static bool IsShared(string name)
        {
            return HeadphonesList.Contains(name);
        }
    }
}