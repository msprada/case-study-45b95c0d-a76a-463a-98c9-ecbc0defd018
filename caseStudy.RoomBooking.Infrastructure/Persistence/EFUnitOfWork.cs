using System;
using caseStudy.RoomBooking.Domain.Repositories;
using caseStudy.RoomBooking.Domain.Entities;

namespace caseStudy.RoomBooking.Infrastructure.Persistence
{
    public class EFUnitOfWork:IUnitOfWork, IDisposable
    {
        private readonly EFContext _context;

        public EFUnitOfWork(EFContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new EFRepository<T>(_context);
        }

        public async Task SaveAllAsync()
        {
            _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

   