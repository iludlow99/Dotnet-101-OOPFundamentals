using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_ClassesExercise_1
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumberOfYears { get; set; }

        public Employee(string lastName, int age, int numberOfYears)
        {
            var newGuid = Guid.NewGuid();

            EmployeeId = newGuid;
            LastName = lastName;
            Age = age;
            NumberOfYears = numberOfYears;
        }

        public Employee()
        {

        }
    }
}
