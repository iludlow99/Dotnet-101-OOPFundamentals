using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_ClassesExercise_2
{
    public class Team
    {
        private List<List<Team>> _listOfTeams = new List<List<Team>>();

        public void AddTeamToTeamList(List<Team> team)
        {
            _listOfTeams.Add(team);
        }

        public List<List<Team>> ReturnTeamList()
        {
            List<List<Team>> TeamListToBeReturned = new List<List<Team>>();

            foreach (var team in _listOfTeams)
            {
                TeamListToBeReturned.Add(team);
            }

            return TeamListToBeReturned;
        }

        public void AddingDeveloperToLists(Developer developer)
        {
            var developerTeam = new DeveloperTeam();
            developerTeam.AddDevelopers(developer);

            //this.AddTeamToTeamList(developerTeam);
        }



        public void CreateDeveloper(int id, string lastName, bool hasPluralsight)
        {
            var developer = new Developer(id, lastName, hasPluralsight);

            AddingDeveloperToLists(developer);
        }
    }
}
