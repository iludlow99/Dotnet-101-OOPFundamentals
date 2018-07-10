using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Heffty_App
{
    public class FrontEndSeniorDeveloper : SeniorDeveloper
    {
        public FrontEndSeniorDeveloper(string name, LanguageType language) : base(name, language)
        {
            HasDoneLessons = false;
        }

        public bool HasDoneLessons { get; set; }

        public void SetHasDoneLessons(bool state)
        {
            HasDoneLessons = state;
        }

        public string CheckHasDoneLessons()
        {
            return HasDoneLessons ? $"{this.Name} has completed their lessons" : $"{this.Name} has not completed their lessons";
        }
    }
}
