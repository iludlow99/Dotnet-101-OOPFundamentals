using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
    class Concert : CasualOuting, IEmotion
    {
        public Concert(int numberAttended, DateTime outingDate, string location, decimal totalCost) :
            base(numberAttended, outingDate, location, totalCost)
        {
        }

        public override void CalculateCostPerPerson()
        {
            throw new NotImplementedException();
        }

        public void CheckHappiness()
        {
            throw new NotImplementedException();
        }
    }
}
