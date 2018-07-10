using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Badge_Challange
{
    public class ABadge : Badge
    {
        public ABadge()
        {
            HasAccessTo = AccessTo.Level1;
        }
    }
}
