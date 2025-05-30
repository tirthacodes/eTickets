﻿
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.id == id);
            EntityEntry entitiyEntry = _context.Entry<T>(entity);
            entitiyEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async virtual Task<T> GetByIdAsync(int id) =>  await _context.Set<T>().FirstOrDefaultAsync(n => n.id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entitiyEntry = _context.Entry<T>(entity);
            entitiyEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();

        }


    }
}
