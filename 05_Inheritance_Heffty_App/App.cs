using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Heffty_App
{
    public class App
    {
        public string Name { get; private set; }
        public AppStatus AppStatus { get; private set; }
        public LanguageType Language { get; private set; }

        private List<Developer> _developers = new List<Developer>();

        public void AddDeveloper(Developer developer)
        {
            _developers.Add(developer);
        }

        public AppStatus CheckAppStatus()
        {
            return AppStatus;
        }
    }
}
