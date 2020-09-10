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
    public class HallRepository:BaseRepository<Hall>
    {
        public HallRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Hall>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Shows)
                .Include(x => x.Rows)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Hall>> FindByConditionAsync(Expression<Func<Hall, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Shows)
                .Include(x => x.Rows)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
