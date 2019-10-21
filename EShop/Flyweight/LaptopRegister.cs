using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products;

namespace EShop.Flyweight
{
    public class LaptopRegister : ProductRegister
    {
        public override Product CreateNewProduct()
        {
            return new Laptop();
        }

        public override bool IsShared(string name)
        {
            return Laptop.IsShared(name);
        }
    }
}
