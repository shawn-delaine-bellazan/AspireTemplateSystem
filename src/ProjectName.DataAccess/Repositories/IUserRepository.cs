
using ProjectName.Core.Application.Interfaces.IRepositories;
using ProjectName.Core.Domain.Entities;

namespace ProjectName.DataAccess.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
    }
}
