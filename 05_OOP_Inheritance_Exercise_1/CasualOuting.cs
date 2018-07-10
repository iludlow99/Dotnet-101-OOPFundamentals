using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    public abstract class CasualOuting : Outing
    {
        public CasualOuting(int numberAttended, DateTime outingDate, string location, decimal totalCost) :
            base(numberAttended, outingDate, location, totalCost)
        {

        }

    }
}
