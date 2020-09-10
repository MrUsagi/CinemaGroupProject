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
    public class PlaceRepository:BaseRepository<Place>
    {
        public PlaceRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Place>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Row)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Place>> FindByConditionAsync(Expression<Func<Place, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Row)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
