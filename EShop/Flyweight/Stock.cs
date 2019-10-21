using EShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Flyweight
{
    public class Stock
    {
        LaptopRegister laptopReg = new LaptopRegister();
        PhoneRegister phoneReg = new PhoneRegister();
        TVRegister TVReg = new TVRegister();
        ApplianceRegister applianceReg = new ApplianceRegister();
        HeadphonesRegister headphonesReg = new HeadphonesRegister();


        public void StockIn(string name, int quantity, EProductType eProductType)
        {
            Console.WriteLine("Stock IN -> Product Name:" + name + " Quantity: " + quantity + " " + eProductType);
            switch (eProductType)
            {
                case EProductType.ELaptop:
                    laptopReg.StockIn(name, quantity);
                    break;
                case EProductType.EPhone:
                    phoneReg.StockIn(name, quantity);
                    break;
                case EProductType.ETV:
                    TVReg.StockIn(name, quantity);
                    break;
                case EProductType.EAppliance:
                    applianceReg.StockIn(name, quantity);
                    break;
                case EProductType.EHeadphones:
                    headphonesReg.StockIn(name, quantity);
                    break;
                default:
                    break;
            }
        }

        public void StockOut(string name, int quantity, EProductType eProductType)
        {
            Console.WriteLine("Stock OUT -> Product Name:" + name + " Quantity: " + quantity + " " + eProductType);
            switch (eProductType)
            {
                case EProductType.ELaptop:
                    laptopReg.StockOut(name, quantity);
                    break;
                case EProductType.EPhone:
                    phoneReg.StockOut(name, quantity);
                    break;
                case EProductType.ETV:
                    TVReg.StockOut(name, quantity);
                    break;
                case EProductType.EAppliance:
                    applianceReg.StockOut(name, quantity);
                    break;
                case EProductType.EHeadphones:
                    headphonesReg.StockOut(name, quantity);
                    break;
                default:
                    break;
            }
        }

        public void GetTotalCache()
        {
            ProductRegister.GetTotal();
        }
    }
}
