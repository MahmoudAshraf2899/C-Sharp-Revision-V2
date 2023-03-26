using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_And_Dictionaries.Services
{
    internal class Contract_Installments
    {
        public int contractId { get; set; }
        public double? instalmmentValue { get; set; }
        public string installmentType { get; set; }
        public DateTime? date { get; set; }
         
    }
}
