using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Badge_Challange
{
    public class BadgeRepo
    {
        private List<Badge> _badges = new List<Badge>();

        public void AddBadge(Badge badge)
        {
            _badges.Add(badge);
        }

        public List<Badge> ReturnBadgeList()
        {
            return _badges;
        }

        public bool AccessFloor(Badge badge, AccessTo level)
        {
            if (badge.HasAccessTo == level)
                return true;
            else
                return false;
        }
    }
}
