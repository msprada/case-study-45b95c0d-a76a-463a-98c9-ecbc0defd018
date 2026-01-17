namespace caseStudy.RoomBooking.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Modified { get; set; } = DateTime.Now;
    }
}