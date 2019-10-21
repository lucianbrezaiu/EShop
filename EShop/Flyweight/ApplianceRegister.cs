using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products;

namespace EShop.Flyweight
{
    public class ApplianceRegister : ProductRegister
    {
        public override Product CreateNewProduct()
        {
            return new Appliance();
        }

        public override bool IsShared(string name)
        {
            return Appliance.IsShared(name);
        }
    }
}
