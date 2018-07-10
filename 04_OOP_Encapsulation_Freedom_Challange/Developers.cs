using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Freedom_Challange
{
    public class Developers
    {
        private List<Developer> _developers = new List<Developer>();

        public void AddDeveloperToDevelopersList(Developer developer)
        {
            _developers.Add(developer);
        }

        public List<Developer> GetList()
        { 
            return _developers;
        }
    }
}
