using System;
using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LeBataillon.Database.Context
{
    public class LeBataillonDbContext : DbContext
    {

        public LeBataillonDbContext(DbContextOptions<LeBataillonDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var players = new List<Player>();

            for (int i = 1; i < 100; i++)
            {

                var name = SampleData.GenerateName(i);
                var player = new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), name, SampleData.GenerateLastName(i), SampleData.GenerateLevel(), "Description du joueur");
                player.TeamId = (i <= 10) ? i : SampleData.GenerateInteger(i, 1, 10);
                players.Add(player);
            }

            modelBuilder.Entity<Player>().HasData(players);

            var teams = new List<Team>();
            for (int i = 1; i < 10; i++)
            {
                var capitain = players.Where(p => p.TeamId == i).First();

                var teamName = "Équipe de " + SampleData.GenerateName(i);
                teams.Add(new Team(i, teamName, capitain.Id, 10, "Description de l'éqiupe"));
            }
            modelBuilder.Entity<Team>().HasData(teams);

            var games = new List<Game>();

            games.Add(new Game(1, new DateTime(220, 10, 24), 1, 3, GameStatus.forthcoming));
            games.Add(new Game(2, new DateTime(220, 10, 24), 4, 6, GameStatus.forthcoming));
            games.Add(new Game(3, new DateTime(220, 10, 24), 7, 2, GameStatus.forthcoming));
            modelBuilder.Entity<Game>().HasData(games);
        }
    }
}