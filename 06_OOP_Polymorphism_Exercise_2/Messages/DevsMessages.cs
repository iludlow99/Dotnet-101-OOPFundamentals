using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_2
{
    public class DevsMessages
    {
        public int LinesOfCodePushed { get; set; }

        //EnterMessage
        public string EnterMessage()
        {
            return $"Ryan Dahl, the creator of Node, just created a new language called Deno, and you’ll be learning the fundamentals today!";
        }

        public string EnterMessage(string message)
        {
            return message;
        }

        //ElevatorMessage
        public string ElevatorMessage()
        {
            return $"Welcome to work. Someone responded to your Stack Overflow Post on Polymorphism. You also have a stand up 20 seconds from now.";
        }

        public string ElevatorMessage(string message)
        {
            return message;
        }


        //LeaveMessage
        public string LeaveMessage(int linesOfCodePushed)
        {
            LinesOfCodePushed = linesOfCodePushed;
            return $"Great day, you pushed {LinesOfCodePushed} lines of code today, and your pull request was merged in.";
        }

        public string LeaveMessage(string message)
        {
            return message;
        }
    }
}
