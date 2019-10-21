using EShop.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Iterator
{
    public class Iterator : IIterator
    {
        private Collection Collection;
        private int _current;


        public Iterator(Collection Collection)
        {
            this.Collection = Collection;
            Reset();
        }

        public KeyValuePair<Entity, double> CurrentItem { get => Collection[_current]; }

        

        public bool NextItem()
        {
            return ++_current < Collection.Count;
        }

        public void Reset()
        {
            _current = -1;
        }

       
    }
}
