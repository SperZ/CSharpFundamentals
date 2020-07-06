using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam_Challenge
{
    public class DeveloperTeam
    {
        public string TeamName { get; set; }

        public int TeamId { get; set; }

        public List<Developer> TeamMembers{get; set;}

        public DeveloperTeam(){}// class is not applicable it will throw error

        public DeveloperTeam(string teamName, int teamId, List<Developer> teamMembers)
        {
            TeamName = teamName;
            TeamId= teamId;
            TeamMembers = teamMembers;   
          

        }

    }

    public class Developer
    {
        public int DeveloperId {get; set;}
        public string LastName { get; set; }
        public bool HasAccess { get; set; }
    }


}
