using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_And_HashSet.Services
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            var hashNumber = 17;
            //Make Phone Number Unique
            hashNumber = (hashNumber * 307) + Telephone.GetHashCode() ;
            return hashNumber;
        }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if (customer == null) return false;

            return this.Telephone.Equals(customer.Telephone);
        }
    }
}
