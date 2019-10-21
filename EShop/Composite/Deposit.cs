using EShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Enums;
using EShop.Iterator;
using EShop.Products.Headphones;
using EShop.Products.Headphones.Colors;
using EShop.Products.Headphones.Connectivity;
using EShop.Products.Headphones.Style;
using EShop.Products.Phones;
using EShop.Products.Phones.Colors;
using EShop.Products.Phones.InternalMemory;
using EShop.Products.Phones.SimSlots;

namespace EShop.Composite
{
    public class Deposit : Category
    {
        private static Deposit deposit;
        private static Object LockObject = new Object();

        private Deposit()
        {
            Name = "E-Shop";
        }

        public static Deposit Instance
        {
            get
            {
                lock (LockObject)
                {
                    if (deposit == null)
                    {
                        deposit = new Deposit();
                    }
                    return deposit;
                }
            }
        }

        public override void Display(int level)
        {
            base.Display(level);
        }

        public override string ToString()
        {
            Display(0);
            return "";
        }

        public void PopulateDeposit()
        {
            Category c1 = new Category(ECategory.Electronics);
            Category c2 = new Category(ECategory.Appliances);

            GermanyFactory f1 = new GermanyFactory();
            ChineseFactory f2 = new ChineseFactory();
            RomaniaFactory f3 = new RomaniaFactory();
            UsaFactory f4 = new UsaFactory();

            Product p1 = f1.GetLaptop(423, "asus rog");
            Product p2 = f2.GetLaptop(92, "asus tuff");
            Product p3 = f3.GetAppliance(104, "cuptor cu microunde samsung");
            Product p4 = getPhoneDecorated(f4, EColor.Gold, ESimSlots.SingleSim, EInternalMemory.Gb128, "apple");
            Product p5 = getPhoneDecorated(f3, EColor.Black, ESimSlots.HybridDualSim, EInternalMemory.Gb64, "samsung");
            Product p6 = getHeadphonesDecorated(f1, EColor.Blue, EConnectivity.Wired, EStyle.OverTheEar, "skullcandy");
            Product p7 = getHeadphonesDecorated(f2, EColor.Black, EConnectivity.Wireless, EStyle.OverTheEar, "bose");
            Product p8 = f4.GetLaptop(546, "Asus ultrabook");
            Product p9 = f3.GetAppliance(52, "masina de spalat artic");
            Product p10 = f2.GetTV(234, "Samsung");

            deposit.Add(c1);
            deposit.Add(c2);

            c1.Add(p1, 8);
            c1.Add(p2, 10);
            c1.Add(p8, 5);
            c2.Add(p9, 12);
            c2.Add(p3, 12);
            c1.Add(p10, 12);
            c1.Add(p4, 5);
            c1.Add(p5, 4);
            c1.Add(p6, 5);
            c1.Add(p7, 9);
        }

        public Product getPhoneDecorated(AbstractProductFactory factory, EColor color, ESimSlots simSlots, EInternalMemory internalMemory, string name)
        {
            UsaFactory f4 = new UsaFactory();
            BasicPhone basicPhone = (BasicPhone) factory.GetPhone(300, name);

            PhoneDecorator decoratedPhone = null;
            switch (color)
            {
                case EColor.White:
                    decoratedPhone = new WhitePhone(basicPhone);
                    break;
                case EColor.Gold:
                    decoratedPhone = new GoldPhone(basicPhone);
                    break;
                case EColor.Silver:
                    decoratedPhone = new SilverPhone(basicPhone);
                    break;
                default:
                    break;
            }

            switch (simSlots)
            {
                case ESimSlots.DualSim:
                    decoratedPhone = new DualSimPhone(basicPhone);
                    break;
                case ESimSlots.HybridDualSim:
                    decoratedPhone = new HybridDualSimPhone(basicPhone);
                    break;
                default:
                    break;
            }

            switch (internalMemory)
            {
                case EInternalMemory.Gb64:
                    decoratedPhone = new Gb64Phone(basicPhone);
                    break;
                case EInternalMemory.Gb128:
                    decoratedPhone = new Gb128Phone(basicPhone);
                    break;
                case EInternalMemory.Gb256:
                    decoratedPhone = new Gb256Phone(basicPhone);
                    break;
                default:
                    break;
            }

            return basicPhone;
        }

        public Product getHeadphonesDecorated(AbstractProductFactory factory, EColor color, EConnectivity connectivity,
            EStyle style, string name)
        {
            UsaFactory f4 = new UsaFactory();
            BasicHeadphones basicHeadphones = (BasicHeadphones)factory.GetHeadphones(15, name);

            HeadphonesDecorator decoratedHeadphones = null;

            switch (color)
            {
                case EColor.Blue:
                    decoratedHeadphones = new BlueHeadphones(basicHeadphones);
                    break;
                case EColor.Gray:
                    decoratedHeadphones = new GrayHeadphones(basicHeadphones);
                    break;
                case EColor.Red:
                    decoratedHeadphones = new RedHeadphones(basicHeadphones);
                    break;
                case EColor.White:
                    decoratedHeadphones = new WhiteHeadphones(basicHeadphones);
                    break;
                default:
                    break;
            }

            switch (connectivity)
            {
                case EConnectivity.Wireless:
                    decoratedHeadphones = new WirelessHeadphones(basicHeadphones);
                    break;
                default:
                    break;
            }

            switch (style)
            {
                case EStyle.OnTheEar:
                    decoratedHeadphones = new OnTheEarHeadphones(basicHeadphones);
                    break;
                case EStyle.OverTheEar:
                    decoratedHeadphones = new OverTheEarHeadphones(basicHeadphones);
                    break;
                case EStyle.Sport:
                    decoratedHeadphones = new SportHeadphones(basicHeadphones);
                    break;
                default:
                    break;
            }

            return basicHeadphones;
        }
    }
}
