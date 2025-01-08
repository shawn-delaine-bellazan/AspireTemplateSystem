using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectName.Core.Application.Interfaces.IServices;
using ProjectName.Core.Application.UnitOfWork;
using ProjectName.Core.Domain.Entities;

namespace ProjectName.Core.Application.Services
{
    public class GenericService<TENTITY> : IService<TENTITY> where TENTITY : BaseEntity
    {
        private readonly IUnitOfWork<TENTITY> _unitOfWork;

        protected GenericService(IUnitOfWork<TENTITY> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(TENTITY entity)
        {
            await _unitOfWork.Repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(TENTITY entity)
        {
            var entityToDelete = await _unitOfWork.Repository.GetAsync(Guid.Parse(entity.Id));

            if (entityToDelete != null)
            {
                await _unitOfWork.Repository.DeleteAsync(entityToDelete);
                await _unitOfWork.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<TENTITY>> GetAsync() => await _unitOfWork.Repository.GetAsync();

        public async Task<TENTITY?> GetAsync(Guid id) => await _unitOfWork.Repository.GetAsync(id);

        public async Task UpdateAsync(TENTITY entity)
        {
            await _unitOfWork.Repository.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}