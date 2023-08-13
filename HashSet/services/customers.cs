using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets_SortedLists.services
{
    public class customers :IComparable<customers>
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 397 + Phone.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var customer = obj as customers;
            if(customer is null)            
                return false;

            return this.Phone.Equals(customer.Phone);
        }
        public override string ToString()
        {
            return $"{Name}  {Phone}";
        }

        public int CompareTo(customers? other)
        {
            if (object.ReferenceEquals(this,other)) return 0;

            if(other is null) return -1;

            return this.Name.CompareTo(other.Name);
            throw new NotImplementedException();
        }
    }
}
