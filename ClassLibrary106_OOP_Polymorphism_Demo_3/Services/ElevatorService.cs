using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary106_OOP_Polymorphism_Demo_3.Contracts;

namespace ClassLibrary106_OOP_Polymorphism_Demo_3.Services
{
    public class ElevatorService : ISwipeable
    {
        public void Accept()
        {
            throw new NotImplementedException();
        }

        public void Decline()
        {
            throw new NotImplementedException();
        }

        public void Swipe()
        {
            Console.WriteLine("Card was swiped in elevator");
        }
    }
}
