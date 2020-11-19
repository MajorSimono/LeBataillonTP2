using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;
using LeBataillon.Database.Exceptions;

namespace LeBataillon.Database.Repository
{
    public interface ILeBataillonRepo
    {
        Player Add(Player player);

        Team Add(Team team);

        Game Add(Game game);

        Player GetPlayerById(int? id);

        bool RemovePlayer(int id);

        Team GetTeamById(int? id);

        bool RemoveTeam(int id);

        Game GetGameById(int? id);
        bool RemoveGame(int id);

        Player Edit(Player player);

        Team Edit(Team team);

        Game Edit(Game game);

        void PlayerExistsCheck(int? id);

        void TeamExistsCheck(int? id);

        void GameExistsCheck(int? id);

        List<Player> GetAllPlayers();

        List<Team> GetAllTeams();

        List<Game> GetAllGames();
    }

    public partial class LeBataillonRepo : ILeBataillonRepo
    {
        LeBataillonDbContext context;

        public LeBataillonRepo(LeBataillonDbContext context)
        {
            this.context = context;
        }

        public Player Add(Player player)
        {


            this.context.Players.Add(player);
            this.context.SaveChanges();

            return player;

        }

        public Team Add(Team team)
        {

            this.context.Teams.Add(team);
            this.context.SaveChanges();

            return team;
        }

        public Game Add(Game game)
        {

            this.context.Games.Add(game);
            this.context.SaveChanges();

            return game;
        }

        public Player Edit(Player player)
        {
            var el = this.GetPlayerById(player.Id);
            el.EditFrom(player);

            try
            {
                this.context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                this.PlayerExistsCheck(player.Id);
                throw;
            }

            return el;


        }

        public Team Edit(Team team)
        {
            var el = this.GetTeamById(team.Id);
            el.EditFrom(team);

            try
            {
                this.context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                this.TeamExistsCheck(team.Id);
                throw;
            }
            return el;
        }

        public Game Edit(Game game)
        {
            var el = this.GetGameById(game.Id);
            el.EditFrom(game);
            try
            {
                this.context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                this.GameExistsCheck(game.Id);
                throw;
            }
            return el;
        }

        public void GameExistsCheck(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Game)} : {id} not found");
            var el = this.context.Games.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Game)} : {id} not found");

        }

        public List<Game> GetAllGames()
        {
            return this.context.Games.ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return this.context.Players.ToList();
        }

        public List<Team> GetAllTeams()
        {
            return this.context.Teams.ToList();
        }

        public Game GetGameById(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Game)} : {id} not found");
            var el = this.context.Games.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Game)} : {id} not found");
            return el;
        }

        public Player GetPlayerById(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Player)} : {id} not found");
            var el = this.context.Players.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Player)} : {id} not found");
            return el;
        }

        public Team GetTeamById(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Team)} : {id} not found");
            var el = this.context.Teams.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Team)} : {id} not found");
            return el;
        }

        public void PlayerExistsCheck(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Player)} : {id} not found");
            var el = this.context.Players.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Player)} : {id} not found");

        }

        public bool RemoveGame(int id)
        {
            var el = this.GetGameById(id);

            this.context.Games.Remove(el);
            this.context.SaveChanges();
            return true;
        }

        public bool RemovePlayer(int id)
        {
            var el = this.GetPlayerById(id);

            this.context.Players.Remove(el);
            this.context.SaveChanges();
            return true;
        }

        public bool RemoveTeam(int id)
        {
            var el = this.GetTeamById(id);

            this.context.Teams.Remove(el);
            this.context.SaveChanges();
            return true;
        }

        public void TeamExistsCheck(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Team)} : {id} not found");
            var el = this.context.Teams.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Team)} : {id} not found");

        }
    }
}