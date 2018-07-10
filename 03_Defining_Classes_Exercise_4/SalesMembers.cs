using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class SalesMembers
    {
        public string LastName { get; set; }
        public decimal SalesForTheMonth { get; set; }

        public SalesMembers(string lastName, decimal salesForTheMonth)
        {
            LastName = lastName;
            SalesForTheMonth = salesForTheMonth;
        }
    }
}
