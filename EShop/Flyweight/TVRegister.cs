using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products;

namespace EShop.Flyweight
{
    public class TVRegister : ProductRegister
    {
        public override Product CreateNewProduct()
        {
            return new TV();
        }

        public override bool IsShared(string name)
        {
            return TV.IsShared(name);
        }
    }
}
