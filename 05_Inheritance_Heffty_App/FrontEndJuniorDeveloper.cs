using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Heffty_App
{
    public class FrontEndJuniorDeveloper : JuniorDeveloper
    {
        public FrontEndJuniorDeveloper(string name, LanguageType language) : base(name, language)
        {
            HasDoneCSharpTraining = false;
        }

        public bool HasDoneCSharpTraining { get; set; }

        public void SetHasDoneCSharpTraining(bool state)
        {
            HasDoneCSharpTraining = state;
        }

        public bool CheckCSharpTrainingStatus()
        {
            Console.WriteLine(HasDoneCSharpTraining ? $"{this.Name} has completed C# Training" : $"{this.Name} has not completed C# Training");
            return HasDoneCSharpTraining;
        }
    }
}
