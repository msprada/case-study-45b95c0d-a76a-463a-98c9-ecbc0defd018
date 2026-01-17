using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Domain.Repositories;
using caseStudy.RoomBooking.Application.Abstractions;

public class BookingService:IBookingService
{
    private readonly IRepository<Booking> _bookingRepository;

    public BookingService(IRepository<Booking> bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public async Task<Booking> CreateBookingAsync(BookingCreateDto request)
    {
        var booking = new Booking
        {
            RoomId = request.RoomId,
            UserId = request.UserId,
            Starting = request.Starting,
            Ending = request.Ending
        };

        await _bookingRepository.AddAsync(booking);
        return booking;
    }

    public async Task<Booking> GetBookingByIdAsync(Guid bookingId)
    {
        return await _bookingRepository.GetByIdAsync(bookingId.ToString());
    }

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
    {
        return await _bookingRepository.GetAllAsync();
    }

    public async Task<bool> CancelBookingAsync(Guid bookingId)
    {
        var booking = await _bookingRepository.GetByIdAsync(bookingId.ToString());
        if (booking == null)
        {
            return false;
        }

        await _bookingRepository.DeleteAsync(booking);
        return true;
    }
}