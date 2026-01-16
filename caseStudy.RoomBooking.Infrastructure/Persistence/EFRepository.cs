namespace caseStudy.RoomBooking.Infrastructure.Persistence
{

    using caseStudy.RoomBooking.Domain.Repositories;
    using caseStudy.RoomBooking.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;

    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected EFContext context;

        public EFRepository(EFContext context)
        {

            this.context = context;

        }

        public IEnumerable<T> GetAll()
        {

            return context.Set<T>().ToList();

        }
        public IQueryable<T> Query(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> query = context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;

        }

        public T GetById(string id)
        {

            return context.Set<T>().Find(id);

        }

        public void Add(T entity)
        {

            context.Set<T>().Add(entity);

        }

        public void Delete(T entity)
        {

            context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {

            var loaded = GetById(entity.Id);

            if (loaded != null)
            {
                context.Entry(loaded).CurrentValues.SetValues(entity);
            }

        }
    }


}