namespace caseStudy.RoomBooking.Domain.Repositories
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using caseStudy.RoomBooking.Domain.Entities;

    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IQueryable<T>> QueryAsync(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetByIdAsync(string id);

        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);
    }
}