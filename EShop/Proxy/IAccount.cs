using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Proxy
{
    public interface IAccount
    {
        bool Pay(double sum);

        void DisplaySold();
        
    }
}
