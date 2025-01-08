
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectName.Core.Application.Interfaces.IRepositories;
using ProjectName.Core.Application.UnitOfWork;
using ProjectName.Core.Domain.Entities;

namespace ProjectName.DataAccess.Repositories
{
    public class GenericRepository<TENTITY> : IRepository<TENTITY> where TENTITY : BaseEntity
    {
        private readonly DbContext _context;
        private DbSet<TENTITY> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TENTITY>();
        }

        public async Task AddAsync(TENTITY entity) => await _entities.AddAsync(entity);
        public async Task DeleteAsync(TENTITY entity) => await Task.Run(() => _entities.Remove(entity));

        public async Task<IEnumerable<TENTITY>> FindAsync(Expression<Func<TENTITY, bool>> predicate) => await _entities.Where(predicate).ToListAsync();

        public async Task<IEnumerable<TENTITY>> GetAsync() => await _entities.ToListAsync();

        public async Task<TENTITY?> GetAsync(Guid id) => await _entities.FindAsync(id);

        public async Task UpdateAsync(TENTITY entity) => await Task.Run(() => _entities.Update(entity));
    }
}
    
