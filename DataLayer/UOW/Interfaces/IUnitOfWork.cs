using CinemaProject.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataLayer.UOW.Interfaces
{
    public interface IUnitOfWork
    {
        FilmRepository Films { get; }
        FilmStoryRepository FilmStory { get; }
        HallRepository Halls { get; }
        PlaceRepository Places { get; }
        RowRepository Rows { get; }
        ShowRepository Shows { get; }
        UserRepository Users { get; }
        Task SaveAsync();
    }
}
