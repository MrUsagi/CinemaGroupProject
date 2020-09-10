using CinemaProject.DataLayer.Context;
using CinemaProject.DataLayer.Repository;
using CinemaProject.DataLayer.UOW.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataLayer.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CinemaContext _context;
        public UnitOfWork(CinemaContext context, FilmRepository film,
            FilmStoryRepository filmStory,
            HallRepository hall,
            PlaceRepository place,
            RowRepository row,
            ShowRepository show,
            UserRepository user)
        {
            _context = context;
            Films = film;
            FilmStory = filmStory;
            Halls = hall;
            Places = place;
            Rows = row;
            Shows = show;
            Users = user;

        }
        public FilmRepository Films { get; }

        public FilmStoryRepository FilmStory { get; }

        public HallRepository Halls { get; }

        public PlaceRepository Places { get; }

        public RowRepository Rows { get; }

        public ShowRepository Shows { get; }

        public UserRepository Users { get; }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
