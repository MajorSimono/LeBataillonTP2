using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class TeamMockData
    {
        public static List<Team> GetTeamsTest()
        {
            var _Teams = new List<Team>()
            {
                new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Magen",
                    CaptainId = 1

                },
                  new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Marielle",
                    CaptainId = 10

                },
                  new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Tonita",
                    CaptainId = 20

                },
                  new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Tonita",
                    CaptainId = 30

                },
                  new Team()
                {
                    Id = 1,
                    TeamName = "Équipe de Conrad",
                    CaptainId = 40

                },
            };
            return _Teams;
        }

    }
}