using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectName.Core.Application.Interfaces.IRepositories;
using ProjectName.Core.Application.UnitOfWork;
using ProjectName.Core.Domain.Entities;
using ProjectName.DataAccess.Database;
using ProjectName.DataAccess.Repositories;

namespace ProjectName.DataAccess
{
    public class UnitOfWork<TENTITY> : IUnitOfWork<TENTITY> where TENTITY : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            // may need to initialize repositories instance as a generic type
            Repository = new GenericRepository<TENTITY>(context);
        }

        public IRepository<TENTITY> Repository { get; set; }
        public void Dispose() => _context.Dispose();
        public async Task DisposeAsync() => await _context.DisposeAsync();
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}

