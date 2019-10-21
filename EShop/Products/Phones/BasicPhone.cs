using EShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products.Phones.Colors;
using EShop.Products.Phones.InternalMemory;
using EShop.Products.Phones.SimSlots;

namespace EShop.Products.Phones
{
    public class BasicPhone: Product, IPhone
    {
        static List<String> PhoneList = new List<String> { "Samsung", "Apple", "Asus" };

        public override EProductType Type => EProductType.EPhone;

        public BasicPhone(int ID, int Price, ECountry MadeIn, string Name) : base(ID, Price, MadeIn, Name)
        {
            Color = EColor.Black;
            InternalMemory = EInternalMemory.Gb32;
            SimSlots = ESimSlots.SingleSim;
        }

        public BasicPhone() : base()
        {
            Color = EColor.Black;
            InternalMemory = EInternalMemory.Gb32;
            SimSlots = ESimSlots.SingleSim;
        }

        public EColor Color { get; set; }
        public EInternalMemory InternalMemory { get; set; }
        public ESimSlots SimSlots { get; set; }

        public override string ToString()
        {
            return
                $"- Name: {Name}, Price: {Price}, Color: {Color}, Internal memory: {InternalMemory}, Sim slots: {SimSlots}";
        }

        //flyweight
        public static bool IsShared(string name)
        {
            return PhoneList.Contains(name);
        }
    }
}