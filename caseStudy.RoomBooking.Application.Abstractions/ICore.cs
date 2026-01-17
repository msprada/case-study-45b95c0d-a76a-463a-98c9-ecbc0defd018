using caseStudy.RoomBooking.Domain.Repositories;    

namespace caseStudy.RoomBooking.Application.Abstractions
{
    public interface ICore
    {

        IUnitOfWork UnitOfWork { get; }
    }
}