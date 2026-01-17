namespace caseStudy.RoomBooking.Domain.Entities
{

    public class Booking : BaseEntity
    {
        public string RoomId { get; set; }

        public string UserId { get; set; }

        public DateTime Starting { get; set; }

        public DateTime Ending { get; set; }

    }
}