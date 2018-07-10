using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Heffty_App
{
    public abstract class SeniorDeveloper : Developer
    {
        public SeniorDeveloper(string name, LanguageType language) : base(name, language)
        {
        }
    }
}
