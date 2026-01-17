using caseStudy.RoomBooking.Domain.Entities;

namespace caseStudy.RoomBooking.Application.Abstractions
{

    public interface IBookingService
    {
        Task<Booking> CreateBookingAsync(BookingCreateDto request);
        Task<Booking> GetBookingByIdAsync(Guid bookingId);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<bool> CancelBookingAsync(Guid bookingId);
    }
}