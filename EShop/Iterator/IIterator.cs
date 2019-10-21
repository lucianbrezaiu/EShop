using EShop.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Iterator
{
    interface IIterator
    {

        KeyValuePair<Entity, double> CurrentItem { get; }
        bool NextItem();
        void Reset();
    }
}
