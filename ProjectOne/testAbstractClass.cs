using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public abstract class testAbstractClass
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }
        public abstract int summation(int i, int x);
    }
}
