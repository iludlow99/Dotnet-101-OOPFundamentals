using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Heffty_App
{
    public abstract class Developer
    {
        private List<App> _apps = new List<App>();
        private List<Enum> _skills = new List<Enum>();
        public string Name { get; private set; }
        public LanguageType Language { get; private set; }
        public bool HasDoneOrientation { get; private set; }
        public int PluralSightHours { get; set; }

        public Developer(string name, LanguageType language)
        {
            Name = name;
            Language = language;
            HasDoneOrientation = false;
        }

        public void AddApp(App app)
        {
            _apps.Add(app);
        }

        public void AddSkill(Enum skillEnum)
        {
            _skills.Add(skillEnum);
        }

        public void SetHasDoneOrientation(bool state)
        {
            HasDoneOrientation = state;
        }

        //Check properties and lists methods
        public List<App> CheckAppList()
        {
            return _apps;
        }

        public List<Enum> CheckSkillList()
        {
            return _skills;
        }

        public void CheckOrientationStatus()
        {
            Console.WriteLine(HasDoneOrientation ? $"{this.Name} has completed orientation" : $"{this.Name} has not completed orientation");
        }

        public void AddPluralSightHours(int hours)
        {
            PluralSightHours += hours;
        }

        public int CheckPluralSightHours()
        {
            return PluralSightHours;
        }

        public void ResetPluralSightHours()
        {
            PluralSightHours = 0;
        }
    }
}
