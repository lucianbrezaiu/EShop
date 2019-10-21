using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Enums;
using EShop.Iterator;
using EShop.Observer;

namespace EShop.Composite
{
    public class Category : Entity, ICategory
    {

        public Dictionary<Entity,int> Kids { get; set; } = new Dictionary<Entity, int>();

        protected Category()
        {

        }
        
        public Category(Dictionary<Entity, int> items) : base(items)
        {

        }

        public Category(Enum name) : base(name.ToString())
        {
            
        }

        public Category(string name) : base(name)
        {
        }

        public override void Add(Entity child, int quantity)
        {
            Subscribe(child, quantity);
        }

        public override void Add(Entity child)
        {
            Add(child, -1);
        }

        public override bool Remove(Entity child, int quantity)
        {
            return Unsubscribe(child, quantity);
        }

        public override void Display(int level)
        {
            ShowEntity(level);
            
            foreach (var pair in Kids)
            {
                pair.Key.Display(level+1);
                if(pair.Key is Product)
                {
                    Console.Write($" ({pair.Value})");
                }
            }
        }

        public void Subscribe(Entity entity, int quantity)
        {
            if (entity is Product)
            {
                bool ok = false;
                foreach(var kid in Kids)
                {
                    if (kid.Key.Name.Equals(entity.Name))
                    {
                        if (Kids[kid.Key] == 0)
                        {
                            Notify(entity, EAction.EAdd);
                        }

                        Kids[kid.Key]+= quantity;
                        ok = true;
                        break;
                    }
                }

                if(!ok)
                {
                    Kids.Add(entity, quantity);
                    Notify(entity, EAction.EAddNewProduct);
                }
            }
            else
            {
                Kids.Add(entity, quantity);
            }
        }

        public bool Unsubscribe(Entity entity, int quantity)
        {
            if (Kids.ContainsKey(entity))
            {
                if (Kids[entity] >= quantity)
                {
                    Kids[entity] -= quantity;

                    if (Kids[entity] == 1)
                    {
                        Notify(entity, EAction.ERemove);
                    }

                    return true;
                }
                else
                {
                    Console.WriteLine("Not enough " + entity.Name + " in stock");
                    return false;
                }
                
            }
            return false;
        }

        public void Notify(Entity entity, EAction action)
        {
            switch (action)
            {
                case EAction.EAdd:
                    entity.EntityAddedToStock();
                    break;
                case EAction.ERemove:
                    entity.LastEntityInStock();
                    break;
                case EAction.EAddNewProduct:
                    entity.NewEntityAdded();
                    break;
                default:
                    break;
            }
        }

        public override Category ContainsProduct(string name)
        {
            foreach(var kid in Kids)
            {
                string kidName = kid.Key.Name.ToLower();
                if (kidName.Equals(name))
                {
                    return this;
                }
            }
            return null;
        }

        public KeyValuePair<Entity,int> GetProduct(string name)
        {
            foreach (var kid in Kids)
            {
                string kidName = kid.Key.Name.ToLower();
                if (kidName.Equals(name))
                {
                    return kid;
                }
            }
            return new KeyValuePair<Entity, int>();
        }

    }
}
