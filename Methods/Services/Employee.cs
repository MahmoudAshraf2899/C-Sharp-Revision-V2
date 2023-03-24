using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Services
{
    //Class Modifier || Class || Class Name
    //Access Modifer (Public , Private , Internal) //Internal is The Default
    internal class Employee
    {
        //Constant is Best Practice to be in the top of class's body
        //Access Modifier > Const > Data Type > Constant Name
        //We Can Make It Static to make any updates on it
        public static double TAX = 0.03;

        //Access Modifier (public,private,protected,internal)
        //Fields -> Access Modifier > Data type > Field Name = initial Value;
        public string fName;
        public string lName;
        public double wage;
        public double loggedHours;
    }
}
