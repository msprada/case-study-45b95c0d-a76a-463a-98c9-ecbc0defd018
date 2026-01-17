namespace caseStudy.RoomBooking.Domain.Entities
{
    public class BaseEntity
    {
         public string Id { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}