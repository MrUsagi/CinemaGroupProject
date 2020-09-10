﻿using CinemaProject.DataLayer.Context;
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
    public class FilmRepository:BaseRepository<Film>
    {
        public FilmRepository(CinemaContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Film>> GetAllAsync()
        {
            return await this.Entities
                .Include(sh => sh.Shows)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Film>> FindByConditionAsync(Expression<Func<Film, bool>> predicat)
        {
            return await this.Entities
                .Include(sh => sh.Shows)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
