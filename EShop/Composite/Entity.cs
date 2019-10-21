using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Iterator;
using EShop.Observer;
using EShop.Products.Headphones;
using EShop.Products.Phones;

namespace EShop.Composite
{
    public abstract class Entity : Collection, IObserver
    {
        public string Name { get; set; }

        protected Entity() : base(new Dictionary<Entity, int>())
        {

        }

        protected Entity(Dictionary<Entity, int> items) : base(items)
        {

        }

        public Entity(string name) : base(new Dictionary<Entity, int>())
        {
            this.Name = name;
        }

        public abstract Category ContainsProduct(string name);
        public abstract void Add(Entity child);
        public abstract void Add(Entity child, int quantity);
        public abstract bool Remove(Entity child, int quantity);

        public abstract void Display(int level);

        protected void ShowEntity(int level)
        {
            string str = Environment.NewLine;
            for (int i = 0; i < level; i++)
            {
                str += "   ";
            }
            if (this.GetType() == typeof(BasicPhone) || this.GetType() == typeof(BasicHeadphones))
            {
                str += this.ToString();
            }
            else
            {
                

                str += "- " + Name;
            }

            Console.Write(str);
        }

        public void LastEntityInStock()
        {
            Console.WriteLine("Observer -----> There is only one " + Name + " left in stock");
        }

        public void EntityAddedToStock()
        {
            Console.WriteLine("Observer ----->" + Name + " returned in stock");
        }

        public void NewEntityAdded()
        {
            Console.WriteLine("Observer -----> New product arrived at our store: " + Name);
        }
      
    }
}
