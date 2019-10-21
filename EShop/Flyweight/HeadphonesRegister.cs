using EShop.Products.Headphones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Flyweight
{
    public class HeadphonesRegister : ProductRegister
    {
        public override Product CreateNewProduct()
        {
            return new BasicHeadphones();
        }

        public override bool IsShared(string name)
        {
            return BasicHeadphones.IsShared(name);
        }
    }
}
