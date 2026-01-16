namespace caseStudy.RoomBooking.Domain.Repositories
{
    using System.Collections.Generic;
    using caseStudy.RoomBooking.Domain.Entities;

    public interface IUser
    {
        IEnumerable<User> GetUserSet();
    }
}