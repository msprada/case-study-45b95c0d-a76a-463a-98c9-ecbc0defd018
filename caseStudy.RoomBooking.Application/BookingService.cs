using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Domain.Repositories;
using caseStudy.RoomBooking.Application.Abstractions;

public class BookingService:IBookingService
{
    private readonly IUnitOfWork _unitOfWork;

    public BookingService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.GetRepository<Booking>().AddAsync(booking);
        await _unitOfWork.SaveAllAsync();
        return booking;
    }

    public async Task<Booking> GetBookingByIdAsync(Guid bookingId)
    {
        return await _unitOfWork.GetRepository<Booking>().GetByIdAsync(bookingId.ToString());
    }

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
    {
        return await _unitOfWork.GetRepository<Booking>().GetAllAsync();
    }

    public async Task<bool> CancelBookingAsync(Guid bookingId)
    {
        var booking = await _unitOfWork.GetRepository<Booking>().GetByIdAsync(bookingId.ToString());
        if (booking == null)
        {
            return false;
        }

        await _unitOfWork.GetRepository<Booking>().DeleteAsync(booking);
        await _unitOfWork.SaveAllAsync();
        return true;
    }
}