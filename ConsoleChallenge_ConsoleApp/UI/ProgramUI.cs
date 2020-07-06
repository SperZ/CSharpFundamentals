using DeveloperTeam_Challenge;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChallenge_ConsoleApp
{
    class ProgramUI
    {
        private readonly TeamRepository _teamRepository = new TeamRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueRun = true;
            while (continueRun)
            {

                Console.WriteLine("Choose a number below \n" +
                    "1) Create New Teams \n" +
                    "2) Get Teams by ID \n" +
                    "3) Get Teams by Team Name \n" +
                    "4) Get Member by Last Name \n" +
                    "5) Get Member by ID \n" +
                    "6) Get Individual by Access Type \n" +
                    "7) Update Teams \n" +
                    "8) Update Members \n" +
                    "9) Delete Existing an Existing Team \n" +
                    "10) Delete an Existing Member \n" +
                    "11) Exit Program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    //case "1":
                    //   CreateNewTeams();
                    //    break;
                    case "2":
                        GetTeamsByID();
                        break;
                    case "3":
                        GetTeamsByTeamName();
                        break;
                    case "4":
                        GetMemberByLastName();
                        break;
                    case "5":
                        GetMemberById();
                        break;
                    //case "6":
                    //    GetMemberByAccess();
                    //    break;
                    //case "7":
                    //    UpdateExistingTeams();
                    //    break;
                    //case "8":
                    //    UpdateExistingMembers();
                    //case "9":
                    //    DeleteExistingTeams();
                    //case "10":
                    //    DeleteExistinMembers();
                    case "11":
                        break;
                    case "12":
                        break;
                    default:
                        Console.WriteLine("The option you choose is invalid. Press any key to continue....");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //private void CreateNewTeams()
        //{
        //    Console.Clear(); // Creates a blank console
        //    DeveloperTeam newTeam = new DeveloperTeam();
        //    Console.WriteLine("Enter the name of the team you are creating");
        //    newTeam.TeamName = Console.ReadLine();

        //    Console.WriteLine("Enter the number ID given to the team");
        //    newTeam.TeamId = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Who are the Team members");
        //    Developer newDeveloper = new Developer();
        //    newDeveloper.LastName = Console.ReadLine();
        //    newTeam.TeamMembers = newTeam.TeamMembers.Add(newDeveloper);

        //}

        private void GetTeamsByTeamName()
        {
            Console.WriteLine("Enter the name of the team whose information you desire.");
            string teamName = Console.ReadLine();
            DeveloperTeam teamFound = _teamRepository.GetTeamByName(teamName);
            if(teamFound != null)
            {
                DisplayTeams(teamFound);
            }

            else
            {
                Console.WriteLine("The team you area looking for cannot be found.");
            }

        }

        private void GetTeamsByID()
        {
            Console.WriteLine("Enter the id of the team whose information you seek.");
            int id = int.Parse(Console.ReadLine());
            DeveloperTeam teamId = _teamRepository.GetByTeamID(id);
            if(teamId != null)
            {
                DisplayTeams(teamId);
            }
            else
            {
                Console.WriteLine("The ID you are searching for does not correspond with any team in our database.");
            }

        }

        private void DisplayTeams(DeveloperTeam teams)
        {
            DeveloperTeam team = new DeveloperTeam();
            Console.WriteLine($"Team Name:{team.TeamName} \n" +
                $"Team Id: {team.TeamId} \n" +
                $"Team Members: {team.TeamMembers}");
        }


        private void GetMemberByLastName()
        {
            Console.WriteLine("What is the last name of the developer you are looking for?");
            string lastName = Console.ReadLine();
            Developer nameFound = _teamRepository.GetDeveloperByLastName(lastName);
            if(nameFound != null)
            {
                DisplayIndividuals(nameFound);
            }

        }

        private void GetMemberById()
        {
            Console.WriteLine("What is the numerical ID of the developer you are looking for.");
            int devID = int.Parse(Console.ReadLine());
            Developer foundId = _teamRepository.GetID(devID);
            if(foundId != null)
            {
                DisplayIndividuals(foundId);
            }

            else
            {
                Console.WriteLine("The is no developer that corresponds to that numerical ID."); 
            } 
        }

        //private void GetMembersByAccess()
        //{
        //    Console.WriteLine
        //    Developer acces= _teamRepository.GetTeamMemberByAccess()
            
        //}

        private void DisplayIndividuals(Developer info)
        {
            Developer information = new Developer();
            Console.WriteLine($"Developer Name:{information.LastName} \n" +
                $"Developer ID:{information.DeveloperId} \n" +
                $"Developer's Accessbility: {information.HasAccess}");
        }


        private void DeleteExistinTeam()
        {
            Console.WriteLine("Enter the number of the Team you would like to delete");
            List<DeveloperTeam> teamList = _teamRepository.GetTeams();

            int count = 0;
            foreach(DeveloperTeam team in _teamRepository.GetTeams())
            {
                count++;
                Console.WriteLine($"{count} {team.TeamName}");
            }

            int teamTarget = int.Parse(Console.ReadLine());
            int teamIndex = teamTarget - 1; // because index counts start at 0 the number they enter will be 1 higher than the index of the item they wish to delete thus we have to subtract on for the the item they are targeting to get the index of the item they are targeting.



        }
    }
}
