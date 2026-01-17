namespace caseStudy.RoomBooking.Domain.Repositories
{

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using caseStudy.RoomBooking.Domain.Entities;

     public interface IUnitOfWork
    {
         IRepository<T> GetRepository<T>() where T:BaseEntity;
         Task SaveAllAsync();
    }
}