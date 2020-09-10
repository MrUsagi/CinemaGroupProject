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
    public class RowRepository:BaseRepository<Row>
    {
        public RowRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Row>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Places)
                .Include(x=>x.Hall)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Row>> FindByConditionAsync(Expression<Func<Row, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Places)
                .Include(x => x.Hall)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
