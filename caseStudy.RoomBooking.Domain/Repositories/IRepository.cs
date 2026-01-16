namespace caseStudy.RoomBooking.Domain.Repositories
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using caseStudy.RoomBooking.Domain.Entities;

    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        IQueryable<T> Query(params Expression<Func<T, object>>[] includeProperties);

        T GetById(string id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}