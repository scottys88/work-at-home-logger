using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    interface Repository<T>
    {
        public void Save(T arg)
        {
            ;
        }
    }
}
