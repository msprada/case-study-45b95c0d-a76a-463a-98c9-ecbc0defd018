using caseStudy.RoomBooking.Domain.Repositories;
using caseStudy.RoomBooking.Application.Abstractions;

namespace caseStudy.RoomBooking.Application
{

    public class CoreService : ICore
    {
        public IUnitOfWork UnitOfWork { get; private set; }

        public CoreService(IUnitOfWork unitOfWork)
        {

            this.UnitOfWork = unitOfWork;
        }
    }

}