using ProjectName.Core.Application.Interfaces.IRepositories;
using ProjectName.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ProjectName.Core.Application.UnitOfWork
{
    public interface IUnitOfWork<TENTITY> : IDisposable where TENTITY : BaseEntity
    {
        IRepository<TENTITY> Repository { get; }

        Task<int> SaveChangesAsync();

    }

}