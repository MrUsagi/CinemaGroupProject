using CinemaProject.DataLayer.Context.Initializers;
using CinemaProject.DataLayer.Models;
using CinemaProject.DataLayer.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public DbSet<Row> Places { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<ShowSeats> ShowSeats { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentAPI
            #region Primary Keys
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Film>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<FilmStory>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Hall>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Row>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Row>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Show>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<ShowSeats>()
                .HasKey(x => x.Id);
            #endregion
            #region Relations
            modelBuilder.Entity<User>()
                .HasMany(x => x.FilmHistory)
                .WithOne(x => x.User);
            modelBuilder.Entity<FilmStory>()
                .HasOne(x => x.User)
                .WithMany(x => x.FilmHistory)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<FilmStory>()
                .HasOne(x => x.Show)
                .WithMany(x => x.Users)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Film>()
                .HasMany(x => x.Shows)
                .WithOne(x => x.Film);
            modelBuilder.Entity<Show>()
                .HasOne(x => x.Film)
                .WithMany(x => x.Shows)
                .HasForeignKey(x=>x.FilmId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Show>()
                .HasOne(x => x.Hall)
                .WithMany(x => x.Shows)
                .HasForeignKey(x=>x.HallId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Hall>()
                .HasMany(x => x.Shows)
                .WithOne(x => x.Hall);
            modelBuilder.Entity<Hall>()
                .HasMany(x => x.Rows)
                .WithOne(x => x.Hall);
            modelBuilder.Entity<Row>()
                .HasMany(x => x.Places)
                .WithOne(x => x.Row);
            modelBuilder.Entity<Row>()
                .HasOne(x => x.Hall)
                .WithMany(x => x.Rows)
                .HasForeignKey(x=>x.HallId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Place>()
                .HasOne(x => x.Row)
                .WithMany(x => x.Places)
                .HasForeignKey(x=>x.RowId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Place>()
                .HasMany(x => x.Shows)
                .WithOne(x => x.Seat)
                .HasForeignKey(x=>x.SeatId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Show>()
                .HasMany(x => x.Seats)
                .WithOne(x => x.Show)
                .HasForeignKey(x => x.ShowId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
            #region Another configuration
            modelBuilder.Entity<ShowSeats>()
                .Property(x => x.Status)
                .HasConversion(new EnumToStringConverter<Status>());
            #endregion
            #endregion
        }
    }
}
