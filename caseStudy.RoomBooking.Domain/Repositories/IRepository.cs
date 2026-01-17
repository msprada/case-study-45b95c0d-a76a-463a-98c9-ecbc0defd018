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
        Task<IEnumerable<T>> GetAll();

        Task<IQueryable<T>> Query(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetById(string id);

        Task Add(T entity);

        Task Delete(T entity);

        Task Update(T entity);
    }
}