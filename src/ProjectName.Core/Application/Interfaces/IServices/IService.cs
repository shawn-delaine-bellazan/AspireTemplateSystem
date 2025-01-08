using ProjectName.Core.Domain.Entities;

namespace ProjectName.Core.Application.Interfaces.IServices
{
    public interface IService<TENTITY> where TENTITY : BaseEntity
    {
        Task AddAsync(TENTITY entity);
        Task UpdateAsync(TENTITY entity);
        Task DeleteAsync(TENTITY entity);
        Task<TENTITY?> GetAsync(Guid id);
        Task<IEnumerable<TENTITY>> GetAsync();
    }
}