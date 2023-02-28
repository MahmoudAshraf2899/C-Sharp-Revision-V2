using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance_Problem
{
    public class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }


        public virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }
        private decimal CalculateBaseSalary()
        {
            return (LoggedHours * Wage);
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
            return (additionalHours * Wage * OverTimeRate);

        }
        public override string ToString()
        {
            return $"\n Id:{Id}" +
                    $"\n Name : {Name}" +
                    $"\n Logged Hours : {LoggedHours}" +
                    $"\n Wage : {Wage} $/Hr" +
                    $"\n Base Salary : {CalculateBaseSalary()}" +
                    $"\n Over Time : {CalculateOverTime()}";
        }
    }
}
