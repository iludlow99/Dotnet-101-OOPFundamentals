using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class SalesMembersRepository
    {
        private List<SalesMembers> _salesMembers;

        public SalesMembersRepository()
        {
            _salesMembers = new List<SalesMembers>();
        }

        public void AddToList(SalesMembers salesMember)
        {
            _salesMembers.Add(salesMember);
        }

        public decimal CalculateTotalSales()
        {
            decimal total = 0;

            foreach (var salesMember in _salesMembers)
            {
                total += salesMember.SalesForTheMonth;
                     
            }

            return total;
        }
    }
}
