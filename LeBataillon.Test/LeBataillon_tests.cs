using System;
using System.Collections.Generic;
using LeBataillon.Database.MockData;
using LeBataillon.Database.Models;
using LeBataillon.Database.Repository;
using LeBataillon.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace LeBataillon.Test
{
    public class LeBataillon_Tests
    {
        [Fact]
        public void PlayerIndex_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlayerIndexList_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);

            var result = controller.Index();

            var viewresult = result as ViewResult;
            Assert.IsAssignableFrom<List<Player>>(viewresult.ViewData.Model);
        }

        [Fact]
        public void PlayerIndexNombre_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);

            var result = controller.Index();

            var viewResult = result as ViewResult;
            var viewResultPlayers = viewResult.ViewData.Model as List<Player>;
            Assert.Equal(5, viewResultPlayers.Count);
        }

        [Fact]
        public void PlayerDetails_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);


            var result = controller.Details(1);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void PlayerCreate_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);


            var result = controller.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlayerDelete_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllPlayers()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayerController(mockRepo.Object);


            var result = controller.Delete(1);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void TeamIndex_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TeamIndexList_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);

            var result = controller.Index();

            var viewresult = result as ViewResult;
            Assert.IsAssignableFrom<List<Team>>(viewresult.ViewData.Model);
        }

        [Fact]
        public void TeamIndexNombre_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);

            var result = controller.Index();

            var viewResult = result as ViewResult;
            var viewResultTeams = viewResult.ViewData.Model as List<Team>;
            Assert.Equal(5, viewResultTeams.Count);
        }

        [Fact]
        public void TeamDetails_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);


            var result = controller.Details(1);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void TeamCreate_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);


            var result = controller.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TeamDelete_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllTeams()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamController(mockRepo.Object);


            var result = controller.Delete(1);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void GameIndex_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void GameIndexList_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);

            var result = controller.Index();

            var viewresult = result as ViewResult;
            Assert.IsAssignableFrom<List<Game>>(viewresult.ViewData.Model);
        }

        [Fact]
        public void GameIndexNombre_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);

            var result = controller.Index();

            var viewResult = result as ViewResult;
            var viewResultGames = viewResult.ViewData.Model as List<Game>;
            Assert.Equal(5, viewResultGames.Count);
        }

        [Fact]
        public void GameDetails_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);


            var result = controller.Details(1);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void GameCreate_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);


            var result = controller.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void GameDelete_Test()
        {
            var mockRepo = new Mock<ILeBataillonRepo>();
            mockRepo.Setup(n => n.GetAllGames()).Returns(GameMockData.GetGamesTest());
            var controller = new GameController(mockRepo.Object);


            var result = controller.Delete(1);

            Assert.IsType<ViewResult>(result);
        }

    }
}