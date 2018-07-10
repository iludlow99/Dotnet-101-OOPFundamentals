using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_1.Services
{
    class InstructorService : IPerson<Instrusctor>
    {
        public bool Create(Instrusctor model)
        {
            model.InstrusctorId = 1;
            return true;
        }

        public Instrusctor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instrusctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Instrusctor model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
