namespace caseStudy.RoomBooking.Domain.Entities
{
    public class User:BaseEntity
    {
      
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}