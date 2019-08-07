using Microsoft.EntityFrameworkCore;
using SkandauLyrics.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkandauLyrics.Data
{
    public class SkandauLyricsDbContext : DbContext
    {
        public DbSet<Singer> Singers { get; set; }

        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbSettings.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Singer>()
                .HasKey(singer => singer.Id);

            modelBuilder.Entity<Song>()
               .HasKey(song => song.Id);

            modelBuilder.Entity<Song>()
               .HasOne(singer => singer.Singer)
               .WithMany(song => song.Songs)
               .HasForeignKey(key => key.SingerId); ;

            base.OnModelCreating(modelBuilder);
        }
    }
}