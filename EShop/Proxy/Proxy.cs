using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Proxy
{
    class Proxy : IAccount
    {
        public IAccount Card { get; set; }
        public int PIN { get; set; } = 1234;
        public int AccountNumber { get; set; } = 98765;

        public void AccesAccount(int AccountNumber)
        {
            if(this.AccountNumber == AccountNumber)
            {
                Card = new Account();
            }
            else
            {
                Console.WriteLine("\n[proxy]: Card access is failing!");
            }
            
        }


        public void DisplaySold()
        {
            if (Card == null)
            {
                Console.WriteLine("\n[proxy]: Card is not activ!");
                return;
            }
            Card.DisplaySold();
        }

        public bool Pay(double sum)
        {
            if (Card == null)
            {
                Console.WriteLine("\n[proxy]: Card is not activ!");
                return false;
            }

            Console.Write("\n[proxy]: Insert PIN: ");
            int pass = int.Parse(Console.ReadLine());

            if (pass == PIN)
            {
                bool result = Card.Pay(sum);
                if (result)
                {
                    Console.Write("\n[proxy]: Operation completed succesfully!");
                    DisplaySold();
                    return true;
                }
                else
                {
                    Console.WriteLine("\n[proxy]: Sold too small!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("[proxy]: Wrong password!");
                return false;
            }

        }
    }
}
