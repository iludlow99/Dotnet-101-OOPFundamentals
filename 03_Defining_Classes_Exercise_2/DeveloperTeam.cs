using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_ClassesExercise_2
{
    public class DeveloperTeam : Team
    {
        private List<Developer> _developerTeamList = new List<Developer>();

        public void AddDevelopers(Developer developer)
        {
            _developerTeamList.Add(developer);
        }

        public List<Developer> ReturnDeveloperList()
        {
            List<Developer> DeveloperListToBeReturned = new List<Developer>();

            foreach (var privateDeveloper in _developerTeamList)
            {
                DeveloperListToBeReturned.Add(privateDeveloper);
            }

            return DeveloperListToBeReturned;
        }
    }
}
