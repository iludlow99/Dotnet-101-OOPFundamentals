using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Freedom_Challange
{
    public class Course
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Course(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
