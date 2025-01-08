namespace ProjectName.Core.Application.Interfaces.IRepositories
{
    public interface IRepository<TENTITY> where TENTITY : BaseEntity
    {
        Task AddAsync(TENTITY entity);
        Task UpdateAsync(TENTITY entity);
        Task DeleteAsync(TENTITY entity);
        Task<TENTITY?> GetAsync(Guid id);
        Task<IEnumerable<TENTITY>> GetAsync();
        Task<IEnumerable<TENTITY>> FindAsync(Expression<Func<TENTITY, bool>> predicate);
    }
}
