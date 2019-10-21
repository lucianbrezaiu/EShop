using EShop.Composite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Iterator
{
    public class Collection : ICollection
    {
        private Dictionary<Entity, int> _items = new Dictionary<Entity, int>();

        public Collection(Dictionary<Entity, int> items)
        {
            _items = items;
        }

        public Iterator getIterator()
        {
            return new Iterator(this);
        }

        public int Count { get { return _items.Count; } }

        public KeyValuePair<Entity, double> this[int index]
        {
            get
            {
                int nr = -1;
                foreach(var pair in _items)
                {
                    nr++;
                    if(index==nr)
                    {
                        return new KeyValuePair<Entity,double>(pair.Key,pair.Value);
                    }
                }
                return new KeyValuePair<Entity, double>();
            }
            
        }
    }
}
