using System.Collections.Generic;

namespace SoccerManageApp.Dtos
{
    public class CreateTeamView
    {
        
        public string TeamName { get; set; }
        public string TeamImage{get;set;}
        public string Creator{get;set;}
        public int StadiumID { get; set; }
        public string StadiumName{get;set;}

    }
}