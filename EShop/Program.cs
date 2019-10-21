using EShop.Composite;
using EShop.Factories;
using System;
using EShop.Order;
using EShop.Proxy;
using System.Collections.Generic;
using EShop.Iterator;

namespace EShop
{

    public class Program
    {
        static ShoppingCart ShoppingCart;
        static Deposit Deposit;
        static Proxy.Proxy Proxy;

        public static void InitializeApp()
        {
            Deposit = Deposit.Instance;
            Deposit.PopulateDeposit();

            ShoppingCart = new ShoppingCart();

            Proxy = new Proxy.Proxy();
            Console.WriteLine("\nWELCOME!");
            Menu();
        }

        public static void Pause()
        {
            Console.Write("\nPress any key to continue ...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }


        public static void Menu()
        {
            Console.WriteLine("\n1. Display products" +
                              "\n2. Display shopping card" +
                              "\n3. Pick a product" +
                              "\n4. Pay order" +
                              "\n5. Cancel order" +
                              "\n6. [admin] Stock in" +
                              "\n7. Exit");
        }

        public static void PickProduct()
        {
            Console.Write("\nInsert product name: ");
            string name = Console.ReadLine();
            name = name.Trim();
            name = name.ToLower();

            Category category = Search(Deposit, name);

            if (category is null)
            {
                Console.WriteLine("The product doesn't exist!");
            }
            else
            {
                KeyValuePair<Entity, int> product = category.GetProduct(name);
                Console.WriteLine("\nDo you wish to buy:\n\n" + product.Key + "\n\ncurrent stock: " + product.Value);

                Console.Write("\nInsert the quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                bool result = category.Remove(product.Key, quantity);

                if(result)
                {
                    for(int i=0;i<quantity;i++)
                    {
                        ShoppingCart.AddProduct((Product)product.Key);
                    }
                    Console.WriteLine("\nThe product was addeed in shopping cart!\n");

                }

            }



        }




        public static Category Search(Entity entity, string name)
        {
            if (!(entity is Product))
            {
                Collection collection = new Collection(((Category)entity).Kids);
                Iterator.Iterator it = collection.getIterator();
                it.NextItem();
                do
                {
                    var aux = (Entity)it.CurrentItem.Key;
                    Category category = aux.ContainsProduct(name);
                    if (category != null)
                    {
                        return category;
                    }

                    if (aux.GetType() != typeof(Product))
                        foreach (var kid in ((Category)aux).Kids)
                        {
                            if (kid.GetType() != typeof(Product))
                                Search(kid.Key, name);
                        }

                } while (it.NextItem());


            }
            return null;
        }

        public static void PayOrder()
        {
            Console.Write("\nInsert account number: ");
            int accountNr = int.Parse(Console.ReadLine());

            Proxy.AccesAccount(accountNr);
            double total = ShoppingCart.GetTotal();
            bool result = Proxy.Pay(total);
            if (result)
            {
                ShoppingCart.Reset();
            }
        }


        public static void StockIn()
        {
            GermanyFactory factory = new GermanyFactory();

            Product product = factory.GetLaptop(1000,"asus rog");

            Category category = Search(Deposit,product.Name);

            category.Add(product, 10);
        }

        public static void CancelOrder()
        {
            foreach(var item in ShoppingCart.Products)
            {
                Product Product = item.Product;
                int quantity = item.Quantity;

                Category category = Search(Deposit,Product.Name);
                category.Add(Product, quantity);
            }
        }

        public static void Main()
        {

            InitializeApp();
            int choice = 0;
            do
            {
                try
                {

                    Console.Write("\nchoice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(Deposit);
                            break;
                        case 2:
                            ShoppingCart.ShowProducts();
                            break;
                        case 3:
                            PickProduct();
                            break;
                        case 4:
                            PayOrder();
                            break;
                        case 5:
                            CancelOrder();
                            break;
                        case 6:
                            StockIn();
                            break;
                        case 7:
                            Console.WriteLine("\nHave a nice day! Bye bye!\n");
                            break;
                        default:
                            Console.WriteLine("\nWrong choice!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write("\nError! ");
                    Console.WriteLine(e.Message);
                    choice = 0;
                }

                if (choice != 7)
                {
                    Pause();
                }



            } while (choice != 7);


        }
    }
}