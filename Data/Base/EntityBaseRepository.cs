
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

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

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
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

        public Task<T> UpdateAsync(int id, T newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
