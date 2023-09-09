using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.services
{
    internal record Employee
    {
        public string firstName { get; init; }
        public string lastName { get; init; }
        public int Age { get; init; }
    }
}
