using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Badge_Challange
{
    public class CBadge : Badge
    {
        public CBadge()
        {
            HasAccessTo = AccessTo.Level3;
        }
    }
}
