using CinemaProject.DataLayer.Context.Initializers;
using CinemaProject.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            CinemaInitializer.Initialize(this);
        }
        #region DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmStory> FilmStories { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Show> Shows { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentAPI
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            #endregion
        }
    }
}
