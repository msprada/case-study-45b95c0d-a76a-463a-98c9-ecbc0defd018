namespace caseStudy.RoomBooking.Infrastructure.Persistence
{

    using caseStudy.RoomBooking.Domain.Repositories;
    using caseStudy.RoomBooking.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected EFContext context;

        public EFRepository(EFContext context)
        {

            this.context = context;

        }

        public async Task<IEnumerable<T>> GetAll()
        {

            return await context.Set<T>().ToListAsync();

        }
        public async Task<IQueryable<T>> Query(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> query = context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;

        }

        public async Task<T> GetById(string id)
        {

            return await context.Set<T>().FindAsync(id);

        }

        public async Task Add(T entity)
        {

            await context.Set<T>().AddAsync(entity);

        }

        public async Task Delete(T entity)
        {

            context.Set<T>().Remove(entity);

        }

        public async Task Update(T entity)
        {

            var loaded = await GetById(entity.Id);

            if (loaded != null)
            {
                context.Entry(loaded).CurrentValues.SetValues(entity);
            }

        }
    }


}