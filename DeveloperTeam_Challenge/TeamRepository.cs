using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam_Challenge
{
    public class TeamRepository
    {

        protected List<DeveloperTeam> __teamDirectory = new List<DeveloperTeam>();
        protected List<Developer> _memberDirectory = new List<Developer>();
        //C -create

        public DeveloperTeam AddTeams(DeveloperTeam teams) // add teams to directory
        {

            __teamDirectory.Add(teams);
            return teams;

        }

        public Developer AddDevelopers(Developer name) // adds developers to member directory
        {
            _memberDirectory.Add(name);
            return name;
        }


        //R

        public List<DeveloperTeam> GetTeams() //returns all teams
        {
            return __teamDirectory;
        }

        public List<Developer> GetMembers()// returns all the developers
        {
            return _memberDirectory;

        }

        public DeveloperTeam GetByTeamID(int i)
        {
            foreach (DeveloperTeam team in __teamDirectory)
            {
                if (team.TeamId == i)
                {
                    return team;
                }
            }
            return null;
        }


        public Developer GetID(int i)// gets developer by id
        {
            foreach (Developer member in _memberDirectory)
            {
                if (member.DeveloperId == i) // in order to set all these parameters equal you need to use dot operators
                {
                    return member;
                }
            }
            return null;
        }

        public DeveloperTeam GetTeamByName(string name) // get developer teams by name
        {
            foreach (DeveloperTeam group in __teamDirectory)
            {
                if (group.TeamName == name)
                {
                    return group;
                }
            }
            return null;
        }

        public Developer GetDeveloperByLastName(string name)
        {
            foreach (Developer p in _memberDirectory)
            {
                if (p.LastName == name)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Developer> AddMembers(Developer d)
        {
            List<Developer> teamList = new List<Developer>();
            foreach (Developer r in _memberDirectory)
            {
                teamList.Add(r);
            }
            return null;
        }

        //public List<DeveloperTeam> WholeTeams(DeveloperTeam r)
        //{
        //    List<DeveloperTeam> wholeTeam = new List<DeveloperTeam>();
        //    foreach (DeveloperTeam r in __teamDirectory)
        //    {
        //        wholeTeam.Add(r);
        //    }
        //    return null;
        //}

        public List<Developer> GetTeamMemberByAccess(Developer access)
        {
            List<Developer> accessList = new List<Developer>();
            if (access.HasAccess == true)
            {
                accessList.Add(access);
            }

            return accessList;
        }


        //U update
        public bool UpdateTeams(string teamName, DeveloperTeam newTeam)
        {
            DeveloperTeam oldTeams = GetTeamByName(teamName); //creates new instance of the developerTeam with the Team name which is set equal to the names
            if (oldTeams != null)
            {
                oldTeams.TeamId = newTeam.TeamId;
                oldTeams.TeamName = newTeam.TeamName;
                oldTeams.TeamMembers = newTeam.TeamMembers;
                return true;
            }

            else
            {
                return false;
            }

        }

        //D Delete
        public bool DeleteTeams(DeveloperTeam existingTeam)
        {
            bool deleteTeam = __teamDirectory.Remove(existingTeam); // the bool that is true if team is successfully otherwise the bool will return false;
            return deleteTeam;
        }
    }
}
