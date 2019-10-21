using System;
using System.Collections.Generic;

namespace EShop.Order
{

    public class ShoppingCart
    {
        public List<ShoppingCartItem> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<ShoppingCartItem>();
        }

        public double GetTotal()
        {
            double sum = 0;
            foreach(var item in Products)
            {
                sum += item.Quantity * item.Product.Price;
            }
            return sum;
        }

        public void AddProduct(Product product)
        {
            foreach (var ShoppingCartItem in Products)
            {
                if (ShoppingCartItem.Product == product)
                {
                    ShoppingCartItem.Quantity += 1;
                    return;
                }
            }
            Products.Add(new ShoppingCartItem(product));
        }


        public void ShowProducts()
        {
            int counter = 0;
            foreach (var product in Products)
            {
                counter++;
                Console.WriteLine(counter + ". " + product.Quantity + " pieces of " + product.Product.ToString());
            }

            if(counter==0)
            {
                Console.WriteLine("\nEmpty cart!");
            }
        }

        public void RemoveProducts(Product product)
        {
            foreach (var ShoppingCartItem in Products)
            {
                if (ShoppingCartItem.Product == product)
                {
                    if (ShoppingCartItem.Quantity > 1)
                    {
                        ShoppingCartItem.Quantity -= 1;
                        return;
                    }
                    else if (ShoppingCartItem.Quantity == 1)
                    {
                        Products.Remove(ShoppingCartItem);
                        return;
                    }
                }
            }
        }

        public void Reset()
        {
            Products = new List<ShoppingCartItem>();
        }

    }
}
