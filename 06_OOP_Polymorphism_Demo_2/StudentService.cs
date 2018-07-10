using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    class StudentService : IStudentService
    {
        public bool Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
