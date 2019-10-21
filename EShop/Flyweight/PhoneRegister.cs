using EShop.Products.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Flyweight
{
    public class PhoneRegister : ProductRegister
    {
        public override Product CreateNewProduct()
        {
            return new BasicPhone();
        }

        public override bool IsShared(string name)
        {
            return BasicPhone.IsShared(name);
        }
    }
}
