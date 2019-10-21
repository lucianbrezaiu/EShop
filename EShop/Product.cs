using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Enums;
using EShop.Composite;
using EShop.Observer;

namespace EShop
{
    public abstract class Product: Entity, IProduct 
    {
        public int ID { get; private set; }
        public int Price { get; set; }
        private ECountry MadeIn { get; set; }
        public double TotalValue { get; set; } //flyweight

        public abstract EProductType Type { get; }

        public Product()
        {

        }

        public Product(int ID, int Price, ECountry MadeIn, string Name) : base(Name)
        {
            this.ID = ID;
            this.Price = Price;
            this.MadeIn = MadeIn;
        }

        public override string ToString()
        {
            return string.Format(
                "product [ID: {0}, " +
                "Type: {1}, " +
                "Name: {2}, " +
                "Price: {3}, " +
                "Producer: {4}]",
                ID, Type, Name, Price , MadeIn);
        }

        public override void Add(Entity child)
        {
            return;
        }

        public override void Add(Entity child, int quantity)
        {
            return;
        }

        public override bool Remove(Entity child, int quantity)
        {
            return false;
        }

        public override Category ContainsProduct(string name)
        {
            return null;
        }



        public override void Display(int level)
        {
            ShowEntity(level);
        }
    }
}
