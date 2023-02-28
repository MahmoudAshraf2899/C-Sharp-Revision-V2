using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance_Problem
{
    public class Manager : Employee
    {
        public const decimal Allowance = 0.05m;
        public override decimal Calculate()
        {
            return base.Calculate() + Allowance * base.Calculate();
        }
        private decimal CalculateAllowance()
        {
            return base.Calculate() + base.Calculate() * Allowance;
        }
        public override string ToString()
        {

            return base.ToString() +
                $"\n Allowance : {CalculateAllowance()}" +
                $"\n Net Salary : {Calculate()}";
        }
    }
}
