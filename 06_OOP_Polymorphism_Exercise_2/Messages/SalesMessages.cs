using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class SalesMessages
    {
        public int MonthlyGoal { get; set; }
        public int TeamGoal { get; set; }
        public int SalesThisMonth { get; set; }
        public int SalesToday { get; set; }

        public SalesMessages(int monthlyGoal, int teamGoal, int salesToday)
        {
            MonthlyGoal = monthlyGoal;
            TeamGoal = teamGoal;
            SalesToday = salesToday;
        }

        //EnterMessage
        public string EnterMessage()
        {
            return $"Good luck today! You are ${MonthlyGoal - SalesThisMonth} dollars from our monthly goal. " +
                   $"Also, remember that the team goal is for the month is ${TeamGoal}";
        }

        public string EnterMessage(string message)
        {
            return message;
        }


        //ElevatorMessage
        public string ElevatorMessage()
        {
            return "Remember that you have a meeting with the AMC Corporation today.";
        }

        public string ElevatorMessage(string message)
        {
            return message;
        }


        //LeaveMessage
        public string LeaveMessage()
        {
            return $"Great job today. You had ${SalesToday} dollars in sales for the day. You are now ${MonthlyGoal - SalesThisMonth} dollars from your monthly goal.";
        }

        public string LeaveMessage(string message)
        {
            return message;
        }
    }
}
