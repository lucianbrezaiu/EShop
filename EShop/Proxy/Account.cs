using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Proxy
{
    public class Account : IAccount
    {
        public double Sold { get; set; } = 50000000;

        public void DisplaySold()
        {
            Console.WriteLine($" [current sold: {Sold}$]");
        }

        public bool Pay(double sum)
        {
            if (sum > Sold)
            {
                return false;
            }

            Sold -= sum;
            return true;
        }
    }
}
