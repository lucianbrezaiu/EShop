using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Products;

namespace EShop.Flyweight
{
    public abstract class ProductRegister
    {

        public static Product UnsharedProducts = new Laptop();
        public static Dictionary<String, int> ShareProductsMap = new Dictionary<String, int>();

        private Product Lookup(string name)
        {

            if (IsShared(name))
            {
                Product product = null;
                int quantity=0;
                if(ShareProductsMap.TryGetValue(name, out quantity)==false)
                {
                    product = CreateNewProduct();
                    ShareProductsMap.Add(name, quantity);
                }
                return product;
            }
            else
            {
                return UnsharedProducts;
            }

        }

        public void StockIn(string name,int quantity)
        {
            Product product= Lookup(name);
            product.TotalValue += quantity;
        }
        public void StockOut(string name, int quantity)
        {
            Product product = Lookup(name);
            if (product.TotalValue >= quantity)
                product.TotalValue -= quantity;
            else
                Console.WriteLine("You need more money");
        }
        public static void GetTotal()
        {
            foreach (KeyValuePair<String, int> entry in ShareProductsMap)
            {
                Console.WriteLine("Product: " + entry.Value + " Quantity: " + entry.Key.ToString());
            }
        }

        public abstract Product CreateNewProduct();
        public abstract bool IsShared(string name);
    }
}
