using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using P03_FootballBetting.Data.Models;
using P03_FootballBetting.Configurations;

namespace P03_FootballBetting.Data  
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Bet
            modelBuilder.Entity<Bet>(entity =>
            {
                entity.HasKey(e => e.BetId);

                // One Game can have many Bets (One to Many)
                entity.HasOne(e => e.Game)
                    .WithMany(u => u.Bets)
                    .HasForeignKey(e => e.GameId);

                // One User can have many Bets (One to Many)
                entity.HasOne(u => u.User)
                    .WithMany(e => e.Bets)
                    .HasForeignKey(e => e.UserId);
            });

            // Color
            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.ColorId);
            });

            // Country
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);
            });

            // Game
            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.GameId);

                // One HomeTeam can have many HomeGames (One to Many)
                entity.HasOne(e => e.HomeTeam)
                    .WithMany(ht => ht.HomeGames)
                    .HasForeignKey(e => e.HomeTeamId);

                // One AwayTeam can have many AwayGames (One to Many)
                entity.HasOne(e => e.AwayTeam)
                    .WithMany(at => at.AwayGames)
                    .HasForeignKey(e => e.AwayTeamId);
            });

            // Player
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                // One Team can have many Players (One to Many)
                entity.HasOne(e => e.Team)
                    .WithMany(t => t.Players)
                    .HasForeignKey(e => e.TeamId);

                // One Position can have many Players (One to Many)
                entity.HasOne(e => e.Position)
                    .WithMany(p => p.Players)
                    .HasForeignKey(e => e.PositionId);
            });

            // Position
            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PositionId);
            });

            // PlayerStatistic
            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.GameId });

                // One Player can have many PlayerStatistics (One to Many)
                entity.HasOne(e => e.Player)
                    .WithMany(p => p.PlayerStatistics)
                    .HasForeignKey(e => e.PlayerId);

                // One Game can have many PlayerStatistics (One to Many)
                entity.HasOne(e => e.Game)
                    .WithMany(g => g.PlayerStatistics)
                    .HasForeignKey(e => e.GameId);
            });

            // Team
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                // One Town can have many Teams (One to Many)
                entity.HasOne(e => e.Town)
                    .WithMany(t => t.Teams)
                    .HasForeignKey(e => e.TownId);

                // One PrimaryKitColor can have many PrimaryKitTeams (One to Many)
                entity.HasOne(e => e.PrimaryKitColor)
                    .WithMany(pkc => pkc.PrimaryKitTeams)
                    .HasForeignKey(e => e.PrimaryKitColorId);

                // One SecondaryKitColor can have many SecondaryKitTeams (One to Many)
                entity.HasOne(e => e.SecondaryKitColor)
                    .WithMany(skc => skc.SecondaryKitTeams)
                    .HasForeignKey(e => e.SecondaryKitColorId);
            });

            // Town
            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(e => e.TownId);

                // One Country can have many Towns (One to Many)
                entity.HasOne(e => e.Country)
                    .WithMany(c => c.Towns)
                    .HasForeignKey(e => e.TownId);
            });

            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });
        }
    }   
}
