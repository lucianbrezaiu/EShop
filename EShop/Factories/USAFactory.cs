using EShop.Enums;
using EShop.Products;
using EShop.Products.Headphones;
using EShop.Products.Phones;

namespace EShop.Factories
{
    public class UsaFactory : AbstractProductFactory
    {
        public override Product GetLaptop(int Price, string Name)
        {
            return new Laptop(LastId++, Price, ECountry.EUSA, Name);
        }

        public override Product GetPhone(int Price, string Name)
        {
            return new BasicPhone(LastId++, Price, ECountry.EUSA, Name);
        }

        public override Product GetHeadphones(int Price, string Name)
        {
            return new BasicHeadphones(LastId++, Price, ECountry.EUSA, Name);
        }

        public override Product GetAppliance(int Price, string Name)
        {
            return new Appliance(LastId++, Price, ECountry.EUSA, Name);
        }

        public override Product GetTV(int Price, string Name)
        {
            return new TV(LastId++, Price, ECountry.EUSA, Name);
        }
    }
}
