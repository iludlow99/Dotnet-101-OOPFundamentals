using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Badge_Challange
{
    public class BBadge : Badge
    {
        public BBadge()
        {
            HasAccessTo = AccessTo.Level2;
        }
    }
}
