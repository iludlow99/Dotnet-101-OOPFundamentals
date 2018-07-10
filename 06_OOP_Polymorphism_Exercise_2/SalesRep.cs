using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Caching;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class SalesRep : Employee
    {
        public SalesMessages salesMessages;

        public SalesRep(int monthlyGoal, int teamGoal, int salesToday)
        {
            salesMessages = new SalesMessages(monthlyGoal, teamGoal, salesToday);
        }

        public override void ChangeLocation(LocationEnum locationToGoTo)
        {
            Console.WriteLine("Changing location...");
            CurrentLocation = locationToGoTo;
            Console.WriteLine($"Location changed to: {CurrentLocation}");

        }

        public override string SwipeBadge(string optionalmessage = "Error")
        {
            string message;

            Console.WriteLine("Swiping badge...");
            if (optionalmessage == "Error")
            {
                switch (CurrentLocation)
                {
                    case LocationEnum.Enter:
                        message = salesMessages.EnterMessage();
                        return message;

                    case LocationEnum.Elevator:
                        message = salesMessages.ElevatorMessage();
                        return message;

                    case LocationEnum.Leave:
                        message = salesMessages.LeaveMessage();
                        return message;
                }
            }

            else if (optionalmessage != "")
            {
                switch (CurrentLocation)
                {
                    case LocationEnum.Enter:
                        message = salesMessages.EnterMessage(optionalmessage);
                        return message;

                    case LocationEnum.Elevator:
                        message = salesMessages.ElevatorMessage(optionalmessage);
                        return message;

                    case LocationEnum.Leave:
                        message = salesMessages.LeaveMessage(optionalmessage);
                        return message;
                }
            }

            return optionalmessage;
        }
    }
}
