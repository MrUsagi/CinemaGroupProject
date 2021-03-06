﻿using CinemaProject.DataLayer.Context;
using CinemaProject.DataLayer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataLayer.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _entities;
        private CinemaContext _context;
        protected DbSet<TEntity> Entities => this._entities ??= _context.Set<TEntity>();
        protected BaseRepository(CinemaContext context)
        {
            _context = context;
        }
        public virtual async Task CreateAsync(TEntity entity)
        {
            await Entities.AddAsync(entity).ConfigureAwait(false);
        }

        public virtual async Task<IReadOnlyCollection<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> predicat)
        {
            return await this.Entities.Where(predicat).ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<IReadOnlyCollection<TEntity>> GetAllAsync()
        {
            return await this.Entities.ToListAsync().ConfigureAwait(false);
        }
    }
}
