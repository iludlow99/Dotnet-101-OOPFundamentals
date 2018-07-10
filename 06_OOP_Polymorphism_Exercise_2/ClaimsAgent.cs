using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class ClaimsAgent : Employee
    {
        //Declare a ClaimsMessages class and instantiate it in the constructor

        public ClaimsMessages claimsMessages;

        public ClaimsAgent(int monthlyGoal, int teamGoal, int salesToday)
        {
            claimsMessages = new SalesMessages(monthlyGoal, teamGoal, salesToday);
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
