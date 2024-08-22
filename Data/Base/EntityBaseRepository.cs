
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
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context
                .Set<T>()
                .OrderBy(a => a.Id)
                .LastOrDefaultAsync(a => a.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context
                .Set<T>()
                .ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context
                .Set<T>()
                .OrderBy(a => a.Id)
                .LastOrDefaultAsync(a => a.Id == id);
            return result;
        }        

        public async Task UpdateAsync(int id, T newEntity)
        {
            EntityEntry entityEntry = _context.Entry<T>(newEntity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
