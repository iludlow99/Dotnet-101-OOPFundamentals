using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public LocationEnum CurrentLocation { get; set; } = LocationEnum.ParkingLot;

        public abstract void ChangeLocation(LocationEnum locationToGoTo);

        public abstract string SwipeBadge(string optionalmessage = "");
    }
}
