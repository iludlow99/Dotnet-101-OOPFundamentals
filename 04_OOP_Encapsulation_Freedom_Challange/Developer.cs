using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Freedom_Challange
{
    public class Developer
    {
        public string Name { get; set; }
        public decimal Balance { get; set; } = 100m;

        private List<Course> _courses = new List<Course>();

        public Developer(string name)
        {
            Name = name;
        }

        public void AddCoursesToDeveloperCourseList(Course course)
        {
            _courses.Add(course);

            if ((Balance -= course.Price) <= 0)
            {
                throw new ArgumentOutOfRangeException("Course costs too much! You don't have enough money to buy this course");
            }
        }
    }
}
