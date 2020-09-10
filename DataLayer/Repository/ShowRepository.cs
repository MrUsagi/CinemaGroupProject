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
    public class ShowRepository:BaseRepository<Show>
    {
        public ShowRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Show>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Hall)
                .Include(x => x.Film)
                .Include(x => x.Users)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Show>> FindByConditionAsync(Expression<Func<Show, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Hall)
                .Include(x=>x.Film)
                .Include(x=>x.Users)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
