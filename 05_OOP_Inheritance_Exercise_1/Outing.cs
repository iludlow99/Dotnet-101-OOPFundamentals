using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP_Inheritance_Exercise_1
{
     public abstract class Outing
    {
        public int NumberAttended { get; private set; }
        public DateTime OutingDate { get; private set; }
        public string Location { get; private set; }
        public decimal TotalCost { get; private set; }

        public Outing(int numberAttended, DateTime outingDate, string location, decimal totalCost)
        {
            NumberAttended = numberAttended;
            OutingDate = outingDate;
            Location = location;
            TotalCost = totalCost;
        }

        public Outing()
        {

        }
            
        public abstract void CalculateCostPerPerson();
    }
}
