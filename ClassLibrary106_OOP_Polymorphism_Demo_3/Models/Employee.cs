using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary106_OOP_Polymorphism_Demo_3.Contracts;

namespace ClassLibrary106_OOP_Polymorphism_Demo_3.Models
{
    public class Employee
    {
        private ISwipeable _swipeable;

        public Employee(ISwipeable swipeable)
        {
            _swipeable = swipeable;
        }

        public void SwipeCard()
        {
            Console.WriteLine("Swiping card...");
            _swipeable.Swipe();
        }
    }
}
