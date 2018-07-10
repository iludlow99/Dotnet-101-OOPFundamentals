using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class Developer : Employee
    {
        //Declare a DevsMessages class and instantiate it in the constructor

        public override void ChangeLocation(LocationEnum LocationToGoTo)
        {
            throw new NotImplementedException();
        }

        public override string SwipeBadge(string optionalmessage = "")
        {
            throw new NotImplementedException();
        }
    }
}
