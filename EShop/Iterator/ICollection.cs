using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Iterator
{
    public interface ICollection
    {
        Iterator getIterator();
    }
}
