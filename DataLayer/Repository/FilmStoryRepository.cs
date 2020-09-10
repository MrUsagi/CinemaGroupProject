using CinemaProject.DataLayer.Context;
using CinemaProject.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataLayer.Repository
{
    public class FilmStoryRepository:BaseRepository<FilmStory>
    {
        public FilmStoryRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<FilmStory>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Show)
                .Include(x => x.User)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<FilmStory>> FindByConditionAsync(Expression<Func<FilmStory, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Show)
                .Include(x => x.User)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
