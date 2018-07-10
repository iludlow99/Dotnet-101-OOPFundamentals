using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Define_Classes_Exercise_3
{
    public class Customer
    {
        public int KomodoId { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsWithKomodo { get; set; }

        public Customer(int komodoId, string lastName, int age, int yearsWithKomodo)
        {
            KomodoId = komodoId;
            LastName = lastName;
            Age = age;
            YearsWithKomodo = yearsWithKomodo;
        }
    }
}
