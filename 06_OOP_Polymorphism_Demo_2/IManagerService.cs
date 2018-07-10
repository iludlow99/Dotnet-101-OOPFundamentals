using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    interface IManagerService
    {
        bool Create(Manager manager);
        Manager GetById(int managerId);
        IEnumerable<Manager> GetAll();
        bool Update(Manager manager);
        bool Delete(int managerId);
    }
}
