using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_1
{
    interface IPerson<T>
    {
        bool Create(T model);

        T GetById(int id);

        IEnumerable<T> GetAll();

        bool Update(T model);

        bool Delete(int id);
    }
}
