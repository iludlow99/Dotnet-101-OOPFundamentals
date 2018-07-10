using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class ClaimsMessages
    {
        public int ClaimsAssignedToday { get; set; }

        //EnterMessage
        public string EnterMessage()
        {
            return $"Welcome. Did you know that 80% of all Fourth of July accidents are caused by teenage boys?";
        }

        public string EnterMessage(string message)
        {
            return message;
        }

        //ElevatorMessage
        public string ElevatorMessage(int claimsAssignedToday)
        {
            ClaimsAssignedToday = claimsAssignedToday;
            return $"You have {ClaimsAssignedToday} claims to look at today.";
        }

        public string ElevatorMessage(string message)
        {
            return message;
        }


        //LeaveMessage
        public string LeaveMessage()
        {
            return $"Great job today. You adjusted {ClaimsAssignedToday} claims today.";
        }

        public string LeaveMessage(string message)
        {
            return message;
        }
    }
}
