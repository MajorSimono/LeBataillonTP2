using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public static class GameMockData
    {

        public static List<Game> GetGamesTest()
        {
            var _games = new List<Game>()
            {
                new Game()
                {
                    Id = 1,
                    GameDateTime = DateTime.Today.AddDays(1),
                    TeamAttackerId = 1,
                    TeamDefendantId = 2
                },
                  new Game()
                {
                    Id = 1,
                    GameDateTime = DateTime.Today.AddDays(2),
                    TeamAttackerId = 3,
                    TeamDefendantId = 4
                },
                  new Game()
                {
                    Id = 1,
                    GameDateTime = DateTime.Today.AddDays(3),
                    TeamAttackerId = 5,
                    TeamDefendantId = 6
                },
                  new Game()
                {
                    Id = 1,
                    GameDateTime = DateTime.Today.AddDays(4),
                    TeamAttackerId = 7,
                    TeamDefendantId = 8
                },
                  new Game()
                {
                    Id = 1,
                    GameDateTime = DateTime.Today.AddDays(5),
                    TeamAttackerId = 9,
                    TeamDefendantId = 1
                }
            };
            return _games;
        }

    }
}