using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2.Service
{
    public class ClonableList<T> : List<T>, ICloneable
    {

        public object Clone()
        {
            return new ClonableList<T>();
        }
    }
}
